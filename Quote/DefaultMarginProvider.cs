using System;
using System.Threading.Tasks;
using Quote.Contracts;
using System.Net;
//using System.Net.Http;
//using System.Json;

namespace Quote
{
    //esta clase ya no se necesita
    public class DefaultMarginProvider : IMarginProvider
    {
        private const string URL = "https://refactored-pancake.free.beeceptor.com/margin/";

        public decimal GetDefaultMargin()
        {
            return 0.25M;
        }

        public decimal GetMargin(string code)
        {
            decimal margin = 0.0M;

            //Task<decimal> task = Task.Run<decimal>(async () => await GetMarginFromAPI(code));
            //margin = Convert.ToDecimal(task.Result);

            return margin;
            //return 0.25M;
        }

        //public async Task<decimal> GetMarginFromAPI(string code)
        //{
        //    decimal margin = 0.0M;

        //    var callApi = new callAPI(URL);
        //    //var client = callApi.getClient();

        //    ////client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        //    try
        //    {
        //        //codigo duro no se pudó agregar Httpclient a NetStandard 1.0
        //        margin = 15.0M;
        //        //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        //        //HttpResponseMessage response = await client.GetAsync(code);
        //        //if (response.IsSuccessStatusCode)
        //        //{
        //        //    //return Ok(await response.Content.ReadAsStringAsync());
        //        //    if (response.StatusCode == HttpStatusCode.OK)
        //        //    {
        //        //        string responseString = await response.Content.ReadAsStringAsync();

        //        //        int colonPosition = responseString.IndexOf(":");
        //        //        string marginString = responseString.Substring(colonPosition, responseString.Length - 1);
        //        //        margin = Convert.ToDecimal(marginString);
        //        //    }
        //        //    else
        //        //    {

        //        //    }

        //        //}
        //        //else
        //        //{

        //        //}
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //    return margin;
        //    //return 0.25M;
        //}
    }
}
