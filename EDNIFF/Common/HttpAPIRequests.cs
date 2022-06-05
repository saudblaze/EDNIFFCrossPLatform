using EDNIFF.APIModels;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EDNIFF.Common
{
    public class HttpAPIRequests
    {
        public async Task<APIResponse<T>> PostRequest<T>(string relativeUrl, dynamic postData)
        {
            try
            {

                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var postdata = Newtonsoft.Json.JsonConvert.SerializeObject(postData);


                    if (PublicVariables.authDetails != null)
                    {
                        if (!string.IsNullOrEmpty(PublicVariables.authDetails.access_token))
                            httpClient.DefaultRequestHeaders.Add("Authorization", PublicVariables.authDetails.token_type + " " + PublicVariables.authDetails.access_token);
                    }
                    var httpContent = new StringContent(postdata, Encoding.UTF8, "application/json");
                    HttpResponseMessage HttpResponseMessage = await httpClient.PostAsync(PublicVariables.WebApiURL + "/" + relativeUrl, httpContent);
                    if (HttpResponseMessage.StatusCode == HttpStatusCode.OK || HttpResponseMessage.StatusCode == HttpStatusCode.Created || HttpResponseMessage.StatusCode == HttpStatusCode.NoContent)
                    {
                        string Response = HttpResponseMessage.Content.ReadAsStringAsync().Result;
                        var resp = Newtonsoft.Json.JsonConvert.DeserializeObject<APIResponse<T>>(Response);
                        return resp;
                    }
                    else
                    {
                        return new APIResponse<T> { hasError = true, message = "Some error occured." + HttpResponseMessage.StatusCode, };
                    }
                }
            }
            catch (Exception ex)
            {
                return new APIResponse<T> { hasError = true, message = "Some error occured." + ex.Message, };
            }
        }

        public async Task<APIResponse<T>> GetRequest<T>(string relativeUrl, List<KeyValueText> getQueryData = null)
        {
            try
            {
                string querystring = string.Empty;
                if (getQueryData != null)
                {
                    var arry = getQueryData.Select(x => x.key + "=" + x.value).ToArray();
                    querystring = "?" + string.Join("&", arry);
                }
                using (var httpClient = new HttpClient())
                {
                    if (PublicVariables.authDetails != null)
                    {
                        if (!string.IsNullOrEmpty(PublicVariables.authDetails.access_token))
                            httpClient.DefaultRequestHeaders.Add("Authorization", PublicVariables.authDetails.token_type + " " + PublicVariables.authDetails.access_token);
                    }
                    //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //var postdata = Newtonsoft.Json.JsonConvert.SerializeObject(postData);
                    //var httpContent = new StringContent(postdata, Encoding.UTF8, "application/json");
                    HttpResponseMessage HttpResponseMessage = await httpClient.GetAsync(PublicVariables.WebApiURL + "/" + relativeUrl + querystring);
                    if (HttpResponseMessage.StatusCode == HttpStatusCode.OK || HttpResponseMessage.StatusCode == HttpStatusCode.Created || HttpResponseMessage.StatusCode == HttpStatusCode.NoContent)
                    {
                        string Response = HttpResponseMessage.Content.ReadAsStringAsync().Result;
                        var resp = Newtonsoft.Json.JsonConvert.DeserializeObject<APIResponse<T>>(Response);
                        return resp;
                    }
                    else
                    {
                        string Response = HttpResponseMessage.Content.ReadAsStringAsync().Result;
                        var resp = Newtonsoft.Json.JsonConvert.DeserializeObject<vwAPIError>(Response);
                        return new APIResponse<T> { hasError = true, message = resp.messageDetail };
                        //return new APIResponse<T> { hasError = true, message = "Some error occured." + HttpResponseMessage.StatusCode, };
                    }
                }
            }
            catch (Exception ex)
            {
                return new APIResponse<T> { hasError = true, message = "Some error occured." + ex.Message, };
            }
        }
        public async Task<APIResponse<T>> PostRequestForLogin<T>(string username, string password)
        {
            try
            {
                string postData = $"username={username}&password={password}&grant_type=password";
                using (var httpClient = new HttpClient())
                {
                    var httpContent = new StringContent(postData, Encoding.UTF8, "application/x-www-form-urlencoded");
                    HttpResponseMessage HttpResponseMessage = await httpClient.PostAsync(PublicVariables.WebApiURL + "/token", httpContent);
                    if (HttpResponseMessage.StatusCode == HttpStatusCode.OK || HttpResponseMessage.StatusCode == HttpStatusCode.Created || HttpResponseMessage.StatusCode == HttpStatusCode.NoContent)
                    {
                        string Response = HttpResponseMessage.Content.ReadAsStringAsync().Result;
                        var resp = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(Response);
                        return new APIResponse<T> { hasError = false, successData = resp };
                    }
                    else
                    {
                        string Response = HttpResponseMessage.Content.ReadAsStringAsync().Result;
                        var resp = Newtonsoft.Json.JsonConvert.DeserializeObject<vwLoginError>(Response);
                        return new APIResponse<T> { hasError = true, message = resp.error_description };
                    }
                }
            }
            catch (Exception ex)
            {
                return new APIResponse<T> { hasError = true, message = "Some error occured." + ex.Message, };
            }
        }
    }
    public class vwAPIError
    {
        public string message { get; set; }
        public string messageDetail { get; set; }
    }
}
