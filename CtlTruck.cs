
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TMS_Gate.CHCNetSDK;
using TMS_Gate.Model;
using TMS_Gate.Forms;
using Syncfusion.Windows.Forms;
using TMS_Gate.Models;
using System.Web;

namespace TMS_Gate
{
	public partial class CtlTruck : UserControl
	{
		private uint iLastErr = 0;
		private Int32 m_lUserID = -1;
		private bool m_bInitSDK = false;
		private Int32 m_lRealHandle = -1;
        private string str;
		private HttpPostedFileBase fileUpload;
        CHCNetSDK.REALDATACALLBACK RealData = null;
		public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg;

        public CtlTruck()
		{
			InitializeComponent();
			LoadData();
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
			if (m_bInitSDK == false)
			{
                MessageBoxAdv.Show(this, "NET_DVR_Init error!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
			}
			else
			{
				
				CHCNetSDK.NET_DVR_SetLogToFile(3, "D:\\SdkLog\\", true);
			}

			CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

			//string ip=ConfigurationManager.AppSettings.Get("device_ip");
			
			
			m_lUserID = CHCNetSDK.NET_DVR_Login_V30(Properties.Settings.Default.device_ip, Properties.Settings.Default.device_port, Properties.Settings.Default.device_admin, Properties.Settings.Default.device_pwd, ref DeviceInfo);
			if (m_lUserID < 0)
			{
				iLastErr = CHCNetSDK.NET_DVR_GetLastError();
				str = "NET_DVR_Login_V30 failed, error code= " + iLastErr; //µÇÂ¼Ê§°Ü£¬Êä³ö´íÎóºÅ
                MessageBoxAdv.Show(this, str, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}
			//else
			//{
   //             MessageBoxAdv.Show(this, "Login Success!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (m_lRealHandle >= 0)
			{
				CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
				m_lRealHandle = -1;
			}

			
			if (m_lUserID >= 0)
			{
				CHCNetSDK.NET_DVR_Logout(m_lUserID);
				m_lUserID = -1;
			}

			CHCNetSDK.NET_DVR_Cleanup();

		
			var p = this.Parent as Panel;
			if (p != null)
			{
				p.Controls.Remove(this);
			}
		}

		private void btnPreview_Click(object sender, EventArgs e)
		{          
            if (m_lUserID < 0)
			{
                MessageBoxAdv.Show(this, "Please login the device firstly", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
			}

			if (m_lRealHandle < 0)
			{
				CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
				lpPreviewInfo.hPlayWnd = RealPlayWnd.Handle;//Ô¤ÀÀ´°¿Ú
				lpPreviewInfo.lChannel = 1;//Ô¤teÀÀµÄÉè±¸Í¨µÀ
				lpPreviewInfo.dwStreamType = 0;//ÂëÁ÷ÀàÐÍ£º0-Ö÷ÂëÁ÷£¬1-×ÓÂëÁ÷£¬2-ÂëÁ÷3£¬3-ÂëÁ÷4£¬ÒÔ´ËÀàÍÆ
				lpPreviewInfo.dwLinkMode = 0;//Á¬½Ó·½Ê½£º0- TCP·½Ê½£¬1- UDP·½Ê½£¬2- ¶à²¥·½Ê½£¬3- RTP·½Ê½£¬4-RTP/RTSP£¬5-RSTP/HTTP 
				lpPreviewInfo.bBlocked = true; //0- ·Ç×èÈûÈ¡Á÷£¬1- ×èÈûÈ¡Á÷
				lpPreviewInfo.dwDisplayBufNum = 1; //²¥·Å¿â²¥·Å»º³åÇø×î´ó»º³åÖ¡Êý
				lpPreviewInfo.byProtoType = 0;
				lpPreviewInfo.byPreviewMode = 0;	
				if (RealData == null)
				{
					RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack);//Ô¤ÀÀÊµÊ±Á÷»Øµ÷º¯Êý
				}

				IntPtr pUser = new IntPtr();//ÓÃ»§Êý¾Ý

				//´ò¿ªÔ¤ÀÀ Start live view 
				m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);
				if (m_lRealHandle < 0)
				{
					iLastErr = CHCNetSDK.NET_DVR_GetLastError();
					str = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr; //Ô¤ÀÀÊ§°Ü£¬Êä³ö´íÎóºÅ
                    MessageBoxAdv.Show(this, str, "Gate In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
				}
				else
				{
					//Ô¤ÀÀ³É¹¦
					btnPreview.Text = "Stop View";
				}
			}
			else
			{
				//Í£Ö¹Ô¤ÀÀ Stop live view 
				if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
				{
					iLastErr = CHCNetSDK.NET_DVR_GetLastError();
					str = "NET_DVR_StopRealPlay failed, error code= " + iLastErr;
                    MessageBoxAdv.Show(this, str, "Gate In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
				}
				m_lRealHandle = -1;
				btnPreview.Text = "Live View";

			}
			return;
		}


		public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr pUser)
		{
			if (dwBufSize > 0)
			{
				byte[] sData = new byte[dwBufSize];
				Marshal.Copy(pBuffer, sData, 0, (Int32)dwBufSize);

				string str = "t1.ps";
				FileStream fs = new FileStream(str, FileMode.Create);
				int iLen = (int)dwBufSize;
				fs.Write(sData, 0, iLen);
				fs.Close();
			}
		}

		private void btnCapture_Click(object sender, EventArgs e)
		{
			BtnDisable();
			string sJpegPicFileName;
			//Í¼Æ¬±£´æÂ·¾¶ºÍÎÄ¼þÃû the path and file name to save
			sJpegPicFileName = "JPEG_test"+count+".jpg";

           int lChannel = 1; //Í¨µÀºÅ Channel number

			CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
			lpJpegPara.wPicQuality = 2; //Í¼ÏñÖÊÁ¿ Image quality
			lpJpegPara.wPicSize = 2; //×¥Í¼·Ö±æÂÊ Picture size: 2- 4CIF£¬0xff- Auto(Ê¹ÓÃµ±Ç°ÂëÁ÷·Ö±æÂÊ)£¬×¥Í¼·Ö±æÂÊÐèÒªÉè±¸Ö§³Ö£¬¸ü¶àÈ¡ÖµÇë²Î¿¼SDKÎÄµµ

			////JPEG×¥Í¼ Capture a JPEG picture
			if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName))
			{
				iLastErr = CHCNetSDK.NET_DVR_GetLastError();
				str = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr;
                MessageBoxAdv.Show(this, str, "Gate In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}
			else
			{
                count++;
				//str = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName;
                MessageBoxAdv.Show(this, "Successful to capture the JPEG file!", "Gate In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
			{
				iLastErr = CHCNetSDK.NET_DVR_GetLastError();
				str = "NET_DVR_StopRealPlay failed, error code= " + iLastErr;
                MessageBoxAdv.Show(this, str, "Gate In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}
			m_lRealHandle = -1;
			btnPreview.Text = "Live View";
			RealPlayWnd.Image = Image.FromFile(sJpegPicFileName);
			RealPlayWnd.SizeMode = PictureBoxSizeMode.StretchImage;
            // Convert the JPEG file to IFormFile
            fileUpload = ConvertFileToPostedFileBase(sJpegPicFileName, "image/jpeg");
			BtnEnable();
            return;
		}

        private HttpPostedFileBase ConvertFileToPostedFileBase(string filePath, string contentType)
        {
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            return new CustomPostedFile(fileStream, Path.GetFileName(filePath), contentType);
        }


        private void cmbcard_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (cmbcard.SelectedIndex != -1)
			{
                string cardNo = cmbcard.SelectedItem.ToString();
                FillInCheckData(cardNo);
            }			
        }

		private void BtnDisable()
		{
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnClose.Enabled = false;
            btnDetail.Enabled = false;
            btnPreview.Enabled = false;
            btnCapture.Enabled = false;
        }

        private void BtnEnable()
        {
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnClose.Enabled = true;
            btnDetail.Enabled = true;
            btnPreview.Enabled = true;
            btnCapture.Enabled = true;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBoxAdv.Show(this,
                   "Save changes?",
                   "Gate In",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question); 
            if (result == DialogResult.Yes)
            {
                BtnDisable();
                ResponseMessage msg = await SaveGateInData();
				if (msg.Status)
				{
					MessageBoxAdv.Show(this, "Successfuly Saved!", "Gate In", MessageBoxButtons.OK, MessageBoxIcon.Information);
					BtnEnable();
				}
				else
				{
					MessageBoxAdv.Show(this, msg.MessageContent, "Gate In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BtnEnable();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            BtnDisable();
            ClearData();
			btnPreview.Text = "Live View";
            BtnEnable();
        }
     
        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (cmbcard.SelectedItem != null)
            {
				var p = this.Parent as Panel;
				if (p != null)
				{
					p.Controls.Remove(this);
				}
				// Initialize controls
				CtlDetailPanel ctl = new CtlDetailPanel() { Dock = DockStyle.Fill };
				CtlTruckInDetail ctl1 = new CtlTruckInDetail() { Dock = DockStyle.Fill };
                CtlTruckInWBQ ctl2 = new CtlTruckInWBQ() { Dock = DockStyle.Fill };

                if (inboundCheck != null)
                {
                    // Populate CtlInDetail with data
                    ctl1.FillData(inboundCheck);
                    ctl.dinpanel1.Controls.Add(ctl1);

                    // Populate CtlTruckWBQ only if condition met
                    if (!string.IsNullOrEmpty(inboundCheck.InWeightBridgeID) ||
                        !string.IsNullOrEmpty(inboundCheck.OutWeightBridgeID))
                    {
                        ctl2.FillData(inboundCheck);
                        ctl.dinpanel2.Controls.Add(ctl2);
                    }
                }
                else
                {
                    MessageBoxAdv.Show(this, "InboundCheck data is missing.", "Gate In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Add main panel and show the form
                p.Controls.Add(ctl);
            }
            else
            {
                MessageBoxAdv.Show(this, "Please choose card No.", "Gate In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CtlTruck_Load(object sender, EventArgs e)
        {

        }

        private void lblyard_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblgate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTruckNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTrailerNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDriver_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCargoInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
