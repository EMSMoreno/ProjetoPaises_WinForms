using Newtonsoft.Json;
using ProjetoPaisesC;
using ProjetoPaisesC_;
using System.Diagnostics;

namespace ProjetoPaises_WinForms
{
    public partial class Form1 : Form
    {
        private List<ClassCountry> countries;
        private ProjetoPaisesC_.ClassSQLtoC dbSQL;
        private const string GitHubUsername = "EMSMoreno";

        public Form1()
        {
            InitializeComponent();

            string connectionString = "Data Source=countries.db;Version=3;";
            dbSQL = new ClassSQLtoC(connectionString);
            LoadCountries();
        }

        private async Task<List<ClassCountry>> FetchCountriesFromAPI()
        {
            var countriesList = new List<ClassCountry>();

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetStringAsync("https://restcountries.com/v3.1/all");
                    countriesList = JsonConvert.DeserializeObject<List<ClassCountry>>(response);

                    foreach (var country in countriesList)
                    {
                        // Adicionar a tradução manualmente
                        AddTranslation(country, "jpn", "日本", "日本", "東京");

                        // Preenche as propriedades adicionais
                        country.Timezones.AddRange(country.Timezones); // Passar as timezones
                        country.Continent = country.Region; // Passar a região
                        country.FlagDescription = country.Flags?.Alt; // Passar a descrição da bandeira
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os países: {ex.Message}");
            }

            return countriesList;
        }

        private void UpdateCountryDetails(ClassCountry selectedCountry)
        {
            txtName.Text = selectedCountry.CommonName;
            txtOfficialName.Text = selectedCountry.OfficialName;

            if (selectedCountry.Currencies != null && selectedCountry.Currencies.Count > 0)
            {
                var currency = selectedCountry.Currencies.Values.FirstOrDefault();
                txtCurrency.Text = currency != null ? currency.Name : "N/A";
                txtSymbol.Text = currency != null ? currency.Symbol : "N/A";
            }
            else
            {
                txtCurrency.Text = "N/A";
                txtSymbol.Text = "N/A";
            }

            txtCapital.Text = selectedCountry.Capital != null && selectedCountry.Capital.Count > 0 ? selectedCountry.Capital[0] : "";
            txtRegion.Text = selectedCountry.Region;
            txtSubregion.Text = selectedCountry.Subregion;
            txtPopulation.Text = selectedCountry.Population.ToString();
            txtGiniIndex.Text = selectedCountry.Gini != null && selectedCountry.Gini.GiniValue.HasValue ? selectedCountry.Gini.GiniValue.Value.ToString() : "N/A";
            txtTimezones.Text = string.Join(", ", selectedCountry.Timezones);
            txtCountryContinent.Text = selectedCountry.Continent;
            txtFlagDescription.Text = selectedCountry.FlagDescription;

            if (!string.IsNullOrEmpty(selectedCountry.Flags?.Png))
            {
                pictureBoxFlag.Load(selectedCountry.Flags.Png);
            }
            else
            {
                // Limpar a imagem se não houver bandeira
                pictureBoxFlag.Image = null;
            }
        }

        private async void LoadCountries()
        {
            progressBar.Value = 0;

            try
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    progressBar.Value = 20;
                    countries = await FetchCountriesFromAPI();
                    dbSQL.SaveCountries(countries);
                }
                else
                {
                    progressBar.Value = 50;
                    countries = dbSQL.GetCountries();
                }

                progressBar.Value = 100;
                DisplayCountries(); // Atualiza a exibição dos países no listBoxCountries
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os países: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCountries()
        {
            listBoxCountries.DataSource = countries;
            listBoxCountries.DisplayMember = "Name.Official"; //Será este o nome certo para mostrar o nome dos países na listBox
        }

        private void listBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCountries.SelectedItem != null)
            {
                ClassCountry selectedCountry = (ClassCountry)listBoxCountries.SelectedItem;
                UpdateCountryDetails(selectedCountry);
            }
        }

        #region Funções Extra

        private void SortCountriesByNameAZ() //Ordenar Paises A -> Z 
        {
            if (countries != null)
            {
                countries.Sort((c1, c2) => c1.CommonName.CompareTo(c2.CommonName));
                DisplayCountries(); // Atualiza a exibição após a ordenação
            }
        }

        private void SortCountriesByNameZA() //Ordenar Paises Z -> A 
        {
            if (countries != null)
            {
                countries.Sort((c1, c2) => c2.CommonName.CompareTo(c1.CommonName)); // Ordena de Z a A
                DisplayCountries();
            }
        }

        private void AddTranslation(ClassCountry country, string languageCode, string commonName, string officialName, string capital)
        {
            if (!country.Translations.ContainsKey(languageCode))
            {
                country.Translations[languageCode] = new ClassCountryTranslation
                {
                    CommonName = commonName,
                    OfficialName = officialName,
                    Capital = capital
                };
            }
        } //Não ligues a isto, é só uma feature q quero fazer, traduzir o nome dos país selecionado com um popup

        #endregion

        #region UI

        //Github
        private void btnGithub_Click(object sender, EventArgs e)
        {
            ShowGithub(GitHubUsername);
        }

        private void ShowGithub(string username)
        {
            try
            {
                string url = $"https://github.com/{username}";
                Process.Start(new ProcessStartInfo(url)
                {
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o perfil do GitHub: {ex.GetType().ToString()}\n{ex.Message}");
            }
        }


        //Order By
        private void btnSortAZ_Click(object sender, EventArgs e)
        {
            SortCountriesByNameAZ();
        } //Ascending

        private void btnSortZA_Click(object sender, EventArgs e)
        {
            SortCountriesByNameZA();
        } //Descending

        //Limpar Textboxes
        private void ClearTextBoxes()
        {
            txtName.Text = "";
            txtOfficialName.Text = "";
            txtCurrency.Text = "";
            txtSymbol.Text = "";
            txtCapital.Text = "";
            txtRegion.Text = "";
            txtSubregion.Text = "";
            txtPopulation.Text = "";
            txtGiniIndex.Text = "";
            txtFlagDescription.Text = "";
            txtCountryContinent.Text = "";
            txtTimezones.Text = "";
        }

        //Btn para limpar textboxes
        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        //Btn para carregar países
        private void btnLoadCountries_Click(object sender, EventArgs e)
        {
            LoadCountries();
        }

        #endregion

        
    }
}
