public class ShopifyClient
{
    private readonly HttpClient _httpClient;

    public ShopifyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetInventoryAsync()
    {
        // Placeholder example
        var response = await _httpClient.GetAsync("https://api.shopify.com/inventory");

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Error retrieving Shopify inventory");
        }

        return await response.Content.ReadAsStringAsync();
    }
}
