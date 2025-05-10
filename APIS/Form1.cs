using System;
using System.IO;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIS
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private string? _lastDogUrl; // URL del perro aleatorio
        private string? _lastCountry; // Pa�s aleatorio

        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonRandomDog_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await _httpClient.GetStringAsync("https://dog.ceo/api/breeds/image/random");
                var json = Newtonsoft.Json.Linq.JObject.Parse(response); // Uso expl�cito del tipo completo
                _lastDogUrl = json["message"]?.ToString(); // Obtener la URL del perro
                pictureBoxDog.ImageLocation = _lastDogUrl; // Mostrar la imagen en el PictureBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener perro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonRandomCountry_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await _httpClient.GetStringAsync("https://restcountries.com/v3.1/all");
                var countries = Newtonsoft.Json.Linq.JArray.Parse(response); // Uso expl�cito del tipo completo
                var random = new Random();
                var country = countries[random.Next(countries.Count)] as Newtonsoft.Json.Linq.JObject; // Obtener un pa�s aleatorio

                if (country != null)
                {
                    _lastCountry = country["name"]?["common"]?.ToString(); // Obtener el nombre del pa�s
                    labelCountry.Text = "Pa�s: " + _lastCountry; // Mostrar el pa�s en el Label
                }
                else
                {
                    MessageBox.Show("Error al procesar los datos del pa�s.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener pa�s: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxDog.ImageLocation = null; // Limpiar la imagen
            labelCountry.Text = string.Empty; // Limpiar el texto del pa�s
            _lastDogUrl = null;
            _lastCountry = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_lastDogUrl) && string.IsNullOrEmpty(_lastCountry))
            {
                MessageBox.Show("No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "JSON (*.json)|*.json|Texto (*.txt)|*.txt";
                dlg.DefaultExt = "json";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var content = string.Empty;

                        if (dlg.FilterIndex == 1) // Guardar como JSON
                        {
                            var obj = new Newtonsoft.Json.Linq.JObject
                            {
                                { "dog_url", _lastDogUrl },
                                { "country", _lastCountry }
                            };
                            content = obj.ToString();
                        }
                        else if (dlg.FilterIndex == 2) // Guardar como TXT
                        {
                            content = $"Perro: {_lastDogUrl}\nPa�s: {_lastCountry}";
                        }

                        File.WriteAllText(dlg.FileName, content);
                        MessageBox.Show("Datos guardados en " + dlg.FileName, "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
