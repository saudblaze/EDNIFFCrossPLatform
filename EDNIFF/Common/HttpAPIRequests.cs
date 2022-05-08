using EDNIFF.APIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EDNIFF.Common
{
    public class HttpAPIRequests
    {
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
}
