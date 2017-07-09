using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Client.Models
{
    public class FixedAssetClient
    {
        private string BASE_URL = "http://localhost:64448/api/";

        public IEnumerable<FixedAsset> FindAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("fixedAsset").Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<IEnumerable<FixedAsset>>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }

        public FixedAsset Find(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("fixedAsset/" + id).Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<FixedAsset>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}