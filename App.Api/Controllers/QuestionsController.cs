using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.Api.Controllers
{
    [Route("/api/public/v{version:apiVersion}/Questions")]
    [ApiVersion("1.0")]
    public class QuestionsController : BaseApiController
    {
        // GET: api/<QuestionsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            //using (StreamReader r = new StreamReader("questions.json"))
            //{
            //    string json = r.ReadToEnd();
            //    List<Question> items = JsonConvert.DeserializeObject<List<Question>>(json);
            //    return Ok(items); 
            //}
            string jsonArray2 = "{\"data\":\"SIM5 Content Repository\",\"state\":\"closed\",\"icon\":\"FOLDER\",\"attr\":{\"id\":\"100000\",\"rel\":\"FOLDER\"},\"children\":[]}";
            var JsonGetAllContents = JsonConvert.DeserializeObject<Question>(jsonArray2);

            string url = "https://sim5.lms-qaint.pearsoncmg.com/SIM5Services/api/question/GetToken?tkn_SALTKEY=rz8LuOtFBXphj9WQfvFh";
            using var client = new HttpClient();
            var result = await client.GetAsync(url);
            string urlGetAllContents = "https://sim5.lms-qaint.pearsoncmg.com/SIM5Services/api/question/GetAllContents";
            var clientGetAllContents = new HttpClient();

            using var httpResponse =  clientGetAllContents.GetAsync(urlGetAllContents, HttpCompletionOption.ResponseHeadersRead).Result;

            httpResponse.EnsureSuccessStatusCode(); // throws if not 200-299

            if (httpResponse.Content is object && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
            {
                var contentStream = await httpResponse.Content.ReadAsStreamAsync();

                using var streamReader = new StreamReader(contentStream);
                using var jsonReader = new JsonTextReader(streamReader);

                JsonSerializer serializer = new JsonSerializer();

                try
                {
                    return Ok(serializer.Deserialize<Question[]>(jsonReader));
                }
                catch (JsonReaderException)
                {
                    Console.WriteLine("Invalid JSON.");
                }
            }
            else
            {
                Console.WriteLine("HTTP Response was invalid and cannot be deserialised.");
            }

            return null;



            /**

            var clientGetAllContents = new HttpClient();
            var resultGetAllContents = await clientGetAllContents.GetStringAsync(urlGetAllContents);
            string jsonArray2 = "[{\"data\":\"SIM5 Content Repository\",\"state\":\"closed\",\"icon\":\"FOLDER\",\"attr\":{\"id\":\"100000\",\"rel\":\"FOLDER\"},\"children\":[]}]";
            var JsonGetAllContents = JsonConvert.DeserializeObject<List<Question>>(resultGetAllContents);

            //var deptList = JsonSerializer.Deserialize<IList<Question>>(resultGetAllContents);
            string jsonArray = "[{\"DeptId\": 101,\"DepartmentName\":\"IT\" }, {\"DeptId\": 102,\"DepartmentName\":\"Accounts\" }]";
            //var deptList = JsonSerializer.Deserialize<IList<Department>>(jsonArray);
            var deptList = JsonConvert.DeserializeObject<IList<Department>>(jsonArray);

            var items = JsonConvert.DeserializeObject(resultGetAllContents);
            var itemsGetAllContents = JsonConvert.DeserializeObject(resultGetAllContents);
            //List<Question> items = JsonConvert.DeserializeObject<List<Question>>(resultGetAllContents);
            //JObject json = JObject.Parse(resultGetAllContents);
            string strjson = "{ \"context_name\": { \"lower_bound\": \"value\", \"upper_bound\": \"value\", \"values\": [ \"value1\", \"valueN\" ] } }";
            //var result = JsonConvert.DeserializeObject<T>(strjson);
            //JObject json = JObject.Parse(str);
            //return Ok(new Question());
            return Ok(JsonGetAllContents);
            */
        }

        // GET api/<QuestionsController>/5
        [HttpGet("{id}")]
        public async Task<List<Question>> GetAsync(int id)
        {
            HttpClient client = new HttpClient();
            try
            {
                string urlGetAllContents = "https://sim5.lms-qaint.pearsoncmg.com/SIM5Services/api/question/GetAllContents";

                HttpResponseMessage response = await client.GetAsync(urlGetAllContents);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                dynamic item = serializer.Deserialize<object>(responseBody);
                var JsonGetAllContents = JsonConvert.DeserializeObject<List<Question>>(item);
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                return JsonGetAllContents;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // POST api/<QuestionsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<QuestionsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuestionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    public class Department
    {
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }
    }
    public class Question
    {
        public Question()
        {
            children = new List<Question>();
            attr = new Attribute();
        }
        public string data { get; set; } = "";
        public string state { get; set; } = "";
        public string icon { get; set; } = "";
        public Attribute attr { get; set; }  
        public List<Question> children { get; set; } 
    }
    public class Attribute
    {
        public string id { get; set; } = "";
        public string rel { get; set; } = "";
    }
}
