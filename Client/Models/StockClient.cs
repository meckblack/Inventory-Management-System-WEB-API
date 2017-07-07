﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Client.Models
{
    public class StockClient
    {
        private string BASE_URL = "http://localhost:64448/api/";

        public IEnumerable<Stock> FindAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("stock").Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<IEnumerable<Stock>>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }

        public Stock Find(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("stock/" + id).Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<Stock>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}