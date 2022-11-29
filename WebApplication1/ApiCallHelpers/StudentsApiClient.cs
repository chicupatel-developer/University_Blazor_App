using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace BlazorServerApp.ApiCallHelpers
{
    public class StudentsApiClient
    {
        private readonly HttpClient _httpClient;

        public StudentsApiClient(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<List<Student>?> GetStudentsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://localhost:44352/api/student/getstudents");
                response.EnsureSuccessStatusCode();
                string data = await response.Content.ReadAsStringAsync();
                // this one doesn't work                
                // return JsonSerializer.Deserialize<List<Student>>(data);

                // use Newtonsoft.Json package
                return JsonConvert.DeserializeObject<List<Student>>(data);

            }
            catch (Exception ex)
            {
                // Log and notify user
            }

            return new List<Student>();
        }
    }
}
