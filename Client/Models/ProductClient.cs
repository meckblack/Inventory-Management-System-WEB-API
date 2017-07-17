using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Client.Models
{
    public class ProductClient
        {
            private string BASE_URL = "http://localhost:64448/api/";

            public IEnumerable<Product> FindAll()
            {
                try
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(BASE_URL);
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("product").Result;
                    if (response.IsSuccessStatusCode)
                        return response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                    return null;
                }
                catch
                {
                    return null;
                }
            }

        public Product FindByCategory(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("product/" + id).Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<Product>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }

        //public Product Find(int id)
        //    {
        //        try
        //        {
        //            HttpClient client = new HttpClient();
        //            client.BaseAddress = new Uri(BASE_URL);
        //            client.DefaultRequestHeaders.Accept.Add(
        //                new MediaTypeWithQualityHeaderValue("application/json"));
        //            HttpResponseMessage response = client.GetAsync("product/" + id).Result;
        //            if (response.IsSuccessStatusCode)
        //                return response.Content.ReadAsAsync<Product>().Result;
        //            return null;
        //        }
        //        catch
        //        {
        //            return null;
        //        }
        //    }

            public bool Create(Product product)
            {
                try
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(BASE_URL);
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.PostAsJsonAsync("product",
                        product).Result;
                    return response.IsSuccessStatusCode;
                }
                catch
                {
                    return false;
                }
            }

            public bool Delete(int id)
            {
                try
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(BASE_URL);
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.DeleteAsync("product/" +
                        id).Result;
                    return response.IsSuccessStatusCode;
                }
                catch
                {
                    return false;
                }
            }

            public bool Edit(Product product)
            {
                try
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(BASE_URL);
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.PutAsJsonAsync("product/" + product.Id,
                        product).Result;
                    return response.IsSuccessStatusCode;
                }
                catch
                {
                    return false;
                }
            }


        }
    }