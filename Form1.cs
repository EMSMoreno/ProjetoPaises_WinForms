using Newtonsoft.Json.Linq;
using ProjetoPaisesC;
using System.Configuration;
using System.Diagnostics;

namespace ProjetoPaises_WinForms
{
    public partial class Form1 : Form
    {
        private List<ClassCountry> countries;
        private ProjetoPaisesC.ClassSQLtoC dbSQL;
        private const string GitHubUsername = "EMSMoreno";
        private Dictionary<string, ClassCountry> countryLookup = new Dictionary<string, ClassCountry>();


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

                        // Corrigir campos adicionais
                        country.Continent = country.Region; // Passar a região como continente, se aplicável
                        country.FlagDescription = country.Flags?.Alt; // Passar a descrição da bandeira

                        // Verificar se Timezones é nulo e inicializar se necessário
                        if (country.Timezones == null)
                        {
                            country.Timezones = new List<string>();
                        }

                        // Verificar se Translations é nulo e inicializar se necessário
                        if (country.Translations == null)
                        {
                            country.Translations = new Dictionary<string, ClassCountryTranslation>();
                        }

                        // Adiciona as traduções se existirem
                        var translationsObject = item["translations"];
                        if (translationsObject != null)
                        {
                            foreach (var translation in translationsObject.Children<JProperty>())
                            {
                                var languageCode = translation.Name; // Nome da propriedade é o código do idioma
                                var translationObject = translation.Value.ToObject<ClassCountryTranslation>();
                                country.Translations[languageCode] = translationObject;
                            }
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
                    MessageBox.Show($"Número de países carregados: {countries.Count}");
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

        private void listBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCountries.SelectedItem != null)
            {
                // Encontra o país correspondente pelo nome comum
                var selectedCountryName = listBoxCountries.SelectedItem.ToString();
                var selectedCountry = countries.FirstOrDefault(c => c.Name.Common == selectedCountryName);

                if (selectedCountry != null)
                {
                    UpdateCountryDetails(selectedCountry);
                }
            }
        }

        private void DisplayCountries()
        {
            if (countries == null || countries.Count == 0)
            {
                listBoxCountries.DataSource = null;
                listBoxCountries.Items.Clear(); // Limpa os itens da lista
                return;
            }

            // Cria uma lista de nomes de países
            var countryNames = countries.Select(c => c.Name.Common).ToList();

            // Adiciona logs para depuração
            Debug.WriteLine($"Number of countries: {countries.Count}");
            foreach (var country in countries)
            {
                Debug.WriteLine($"Country: {country.Name.Common}, Official: {country.Name.Official}");
            }

            // Associa a lista de nomes ao DataSource do ListBox
            listBoxCountries.DataSource = countryNames;
        }

        #region Funções Extra

        //Funcionalidade Dark Mode
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
        } 

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            InitializeUI("UIMode");
        } // btn Dark Mode

        private void btnCleanCountry_Click(object sender, EventArgs e)
        {
            txtSearchCountry.Text = string.Empty;
        } // btn Limpar país procurado

        //Github
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

        private void btnGithub_Click(object sender, EventArgs e)
        {
            ShowGithub(GitHubUsername);
        } // btn abrir Github

        //Função para traduzir Japonês
        private void ShowTranslationPopup(ClassCountry country, string languageCode)
        {
            if (country.Translations != null && country.Translations.ContainsKey(languageCode))
            {
                var translation = country.Translations[languageCode];
                string translatedName = translation.Common;
                string message = $"Translated Name to Japanese: {translatedName}";
                MessageBox.Show(message, "Country Name Translation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Translation not available for this Country!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnJapanese_Click(object sender, EventArgs e)
        {
            if (listBoxCountries.SelectedItem != null)
            {
                var selectedCountryName = listBoxCountries.SelectedItem.ToString();
                var selectedCountry = countries.FirstOrDefault(c => c.Name.Common == selectedCountryName);

                if (selectedCountry != null)
                {
                    ShowTranslationPopup(selectedCountry, "jpn");
                }
                else
                {
                    MessageBox.Show("Selected a valid Country!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Select a Country first!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } //btn Japonês

        private void SortCountriesByNameAZ() // Ordenar Países A -> Z
        {
            if (countries != null && countries.Count > 0)
            {
                countries = countries.OrderBy(c => c.Name.Common).ToList();
                DisplayCountries(); // Atualiza a exibição após a ordenação
            }
        }

        private void SortCountriesByNameZA() // Ordenar Países Z -> A
        {
            if (countries != null && countries.Count > 0)
            {
                countries = countries.OrderByDescending(c => c.Name.Common).ToList();
                DisplayCountries();// Atualiza a exibição após a ordenação
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
