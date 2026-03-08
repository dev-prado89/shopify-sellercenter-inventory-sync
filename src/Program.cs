class Program
{
    static async Task Main(string[] args)
    {
        var httpClient = new HttpClient();

        var shopify = new ShopifyClient(httpClient);
        var sellerCenter = new SellerCenterClient(httpClient);

        var syncService = new InventorySyncService(shopify, sellerCenter);

        await syncService.SyncAsync();
    }
}
