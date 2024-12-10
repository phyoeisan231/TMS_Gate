using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TMS_Gate.Model;
using TMS_Gate.Models;

namespace TMS_Gate.Services
{
    public class GateApiService
    {
        public static readonly string _baseAddress = BaseUrl.ApiUrl;

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
                         var stream = inGate.UploadPhoto.OpenReadStream();
                        var fileContent = new StreamContent(stream);
                        fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(inGate.UploadPhoto.ContentType);
                        formData.Add(fileContent, "UploadPhoto", inGate.UploadPhoto.FileName);
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
                        var stream = inGate.UploadPhoto.OpenReadStream();
                        var fileContent = new StreamContent(stream);
                        fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(inGate.UploadPhoto.ContentType);
                        formData.Add(fileContent, "UploadPhoto", inGate.UploadPhoto.FileName);
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

    }
}
