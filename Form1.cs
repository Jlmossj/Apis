using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace APIExplorer
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Listo para buscar";
            picPokemon.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
private async Task GetPokemonDataAsync(string pokemonName)
{
    try
    {
        lblStatus.Text = "Buscando Pokémon...";
        Cursor = Cursors.WaitCursor;

        // Limpiar resultados anteriores
        ClearPokemonData();

        // Hacer la petición a la API
        var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{pokemonName.ToLower()}");
        
        if (!response.IsSuccessStatusCode)
        {
            lblStatus.Text = "Pokémon no encontrado";
            return;
        }

        var content = await response.Content.ReadAsStringAsync();
        dynamic pokemonData = JsonConvert.DeserializeObject(content);

        // Mostrar datos básicos
        lblName.Text = pokemonData.name.ToString().ToUpper();
        lblHeight.Text = $"Altura: {pokemonData.height} decímetros";
        lblWeight.Text = $"Peso: {pokemonData.weight} hectogramos";

        // Mostrar imagen
        var imageUrl = pokemonData.sprites.front_default.ToString();
        var imageResponse = await _httpClient.GetAsync(imageUrl);
        var imageBytes = await imageResponse.Content.ReadAsByteArrayAsync();
        
        using (var ms = new MemoryStream(imageBytes))
        {
            picPokemon.Image = Image.FromStream(ms);
        }

        // Mostrar tipos
        lblTypes.Text = "Tipos: ";
        foreach (var type in pokemonData.types)
        {
            lblTypes.Text += type.type.name.ToString() + " ";
        }

        lblStatus.Text = "Pokémon encontrado!";
    }
    catch (Exception ex)
    {
        lblStatus.Text = $"Error: {ex.Message}";
    }
    finally
    {
        Cursor = Cursors.Default;
    }
}

private void ClearPokemonData()
{
    lblName.Text = "";
    lblHeight.Text = "";
    lblWeight.Text = "";
    lblTypes.Text = "";
    picPokemon.Image = null;
}
private async Task GetWeatherDataAsync(string city)
{
    try
    {
        lblStatus.Text = "Buscando clima...";
        Cursor = Cursors.WaitCursor;
        ClearWeatherData();

        // Reemplaza "TU_API_KEY" con tu clave real de OpenWeatherMap
        var response = await _httpClient.GetAsync(
            $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=TU_API_KEY&units=metric&lang=es");
        
        if (!response.IsSuccessStatusCode)
        {
            lblStatus.Text = "Ciudad no encontrada";
            return;
        }

        var content = await response.Content.ReadAsStringAsync();
        dynamic weatherData = JsonConvert.DeserializeObject(content);

        // Mostrar datos del clima
        lblCity.Text = weatherData.name.ToString();
        lblTemp.Text = $"Temperatura: {weatherData.main.temp}°C";
        lblFeelsLike.Text = $"Sensación: {weatherData.main.feels_like}°C";
        lblHumidity.Text = $"Humedad: {weatherData.main.humidity}%";
        lblWeather.Text = $"Clima: {weatherData.weather[0].description}";

        // Mostrar icono del clima
        var iconCode = weatherData.weather[0].icon.ToString();
        var iconUrl = $"http://openweathermap.org/img/wn/{iconCode}@2x.png";
        var iconResponse = await _httpClient.GetAsync(iconUrl);
        var iconBytes = await iconResponse.Content.ReadAsByteArrayAsync();
        
        using (var ms = new MemoryStream(iconBytes))
        {
            picWeatherIcon.Image = Image.FromStream(ms);
        }

        lblStatus.Text = "Datos del clima obtenidos!";
    }
    catch (Exception ex)
    {
        lblStatus.Text = $"Error: {ex.Message}";
    }
    finally
    {
        Cursor = Cursors.Default;
    }
}

private void ClearWeatherData()
{
    lblCity.Text = "";
    lblTemp.Text = "";
    lblFeelsLike.Text = "";
    lblHumidity.Text = "";
    lblWeather.Text = "";
    picWeatherIcon.Image = null;
}
private async void btnSearchPokemon_Click(object sender, EventArgs e)
{
    if (!string.IsNullOrWhiteSpace(txtPokemon.Text))
    {
        await GetPokemonDataAsync(txtPokemon.Text);
    }
    else
    {
        MessageBox.Show("Ingresa un nombre de Pokémon");
    }
}

private async void btnSearchWeather_Click(object sender, EventArgs e)
{
    if (!string.IsNullOrWhiteSpace(txtCity.Text))
    {
        await GetWeatherDataAsync(txtCity.Text);
    }
    else
    {
        MessageBox.Show("Ingresa una ciudad");
    }
}

private void btnClear_Click(object sender, EventArgs e)
{
    txtPokemon.Text = "";
    txtCity.Text = "";
    ClearPokemonData();
    ClearWeatherData();
    lblStatus.Text = "Búsqueda limpiada";
}

private async void btnSave_Click(object sender, EventArgs e)
{
    try
    {
        var data = new
        {
            Pokemon = new
            {
                Name = lblName.Text,
                Height = lblHeight.Text,
                Weight = lblWeight.Text,
                Types = lblTypes.Text
            },
            Weather = new
            {
                City = lblCity.Text,
                Temperature = lblTemp.Text,
                FeelsLike = lblFeelsLike.Text,
                Humidity = lblHumidity.Text,
                Description = lblWeather.Text
            },
            Date = DateTime.Now
        };

        var json = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText("api_data.json", json);
        
        lblStatus.Text = "Datos guardados en api_data.json";
    }
    catch (Exception ex)
    {
        lblStatus.Text = $"Error al guardar: {ex.Message}";
    }
}
