// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Net.Http;
// using System.Text;
// using System.Threading.Tasks;
// using Newtonsoft.Json;
// public class Methods
// {
//     public async Task<ClientResponse> AdminRequest(string method, string path, object data = null, bool text = false,
//         Dictionary<string, string> paramsDict = null, Dictionary<string, string> headers = null)
//     {
//         string adminUrl = ""; // Replace "" with the desired URL
// //         self.admin_url = f"http://{self.internal_host}:{admin_port}"
// // self.internal_host = internal_host or DEFAULT_INTERNAL_HOST
// // Akshita Gupta8:18 AM
// // DEFAULT_INTERNAL_HOST = "127.0.0.1"

//         paramsDict = paramsDict?.Where(kvp => kvp.Value != null).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

//         using (var client = new HttpClient())
//         {
//             var queryParams = paramsDict != null ? string.Join("&", paramsDict.Select(kvp =>
//                 $"{kvp.Key}={Uri.EscapeDataString(kvp.Value)}")) : null;
//             var requestUri = $"{adminUrl}{path}?{queryParams}";

//             var jsonContent = data != null ? new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
//                 : null;

//             if (headers != null)
//             {
//                 foreach (var header in headers)
//                 {
//                     client.DefaultRequestHeaders.Add(header.Key, header.Value);
//                 }
//             }

//             var response = await client.SendAsync(new HttpRequestMessage(new HttpMethod(method), requestUri)
//             {
//                 Content = jsonContent
//             });

//             var respText = await response.Content.ReadAsStringAsync();

//             try
//             {
//                 response.EnsureSuccessStatusCode();
//             }
//             catch (Exception e)
//             {
//                 throw new Exception($"Error: {respText}", e);
//             }

//             if (string.IsNullOrEmpty(respText) && !text)
//             {
//                 return null;
//             }

//             if (!text)
//             {
//                 try
//                 {
//                     return JsonConvert.DeserializeObject<ClientResponse>(respText);
//                 }
//                 catch (JsonException ex)
//                 {
//                     throw new Exception($"Error decoding JSON: {respText}", ex);
//                 }
//             }

//             return respText;
//         }
//     }

//     public async Task<ClientResponse> AgencyAdminPOST(string path, object data = null, bool text = false, object queryParams = null,
//         Dictionary<string, string> headers = null)
//     {
//         bool multitenant = false;
//         if (!multitenant)
//         {
//             throw new Exception("Error can't call agency admin unless in multitenant mode");
//         }

//         try
//         {
//             // EVENT_LOGGER.Debug(
//             // $"Controller POST {path} request to Agent{(data != null ? $" with data:\n{JsonConvert.SerializeObject(data)}" : "")}"
//             // );

//             if (headers == null)
//             {
//                 headers = new Dictionary<string, string>();
//             }

//             var response = await AdminRequest("POST", path, data, text, paramsDict: queryParams as Dictionary<string, string>, headers: headers);

//             // EVENT_LOGGER.Debug(
//             // $"Response from POST {path} received:\n{JsonConvert.SerializeObject(response)}"
//             // );

//             return response;
//         }
//         catch (ClientError e)
//         {
//             Console.Write($"Error during POST {path}: {e.Message}");
//             throw;
//         }
//     }
//  public async Task<ClientResponse> AdminGET(string path, bool text = false, object paramsDict = null, Dictionary<string, string> headers = null)
// {
//     bool multitenant = false;
//       var newWallet = await AgencyAdminPOST("/multitenancy/wallet", data, text, queryParams, headers: headers);
//         Console.Write("New wallet params:", newWallet);
//         var managedWalletParams = newWallet;
//     try
//     {
//         // EVENT_LOGGER.Debug($"Controller GET {path} request to Agent");

//         if (multitenant)
//         {
//             if (headers == null)
//             {
//                 headers = new Dictionary<string, string>();
//             }
//             headers["Authorization"] = "Bearer " + managedWalletParams["token"];
//         }

//         var response = await AdminRequest("GET", path, null, text, paramsDict as Dictionary<string, string>, headers: headers);

//         // EVENT_LOGGER.Debug($"Response from GET {path} received:\n{JsonConvert.SerializeObject(response)}");

//         return response;
//     }
//     catch (ClientError e)
//     {
//         Console.Write($"Error during GET {path}: {e.Message}");
//         throw;
//     }
// }


//     public void LogJson(string data, string label = null, Dictionary<string, object> kwargs = null)
// {
//     LogJson(data, label, prefixStr: this.PrefixStr, kwargs);
// }

//     public async Task<ClientResponse> AdminPOST(string path, object data = null, bool text = false, object queryParams = null,
//         Dictionary<string, string> headers = null)
//     {
//         var walletParams = new
//         {
//             // wallet_key = target_wallet_name,
//             // wallet_name = target_wallet_name,
//             // wallet_type = self.wallet_type,
//             // label = target_wallet_name,
//             // wallet_webhook_urls = self.webhook_url,
//             // wallet_dispatch_type = "both"
//         };

//         bool multitenant = false;

      


//         try
//         {
//             // EVENT_LOGGER.Debug(
//             // $"Controller POST {path} request to Agent{(data != null ? $" with data:\n{JsonConvert.SerializeObject(data)}" : "")}"
//             // );

//             if (multitenant)
//             {
//                 if (headers == null)
//                 {
//                     headers = new Dictionary<string, string>();
//                 }
//                 headers["Authorization"] = "Bearer " + managedWalletParams["token"];
//             }

//             var response = await AdminRequest("POST", path, data, text, (Dictionary<string, string>)queryParams, headers: headers);

//             // EVENT_LOGGER.Debug(
//             // $"Response from POST {path} received:\n{JsonConvert.SerializeObject(response)}"
//             // );

//             return response;
//         }
//         catch (ClientError e)
//         {
//             Console.Write($"Error during POST {path}: {e.Message}");
//             throw;
//         }
//     }
// }
