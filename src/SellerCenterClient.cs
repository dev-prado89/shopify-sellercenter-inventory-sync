public class SellerCenterClient
{
    private readonly HttpClient _httpClient;

    public SellerCenterClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task UpdateInventoryAsync(string payload)
    {
        var content = new StringContent(payload);

        var response = await _httpClient.PostAsync("https://api.sellercenter.com/update-stock", content);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Error updating SellerCenter inventory");
        }
    }
}
