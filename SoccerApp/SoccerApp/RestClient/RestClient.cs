using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp.RestClient
{

    public class RestClient<T>
    {

        /// <summary>The web service URL</summary>
        private const string WebServiceUrl = "https://localhost:44399/api/Teams/";


        /// <summary>
        /// Retrieving the list of teams in the database.
        /// </summary>
        /// <returns></returns>
        public async Task<List<T>> GetAsync()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(WebServiceUrl);

            var teams = JsonConvert.DeserializeObject<List<T>>(json);

            return teams;
        }


        /// <summary>
        /// Adding new data to the database.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public async Task<bool> PostAsync(T t)
        {
            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(t);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpClient.PostAsync(WebServiceUrl, httpContent);

            return result.IsSuccessStatusCode;
        }

        /// <summary>
        /// Updating any team data in the database.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public async Task<bool> PutAsync(int id, T t)
        {
            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(t);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpClient.PutAsync(WebServiceUrl + id, httpContent);

            return result.IsSuccessStatusCode;
        }

        /// <summary>
        /// Deleting data from the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(int id)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.DeleteAsync(WebServiceUrl + id);

            return response.IsSuccessStatusCode;
        }


        /// <summary>
        /// Searching items with any keyword.
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
      /*  public async Task<List<T>> GetByKeywordAsync(string keyword)
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(WebServiceUrl + "Search/" + keyword);

            var teams = JsonConvert.DeserializeObject<List<T>>(json);

            return teams;
        } */
    }
}
