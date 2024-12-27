using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TMS_Gate.Models;

namespace TMS_Gate.Services
{
    public class GateApiService
    {
        public static readonly string _baseAddress = Properties.Settings.Default.ApiUrl;

        #region Gate In Dec_9_2024
        public async Task<List<ICD_InBoundCheck>> GetInBoundCheckCardList(string yard, string gate)
        {
            List<ICD_InBoundCheck> inboundList = new List<ICD_InBoundCheck>();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{_baseAddress}/api/GateSupport/GetInBoundCheckCardList/?yard={yard}&gate={gate}");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                inboundList = JsonConvert.DeserializeObject<List<ICD_InBoundCheck>>(content);
            }
            return inboundList;
        }
        public async Task<List<ICD_InBoundCheck>> GetInBoundCheckList(string yard, string gate,string fDate,string tDate)
        {
            List<ICD_InBoundCheck> inboundList = new List<ICD_InBoundCheck>();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{_baseAddress}/api/GateSupport/GetInBoundCheckList/?yard={yard}&gate={gate}&fDate={fDate}&tDate={tDate}");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                inboundList = JsonConvert.DeserializeObject<List<ICD_InBoundCheck>>(content);
            }
            return inboundList;
        }
        public async Task<ResponseMessage> SaveGateIn(ICD_InBoundCheck inGate)
        {
            ResponseMessage msg = new ResponseMessage();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Create the multipart content
                    var formData = new MultipartFormDataContent();

                    // Add the file
                    if (inGate.UploadPhoto != null) // Assuming `UploadPhoto` is the property for IFormFile
                    {
                        var stream = inGate.UploadPhoto.InputStream;
                        var fileContent = new StreamContent(stream);
                        fileContent.Headers.ContentType = new MediaTypeHeaderValue(inGate.UploadPhoto.ContentType);

                        // Add the file content to the form data
                        formData.Add(fileContent, "UploadPhoto", inGate.UploadPhoto.FileName);
                    }
                    else
                    {
                        msg.MessageContent = "Please take a photo!";
                        return msg;
                    }
                    // Add other properties as form fields
                    formData.Add(new StringContent(inGate.InRegNo.ToString()?? string.Empty), "InRegNo");
                    // Add additional fields as required from `inGate`

                    // Make the POST request
                    var response = await client.PostAsync($"{_baseAddress}/api/GateSupport/SaveGateIn", formData);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        msg = JsonConvert.DeserializeObject<ResponseMessage>(result);
                    }
                    else
                    {
                        // If the request fails, log the response content for debugging
                        string errorContent = await response.Content.ReadAsStringAsync();
                        throw new Exception($"Error {response.StatusCode}: {errorContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (e.g., to a file, console, or logging service)
                msg.MessageContent = $"An error occurred while saving gate in: {ex.Message}";
            }
            return msg;
        }
        #endregion
        #region Gate Out Dec_9_2024
        public async Task<List<ICD_OutBoundCheck>> GetOutBoundCheckCardList(string yard, string gate)
        {
            List<ICD_OutBoundCheck> outboundList = new List<ICD_OutBoundCheck>();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{_baseAddress}/api/GateSupport/GetOutBoundCheckCardList/?yard={yard}&gate={gate}");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                outboundList = JsonConvert.DeserializeObject<List<ICD_OutBoundCheck>>(content);
            }
            return outboundList;
        }
        public async Task<List<ICD_OutBoundCheck>> GetOutBoundCheckList(string yard, string gate, string fDate, string tDate)
        {
            List<ICD_OutBoundCheck> outboundList = new List<ICD_OutBoundCheck>();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{_baseAddress}/api/GateSupport/GetOutBoundCheckList/?yard={yard}&gate={gate}&fDate={fDate}&tDate={tDate}");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                outboundList = JsonConvert.DeserializeObject<List<ICD_OutBoundCheck>>(content);
            }
            return outboundList;
        }     
        public async Task<ResponseMessage> SaveGateOut(ICD_OutBoundCheck inGate)
        {
            ResponseMessage msg = new ResponseMessage();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Create the multipart content
                    var formData = new MultipartFormDataContent();

                    // Add the file
                    if (inGate.UploadPhoto != null) // Assuming `UploadPhoto` is the property for IFormFile
                    {
                        var stream = inGate.UploadPhoto.InputStream;
                        var fileContent = new StreamContent(stream);
                        fileContent.Headers.ContentType = new MediaTypeHeaderValue(inGate.UploadPhoto.ContentType);

                        // Add the file content to the form data
                        formData.Add(fileContent, "UploadPhoto", inGate.UploadPhoto.FileName);
                    }
                    else
                    {
                        msg.MessageContent = "Please take a photo!";
                        return msg;
                    }
                    // Add other properties as form fields
                    formData.Add(new StringContent(inGate.InRegNo.ToString() ?? string.Empty), "InRegNo");
                    formData.Add(new StringContent(inGate.OutRegNo.ToString() ?? string.Empty), "OutRegNo");
                    // Add additional fields as required from `inGate`

                    // Make the POST request
                    var response = await client.PostAsync($"{_baseAddress}/api/GateSupport/SaveGateOut", formData);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        msg = JsonConvert.DeserializeObject<ResponseMessage>(result);
                    }
                    else
                    {
                        // If the request fails, log the response content for debugging
                        string errorContent = await response.Content.ReadAsStringAsync();
                        throw new Exception($"Error {response.StatusCode}: {errorContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (e.g., to a file, console, or logging service)
                msg.MessageContent = $"An error occurred while saving gate in: {ex.Message}";
            }

            return msg;
        }
        #endregion

        #region Truck Status Report Dec_12_2024
        public async Task<List<ICD_TruckProcess>> GetTruckStatusReport(string yard, string gate, string fDate, string tDate,string status)
        {
            List<ICD_TruckProcess> processList = new List<ICD_TruckProcess>();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{_baseAddress}/api/GateSupport/GetTruckStatusReport/?yard={yard}&gate={gate}&fDate={fDate}&tDate={tDate}&status={status}");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                processList = JsonConvert.DeserializeObject<List<ICD_TruckProcess>>(content);
            }
            return processList;
        }

        #endregion

        #region Daily Report Dec_12_2024
        public async Task<List<ICD_TruckProcess>> GetDailyInReport(string yard, string gate, string fDate, string tDate)
        {
            List<ICD_TruckProcess> inList = new List<ICD_TruckProcess>();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{_baseAddress}/api/GateSupport/GetDailyInReport/?yard={yard}&gate={gate}&fDate={fDate}&tDate={tDate}");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                inList = JsonConvert.DeserializeObject<List<ICD_TruckProcess>>(content);
            }
            return inList;
        }
        public async Task<List<ICD_TruckProcess>> GetDailyOutReport(string yard, string gate, string fDate, string tDate)
        {
            List<ICD_TruckProcess> outList = new List<ICD_TruckProcess>();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{_baseAddress}/api/GateSupport/GetDailyOutReport/?yard={yard}&gate={gate}&fDate={fDate}&tDate={tDate}");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                outList = JsonConvert.DeserializeObject<List<ICD_TruckProcess>>(content);
            }
            return outList;
        }
        #endregion

    }
}
