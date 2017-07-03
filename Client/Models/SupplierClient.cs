﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace Client.Models
{
    public class SupplierClient
    {
        private string BASE_URL = "http://localhost:64448/api/";

        public IEnumerable<Supplier> findAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("suppliers").Result;
                if(response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<IEnumerable<Supplier>>().Result;
                return null;   
            }
            catch
            {
                return null;
            }
        }

        public Supplier find(int Id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("suppliers/" + Id).Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<Supplier>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}