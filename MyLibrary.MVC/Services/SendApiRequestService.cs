using Microsoft.AspNetCore.Mvc;

namespace MyLibrary.MVC.Services;

public class SendApiRequestService :ISendApiRequestService
{
    private Uri baseAdressBookApi = new Uri("https://localhost:7052/api");
    private readonly HttpClient _httpClient;

    public SendApiRequestService()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = baseAdressBookApi;
    }
    
    public string SendApiRequest(string actionName)
    {
        string result = "";
        Task<HttpResponseMessage> response =
            _httpClient.GetAsync(_httpClient.BaseAddress + "/book/" + actionName);
        if (response.Result.IsSuccessStatusCode)
        { 
             result = response.Result.Content.ReadAsStringAsync().Result;
        }
        
        return result;
    }
}