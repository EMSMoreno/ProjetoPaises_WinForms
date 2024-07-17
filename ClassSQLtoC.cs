using ProjetoPaises_WinForms;
using ProjetoPaisesC;
using System.Collections.Generic;
using System.Data.SQLite;

namespace ProjetoPaisesC_
{
    public class ClassSQLtoC
    {
        private string connectionString;

        public ClassSQLtoC(string connectionString)
        {
            this.connectionString = connectionString;

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Countries (
                        CommonName TEXT,
                        OfficialName TEXT,
                        CurrencyName TEXT,
                        CurrencySymbol TEXT,
                        Capital TEXT,
                        Region TEXT,
                        Subregion TEXT,
                        Population INTEGER,
                        Gini REAL,
                        FlagPng TEXT,
                        Timezone TEXT,
                        Continent TEXT,
                        FlagDescription TEXT
                    );";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SaveCountries(List<ClassCountry> countries)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                foreach (var country in countries)
                {
                    if (string.IsNullOrEmpty(country.CommonName) || string.IsNullOrEmpty(country.OfficialName))
                    {
                        continue; // Evitar inserção de dados incompletos
                    }

                    string insertQuery = @"
                    INSERT INTO Countries (CommonName, OfficialName, CurrencyName, CurrencySymbol, Capital, Region, Subregion, Population, Gini, FlagPng, Timezone, Continent, FlagDescription)
                    VALUES (@CommonName, @OfficialName, @CurrencyName, @CurrencySymbol, @Capital, @Region, @Subregion, @Population, @Gini, @FlagPng, @Timezone, @Continent, @FlagDescription)";

                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CommonName", country.CommonName);
                        command.Parameters.AddWithValue("@OfficialName", country.OfficialName);
                        command.Parameters.AddWithValue("@CurrencyName", country.Currencies?.Values.FirstOrDefault()?.Name ?? "");
                        command.Parameters.AddWithValue("@CurrencySymbol", country.Currencies?.Values.FirstOrDefault()?.Symbol ?? "");
                        command.Parameters.AddWithValue("@Capital", country.Capital != null && country.Capital.Count > 0 ? country.Capital[0] : "");
                        command.Parameters.AddWithValue("@Region", country.Region);
                        command.Parameters.AddWithValue("@Subregion", country.Subregion);
                        command.Parameters.AddWithValue("@Population", country.Population);

                        if (country.Gini != null && country.Gini.GiniValue.HasValue)
                        {
                            command.Parameters.AddWithValue("@Gini", country.Gini.GiniValue.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Gini", DBNull.Value);
                        }

                        command.Parameters.AddWithValue("@FlagPng", country.Flags?.Png ?? "");
                        command.Parameters.AddWithValue("@Timezone", string.Join(",", country.Timezones));
                        command.Parameters.AddWithValue("@Continent", country.Continent);
                        command.Parameters.AddWithValue("@FlagDescription", country.FlagDescription);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public List<ClassCountry> GetCountries()
        {
            var countries = new List<ClassCountry>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Countries";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var country = new ClassCountry
                            {
                                CommonName = reader["CommonName"].ToString(),
                                OfficialName = reader["OfficialName"].ToString(),
                                Currencies = new Dictionary<string, ClassCountryCurrency>
                        {
                            {
                                "default", new ClassCountryCurrency
                                {
                                    Name = reader["CurrencyName"].ToString(),
                                    Symbol = reader["CurrencySymbol"].ToString()
                                }
                            }
                        },
                                Capital = new List<string> { reader["Capital"].ToString() },
                                Region = reader["Region"].ToString(),
                                Subregion = reader["Subregion"].ToString(),
                                Population = Convert.ToInt64(reader["Population"]),
                                Gini = new ClassCountryGini
                                {
                                    GiniValue = reader["Gini"] != DBNull.Value ? Convert.ToSingle(reader["Gini"]) : (float?)null
                                },
                                Flags = new ClassCountryFlags
                                {
                                    Png = reader["FlagPng"].ToString()
                                },
                                Timezones = reader["Timezone"].ToString().Split(',').ToList(),
                                Continent = reader["Continent"].ToString(),
                                FlagDescription = reader["FlagDescription"].ToString(),
                                Translations = new Dictionary<string, ClassCountryTranslation>()
                            };

                            countries.Add(country);
                        }
                    }
                }
            }

            return countries;
        }

    }
}