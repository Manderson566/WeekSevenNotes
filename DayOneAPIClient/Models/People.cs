using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DayOneAPIClient.Models
{
    class PeopleCollection
    {
        public string Count { get; set; }
        public Uri Next { get; set; }
        public string Previous { get; set; }
        public List<People> Results { get; set; }

        public PeopleCollection GetPrevious(HttpClient client)
        {

            string pageNumber = page.Query;
            if (pageNumber != null)
            {
                var allPeopleResponse = client.GetAsync($"people{ pageNumber}").Result;

                return allPeopleResponse.Content.ReadAsAsync<PeopleCollection>().Result;
            }
            return this;
        }

        public PeopleCollection GetNext(HttpClient client)
        {

            var allPeopleResponse = client.GetAsync($"people{pageNumber}").Result;
            return allPeopleResponse.Content.ReadAsAsync<PeopleCollection>().Result;
        }


    }

    class People
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string Hair_Color { get; set; }
        public Uri Homeworld { get; set; }

        public Planet HomeworldDetail {HttpClient client }
        {
            var response = client.GetAsync(Homeworld.Id)
        }

    }
}
