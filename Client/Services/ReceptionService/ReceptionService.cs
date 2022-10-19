using Microsoft.AspNetCore.Components;
using MudSpeRece.Shared;
using System.Net.Http.Json;

namespace MudSpeRece.Client.Services.ReceptionService
{
    public class ReceptionService : IReceptionService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public ReceptionService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<Reception> Receptions { get; set; } = new List<Reception>();



        public async Task GetReceptions()
        {
            var result = await _http.GetFromJsonAsync<List<Reception>>("api/reception");
            if (result != null)
                Receptions = result;
        }

        public async Task CreateReception(Reception reception)
        {
            var result = await _http.PostAsJsonAsync("api/reception", reception);
            await SetReceptions(result);
        }

        public async Task UpdateReception(Reception reception)
        {
            var result = await _http.PutAsJsonAsync($"api/reception/{reception.Id}", reception);
            await SetReceptions(result);
        }

        public async Task DeleteReception(int id)
        {
            var result = await _http.DeleteAsync($"api/reception/{id}");
            await SetReceptions(result);
        }
        private async Task SetReceptions(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Reception>>();
            Receptions = response;
            _navigationManager.NavigateTo("/");
        }
        // データ詳細取得
        public async Task<Reception> GetSingleReception(int id)
        {
            var result = await _http.GetFromJsonAsync<Reception>($"api/reception/{id}");
            if (result != null)
                return result;
            throw new Exception("Reception not found!");
        }
    }
}
