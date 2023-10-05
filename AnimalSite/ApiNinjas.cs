using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace AnimalSite
{
    public class ApiNinjasCatInfo
    {
        [JsonProperty("image_link")]
        public string ImageLink { get; set; }

        [JsonProperty("family_friendly")]
        public int FamilyFriendly { get; set; }

        [JsonProperty("shedding")]
        public int Shedding { get; set; }

        [JsonProperty("general_health")]
        public int GeneralHealth { get; set; }

        [JsonProperty("playfulness")]
        public int Playfulness { get; set; }

        [JsonProperty("children_friendly")]
        public int ChildrenFriendly { get; set; }

        [JsonProperty("grooming")]
        public int Grooming { get; set; }

        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }

        [JsonProperty("other_pets_friendly")]
        public int OtherPetsFriendly { get; set; }

        [JsonProperty("min_life_expectancy")]
        public double MinLifeExpectancy { get; set; }

        [JsonProperty("max_life_expectancy")]
        public double MaxLifeExpectancy { get; set; }

        [JsonProperty("max_weight")]
        public double MaxWeight { get; set; }

        [JsonProperty("min_weight")]
        public double MinWeight { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("length")]
        public string Length { get; set; }
    }

    public class ApiNinjasDogInfo
    {
        [JsonProperty("image_link")]
        public string ImageLink { get; set; }

        [JsonProperty("good_with_children")]
        public int GoodWithChildren { get; set; }

        [JsonProperty("good_with_other_dogs")]
        public int GoodWithOtherDogs { get; set; }

        [JsonProperty("shedding")]
        public int Shedding { get; set; }

        [JsonProperty("grooming")]
        public int Grooming { get; set; }

        [JsonProperty("drooling")]
        public int Drooling { get; set; }

        [JsonProperty("coat_length")]
        public int CoatLength { get; set; }

        [JsonProperty("good_with_strangers")]
        public int GoodWithStrangers { get; set; }

        [JsonProperty("playfulness")]
        public int Playfulness { get; set; }

        [JsonProperty("protectiveness")]
        public int Protectiveness { get; set; }

        [JsonProperty("trainability")]
        public int Trainability { get; set; }

        [JsonProperty("energy")]
        public int Energy { get; set; }

        [JsonProperty("barking")]
        public int Barking { get; set; }

        [JsonProperty("min_life_expectancy")]
        public double MinLifeExpectancy { get; set; }

        [JsonProperty("max_life_expectancy")]
        public double MaxLifeExpectancy { get; set; }

        [JsonProperty("max_height_male")]
        public double MaxHeightMale { get; set; }

        [JsonProperty("max_height_female")]
        public double MaxHeightFemale { get; set; }

        [JsonProperty("max_weight_male")]
        public double MaxWeightMale { get; set; }

        [JsonProperty("max_weight_female")]
        public double MaxWeightFemale { get; set; }

        [JsonProperty("min_height_male")]
        public double MinHeightMale { get; set; }

        [JsonProperty("min_height_female")]
        public double MinHeightFemale { get; set; }

        [JsonProperty("min_weight_male")]
        public double MinWeightMale { get; set; }

        [JsonProperty("min_weight_female")]
        public double MinWeightFemale { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ApiNinjas
    {
        public ApiNinjas(string apiKey)
        {
            _client.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
            _client.Timeout = TimeSpan.FromSeconds(5);
        }

        public static ApiNinjas Instance = new ApiNinjas("hzFAxGAfo7LEYKb22heuzA==NmgmzGnX1Ph4uXmC");

        private string _endpoint = "https://api.api-ninjas.com/v1";
        private HttpClient _client = new HttpClient();
        public async Task<ApiNinjasCatInfo> GetCatInfoAsync(string name)
        {
            HttpResponseMessage response = _client.GetAsync($"{_endpoint}/cats?name={name}").Result;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                ApiNinjasCatInfo[] catInfo;
                try
                {
                    if (responseBody.Length < 20) throw new Exception();
                    catInfo = JsonConvert.DeserializeObject<ApiNinjasCatInfo[]>(responseBody);
                }
                catch
                {
                    return new ApiNinjasCatInfo
                    {
                        ImageLink = "",
                        Shedding = 1,
                        Grooming = 1,
                        Playfulness = 1,
                        MinLifeExpectancy = 1,
                        MaxLifeExpectancy = 15,
                        Name = "",
                        ChildrenFriendly = 1,
                        FamilyFriendly = 1,
                        GeneralHealth = 1,
                        Intelligence = 1,
                        Length = "",
                        MaxWeight = 30,
                        MinWeight = 1,
                        Origin = "",
                        OtherPetsFriendly = 1,
                    };
                }

                if (catInfo.Length > 0)
                {
                    ApiNinjasCatInfo retrievedCatInfo = catInfo[0];
                    return retrievedCatInfo;
                }
                {
                    return null;
                }
            }
            else
            {
                throw new Exception("Error fetching cat information. Status code: " + response.StatusCode);
            }
        }

        public async Task<ApiNinjasDogInfo> GetDogInfoAsync(string name)
        {
            HttpResponseMessage response = _client.GetAsync($"{_endpoint}/dogs?name={name}").Result;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                ApiNinjasDogInfo[] dogInfo;
                try
                {
                    if (responseBody.Length < 20) throw new Exception();
                    dogInfo = JsonConvert.DeserializeObject<ApiNinjasDogInfo[]>(responseBody);
                }
                catch
                {
                    return new ApiNinjasDogInfo
                    {
                        ImageLink = "",
                        GoodWithChildren = 1,
                        GoodWithOtherDogs = 1,
                        Shedding = 1,
                        Grooming = 1,
                        Drooling = 1,
                        CoatLength = 1,
                        GoodWithStrangers = 1,
                        Playfulness = 1,
                        Protectiveness = 1,
                        Trainability = 1,
                        Energy = 1,
                        Barking = 1,
                        MinLifeExpectancy = 1,
                        MaxLifeExpectancy = 15,
                        MaxHeightMale = 40,
                        MaxHeightFemale = 40,
                        MaxWeightMale = 30,
                        MaxWeightFemale = 30,
                        MinHeightMale = 1,
                        MinHeightFemale = 1,
                        MinWeightMale = 1,
                        MinWeightFemale = 1,
                        Name = "",
                    };
                }

                if (dogInfo.Length > 0)
                {
                    ApiNinjasDogInfo retrievedDogInfo = dogInfo[0];
                    return retrievedDogInfo;
                }
                {
                    return null;
                }
            }
            else
            {
                throw new Exception("Error fetching dog information. Status code: " + response.StatusCode);
            }
        }
    }
}