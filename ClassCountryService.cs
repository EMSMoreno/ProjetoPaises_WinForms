using Newtonsoft.Json;

namespace ProjetoPaisesC
{
    public class ClassCountryService
    {
        private readonly HttpClient client;

        public ClassCountryService()
        {
            client = new HttpClient();
        }

        public async Task<List<ClassCountry>> FetchCountriesFromAPI(IProgress<int> progress)
        {
            var countries = new List<ClassCountry>();
            var response = await client.GetStringAsync("https://restcountries.com/v3.1/all");
            countries = JsonConvert.DeserializeObject<List<ClassCountry>>(response);

            for (int i = 0; i < countries.Count; i++)
            {
                // Simulate progress
                await Task.Delay(10);
                progress?.Report((i + 1) * 100 / countries.Count);
            }

            return countries;
        }
    }
}

