using System.Configuration;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjetoPaisesC;
using Newtonsoft.Json.Linq;

namespace ProjetoPaises_WinForms
{
    public partial class Form1 : Form
    {
        private List<ClassCountry> countries;
        private ProjetoPaisesC.ClassSQLtoC dbSQL;
        private const string GitHubUsername = "EMSMoreno";

        public Form1()
        {
            InitializeComponent();
            InitializeUI("UIMode");
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
                    var apiResponse = JArray.Parse(response);

                    foreach (var item in apiResponse)
                    {
                        // Usar JObject para deserializar os dados para a classe ClassCountry
                        var country = item.ToObject<ClassCountry>();

                        // Ajustar campos específicos
                        if (country.Name == null)
                        {
                            country.Name = new ClassCountry.ClassCountryName();
                        }

                        // Adicionar a tradução manualmente (se necessário)
                        // country.Translations.Add("jpn", new ClassCountryTranslation { Common = "日本", Official = "日本", NativeName = "東京" });

                        // Corrigir campos adicionais
                        country.Continent = country.Region; // Passar a região como continente, se aplicável
                        country.FlagDescription = country.Flags?.Alt; // Passar a descrição da bandeira

                        // Verificar se Timezones é nulo e inicializar se necessário
                        if (country.Timezones == null)
                        {
                            country.Timezones = new List<string>();
                        }

                        countriesList.Add(country);
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
            if (selectedCountry == null) return;

            // Atualiza os campos de texto com os detalhes do país
            txtName.Text = selectedCountry.Name.Common;
            txtOfficialName.Text = selectedCountry.Name.Official;

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

            txtCapital.Text = selectedCountry.Capital != null && selectedCountry.Capital.Count > 0 ? selectedCountry.Capital[0] : "N/A";
            txtRegion.Text = selectedCountry.Region ?? "N/A";
            txtSubregion.Text = selectedCountry.Subregion ?? "N/A";
            txtPopulation.Text = selectedCountry.Population.ToString();
            txtGiniIndex.Text = selectedCountry.Gini != null && selectedCountry.Gini.GiniValue.HasValue ? selectedCountry.Gini.GiniValue.Value.ToString() : "N/A";
            txtTimezones.Text = selectedCountry.Timezones != null ? string.Join(", ", selectedCountry.Timezones) : "N/A";
            txtCountryContinent.Text = selectedCountry.Continent ?? "N/A";
            txtFlagDescription.Text = selectedCountry.FlagDescription ?? "N/A";

            // Atualiza a imagem da bandeira se estiver disponível
            if (!string.IsNullOrEmpty(selectedCountry.Flags?.Png))
            {
                try
                {
                    pictureBoxFlag.Load(selectedCountry.Flags.Png);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar a imagem da bandeira: {ex.Message}");
                    pictureBoxFlag.Image = null; // Limpa a imagem se houver erro
                }
            }
            else
            {
                pictureBoxFlag.Image = null; // Limpa a imagem se não houver URL
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
                DisplayCountries(); // Atualiza a exibição dos países no ListBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os países: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCountries()
        {
            if (countries != null && countries.Count > 0)
            {
                listBoxCountries.DataSource = countries;
                listBoxCountries.DisplayMember = "CommonName"; // Ou use "OfficialName" se preferir
            }
            else
            {
                listBoxCountries.DataSource = null; // Limpar o DataSource se a lista estiver vazia
            }
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

        private void InitializeUI(string key)
        {
            try
            {
                var uiMode = ConfigurationManager.AppSettings[key];
                if (uiMode == "light")
                {
                    btnDarkMode.Text = "Enable Light Mode";
                    this.ForeColor = Color.FromArgb(245, 247, 246);
                    this.BackColor = Color.FromArgb(3, 0, 10);
                    ConfigurationManager.AppSettings[key] = "dark";

                }
                else
                {
                    btnDarkMode.Text = "Enable Dark Mode";
                    this.ForeColor = Color.FromArgb(3, 0, 10);
                    this.BackColor = Color.FromArgb(245, 247, 246);
                    ConfigurationManager.AppSettings[key] = "light";
                }
            }
            catch
            {
                throw;
            }
        } //Funcionalidade Dark Mode

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            InitializeUI("UIMode");
        } // btn Dark Mode

        private void btnCleanCountry_Click(object sender, EventArgs e)
        {
            txtSearchCountry.Text = string.Empty;
        } // btn Limpar país procurado

        private void SortCountriesByNameAZ() // Ordenar Países A -> Z
        {
            if (countries != null)
            {
                countries.Sort((c1, c2) => string.Compare(c1.Name.Common, c2.Name.Common, StringComparison.OrdinalIgnoreCase));
                DisplayCountries(); // Atualiza a exibição após a ordenação
            }
        }

        private void SortCountriesByNameZA() // Ordenar Países Z -> A
        {
            if (countries != null)
            {
                countries.Sort((c1, c2) => string.Compare(c2.Name.Common, c1.Name.Common, StringComparison.OrdinalIgnoreCase));
                DisplayCountries(); // Atualiza a exibição após a ordenação
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
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            ShowGithub(GitHubUsername);
        } // btn abrir Github

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
