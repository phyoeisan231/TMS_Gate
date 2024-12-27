
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TMS_Gate.Forms;
using Syncfusion.Windows.Forms;
using TMS_Gate.Models;
using System.Web;
using System.Threading;

namespace TMS_Gate
{
	public partial class CtlTruck : UserControl
	{
		private uint iLastErr = 0;
		private Int32 m_lUserID = -1;
		private bool m_bInitSDK = false;
		private Int32 m_lRealHandle = -1;
        private string str;
        private string truckNo;
		private HttpPostedFileBase fileUpload;
        HCNetSDK.REALDATACALLBACK RealData = null;
		public HCNetSDK.NET_DVR_PTZPOS m_struPtzCfg;
        private bool LoginCallBackFlag = false;
        CHCNetSDK.NET_DVR_DEVICEINFO_V30 m_struDeviceInfo;
        private uint m_AysnLoginResult = 0;
        private int m_iUserID = -1;
        public int m_iDeviceIndex = -1;
        Random rd = new Random();
        public int m_index = 0;
        //
        public CtlTruck()
		{
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            InitializeComponent();
            LoadData();
        }
        private void InitializeSDK()
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;

            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
            if (!m_bInitSDK)
            {
                MessageBox.Show("SDK initialization failed. Please check the setup.");
                return;
            }

            // Set log file path
            CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
            TryLoginToDevice();
        }
        private void InitializeCHCNetSDK()
        {
            m_bInitSDK = HCNetSDK.NET_DVR_Init();
            if (m_bInitSDK == false)
            {
                MessageBoxAdv.Show(this, "NET_DVR_Init error!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {

                HCNetSDK.NET_DVR_SetLogToFile(3, "D:\\SdkLog\\", true);
            }

            HCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new HCNetSDK.NET_DVR_DEVICEINFO_V30();

            m_lUserID = HCNetSDK.NET_DVR_Login_V30(Properties.Settings.Default.device_ip, Properties.Settings.Default.device_port, Properties.Settings.Default.device_admin, Properties.Settings.Default.device_pwd, ref DeviceInfo);
            if (m_lUserID < 0)
            {
                iLastErr = HCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_Login_V30 failed, error code= " + iLastErr; //µÇÂ¼Ê§°Ü£¬Êä³ö´íÎóºÅ
                MessageBoxAdv.Show(this, str, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void TryLoginToDevice()
        {
            // Initialize device structures
            CHCNetSDK.NET_DVR_DEVICEINFO_V40 deviceInfoV40 = InitializeDeviceInfo();
            CHCNetSDK.NET_DVR_USER_LOGIN_INFO loginInfo = InitializeLoginInfo();

            // Attempt to login
            int userID = CHCNetSDK.NET_DVR_Login_V40(ref loginInfo, ref deviceInfoV40);

            if (loginInfo.bUseAsynLogin)
            {
                HandleAsynchronousLogin(ref userID, deviceInfoV40);
            }

            if (userID < 0)
            {
                HandleLoginFailure(loginInfo, deviceInfoV40);
            }
            else
            {
                HandleLoginSuccess(ref userID, deviceInfoV40);
            }

            m_lUserID = userID;
        }
        private CHCNetSDK.NET_DVR_USER_LOGIN_INFO InitializeLoginInfo()
        {
            return new CHCNetSDK.NET_DVR_USER_LOGIN_INFO
            {
                sDeviceAddress = Properties.Settings.Default.device_ip,
                sUserName = Properties.Settings.Default.device_admin,
                sPassword = Properties.Settings.Default.device_pwd,
                wPort = (ushort)Properties.Settings.Default.device_port,
                bUseAsynLogin = false // Set this to true if async login is required
            };
        }
        private CHCNetSDK.NET_DVR_DEVICEINFO_V40 InitializeDeviceInfo()
        {
            var deviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V40
            {
                struDeviceV30 = new CHCNetSDK.NET_DVR_DEVICEINFO_V30
                {
                    sSerialNumber = new byte[CHCNetSDK.SERIALNO_LEN]
                }
            };

            return deviceInfo;
        }
        private void HandleAsynchronousLogin(ref int userID, CHCNetSDK.NET_DVR_DEVICEINFO_V40 deviceInfoV40)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (!LoginCallBackFlag)
                {
                    Thread.Sleep(5);
                }
                else
                {
                    break;
                }
            }

            if (!LoginCallBackFlag)
            {
                MessageBox.Show("Asynchronous login callback timeout!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (m_AysnLoginResult == 1)
            {
                userID = m_iUserID;
                deviceInfoV40.struDeviceV30 = m_struDeviceInfo;
            }
            else
            {
                MessageBox.Show("Asynchronous login failed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void HandleLoginFailure(CHCNetSDK.NET_DVR_USER_LOGIN_INFO loginInfo, CHCNetSDK.NET_DVR_DEVICEINFO_V40 deviceInfoV40)
        {
            uint errorCode = CHCNetSDK.NET_DVR_GetLastError();
            string errorMsg = $"Login failed for device [{loginInfo.sDeviceAddress}]. Error Code: {errorCode}";
            CHCNetSDK.AddLog(-1, CHCNetSDK.OPERATION_FAIL_T, errorMsg);

            if (errorCode == CHCNetSDK.NET_DVR_PASSWORD_ERROR && deviceInfoV40.bySupportLock == 1)
            {
                MessageBox.Show($"Username or password error! Remaining attempts: {deviceInfoV40.byRetryLoginTime}");
            }
            else if (errorCode == CHCNetSDK.NET_DVR_USER_LOCKED)
            {
                MessageBox.Show($"IP is locked. Remaining lock time: {deviceInfoV40.dwSurplusLockTime} seconds");
            }
            else
            {
                MessageBox.Show("Network error or DVR is busy!");
            }
        }
        private void HandleLoginSuccess(ref int userID, CHCNetSDK.NET_DVR_DEVICEINFO_V40 deviceInfoV40)
        {
            if (deviceInfoV40.byPasswordLevel == 1)
            {
                MessageBox.Show("Default password detected. Please change it immediately.");
            }
            else if (deviceInfoV40.byPasswordLevel == 3)
            {
                MessageBox.Show("Weak password detected. Please use a stronger password.");
            }

            m_struDeviceInfo = deviceInfoV40.struDeviceV30;

            // Load device configuration
            LoadDeviceConfiguration(userID);
        }
        private void LoadDeviceConfiguration(int userID)
        {
            var deviceConfig = new CHCNetSDK.NET_DVR_DEVICECFG_V40
            {
                sDVRName = new byte[CHCNetSDK.NAME_LEN],
                sSerialNumber = new byte[CHCNetSDK.SERIALNO_LEN],
                byDevTypeName = new byte[CHCNetSDK.DEV_TYPE_NAME_LEN]
            };

            uint configSize = (uint)Marshal.SizeOf(deviceConfig);
            IntPtr configPtr = Marshal.AllocHGlobal((int)configSize);
            try
            {
                Marshal.StructureToPtr(deviceConfig, configPtr, false);

                if (!CHCNetSDK.NET_DVR_GetDVRConfig(userID, CHCNetSDK.NET_DVR_GET_DEVICECFG_V40, 0, configPtr, configSize, ref configSize))
                {
                    CHCNetSDK.AddLog(userID, CHCNetSDK.OPERATION_FAIL_T, "Failed to retrieve device configuration.");
                }
            }
            finally
            {
                Marshal.FreeHGlobal(configPtr);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
		{
			if (m_lRealHandle >= 0)
			{
				HCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
				m_lRealHandle = -1;
			}			
			if (m_lUserID >= 0)
			{
				HCNetSDK.NET_DVR_Logout(m_lUserID);
				m_lUserID = -1;
			}
			HCNetSDK.NET_DVR_Cleanup();
            var p = this.Parent as Panel;
            if (p != null)
            {
                FrmMain main = new FrmMain();
                p.Controls.Remove(this);
                p.Controls.Add(main.pictureHome);

            }
        }
		private void btnPreview_Click(object sender, EventArgs e)
		{
            InitializeCHCNetSDK();
            if (m_lUserID < 0)
			{
                MessageBoxAdv.Show(this, "Please login the device firstly", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
			}

			if (m_lRealHandle < 0)
			{
				HCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new HCNetSDK.NET_DVR_PREVIEWINFO();
				lpPreviewInfo.hPlayWnd = RealPlayWnd.Handle;
				lpPreviewInfo.lChannel = 1;
				lpPreviewInfo.dwStreamType = 0;
				lpPreviewInfo.dwLinkMode = 0;
				lpPreviewInfo.bBlocked = true; 
				lpPreviewInfo.dwDisplayBufNum = 1;
				lpPreviewInfo.byProtoType = 0;
				lpPreviewInfo.byPreviewMode = 0;	
				if (RealData == null)
				{
					RealData = new HCNetSDK.REALDATACALLBACK(RealDataCallBack);
				}

				IntPtr pUser = new IntPtr();

				//´ò¿ªÔ¤ÀÀ Start live view 
				m_lRealHandle = HCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);
				if (m_lRealHandle < 0)
				{
					iLastErr = HCNetSDK.NET_DVR_GetLastError();
					str = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr;
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
				if (!HCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
				{
					iLastErr = HCNetSDK.NET_DVR_GetLastError();
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
            InitializeCHCNetSDK();
            BtnDisable();
			string sJpegPicFileName;
			sJpegPicFileName = "JPEG_test"+count+".jpg";

           int lChannel = 1;

			HCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new HCNetSDK.NET_DVR_JPEGPARA();
			lpJpegPara.wPicQuality = 2; 
			lpJpegPara.wPicSize = 2; 

			if (!HCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName))
			{
				iLastErr = HCNetSDK.NET_DVR_GetLastError();
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


            if (!HCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
			{
				iLastErr = HCNetSDK.NET_DVR_GetLastError();
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
        private void btnSnap_Click(object sender, EventArgs e)
        {
            InitializeSDK();
            TMS_Gate.CHCNetSDK.NET_DVR_MANUALSNAP struManualSnap = new TMS_Gate.CHCNetSDK.NET_DVR_MANUALSNAP();
            TMS_Gate.CHCNetSDK.NET_DVR_PLATE_RESULT struPlateResult = new TMS_Gate.CHCNetSDK.NET_DVR_PLATE_RESULT();
            struManualSnap.byLaneNo = 1;
            //struPlateResult.pBuffer1 = Marshal.AllocHGlobal(2 * 1024 * 1024);

            struPlateResult.pBuffer2 = Marshal.AllocHGlobal(2 * 1024 * 1024);
            //if (!CHCNetSDK.NET_DVR_ManualSnap((int)deviceInfo.lLoginID, ref struManualSnap, ref struPlateResult))

            if (!CHCNetSDK.NET_DVR_ManualSnap(m_lUserID, ref struManualSnap, ref struPlateResult))
            {
                uint iLastErr = HCNetSDK.NET_DVR_GetLastError();
                string strErr = "NET_DVR_ManualSnap fail, Err：" + iLastErr;
                MessageBox.Show(strErr);
            }
            else
            {
                m_index++;
                truckNo= System.Text.Encoding.Default.GetString(struPlateResult.struPlateInfo.sLicense);
                if (truckNo != txtTruckNo.Text)
                {
                    MessageBox.Show("Truck No didn't match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                string strFileSavePath = Application.StartupPath + "\\ANPRManualSnap\\" + DateTime.Now.ToString("yyyy-MM-dd");
                if (!Directory.Exists(strFileSavePath))
                    Directory.CreateDirectory(strFileSavePath);

                //if (struPlateResult.pBuffer1 != IntPtr.Zero && struPlateResult.dwPicLen != 0)
                //{
                //    string strCloseUpPicPath = strFileSavePath + "\\CloseUpPic_" + DateTime.Now.ToString("yyyyMMddhhmmssfff") + "_" + rd.Next().ToString() + ".jpg";
                //    FileStream fs = new FileStream(strCloseUpPicPath, FileMode.Create);
                //    int iLen = (int)struPlateResult.dwPicLen;
                //    byte[] by = new byte[iLen];
                //    Marshal.Copy(struPlateResult.pBuffer1, by, 0, iLen);
                //    fs.Write(by, 0, iLen);
                //    fs.Close();
                //    RealPlayWnd.Image = Image.FromFile(strCloseUpPicPath);
                //    // picPath
                //    //lvi.SubItems.Add(strCloseUpPicPath);
                //}
                if (struPlateResult.pBuffer2 != IntPtr.Zero && struPlateResult.dwPicPlateLen != 0)
                {
                    string strPlatePicPath = strFileSavePath + "\\PlatePic_" + DateTime.Now.ToString("yyyyMMddhhmmssfff") + "_" + rd.Next().ToString() + ".jpg"; ;
                    FileStream fs = new FileStream(strPlatePicPath, FileMode.Create);
                    int iLen = (int)struPlateResult.dwPicPlateLen;
                    byte[] by = new byte[iLen];
                    Marshal.Copy(struPlateResult.pBuffer2, by, 0, iLen);
                    fs.Write(by, 0, iLen);
                    fs.Close();
                    RealPlayWnd.Image = Image.FromFile(strPlatePicPath);
                    m_lRealHandle = -1;
                    btnPreview.Text = "Live View";
                    RealPlayWnd.SizeMode = PictureBoxSizeMode.StretchImage;
                    // Convert the JPEG file to IFormFile
                    fileUpload = ConvertFileToPostedFileBase(strPlatePicPath, "image/jpeg");
                    BtnEnable();
                }
                //Marshal.FreeHGlobal(struPlateResult.pBuffer1);
                Marshal.FreeHGlobal(struPlateResult.pBuffer2);
            }
        }
    }
}
