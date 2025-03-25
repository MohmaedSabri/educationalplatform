using System;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace models.PaymentServices;

public class PaymobPaymentService : IPaymentService
{
    public Task<string> CreateOrder(string paymentToken, Guid courseId)
    {
        HttpClient client = new HttpClient();
        var payload = new {
            auth_token = paymentToken,
            delivery_needed = "false",
            amount_cents = 10000,
            currency = "EGP",
            items = new[] {
                new {
                    name = "Course",
                    quantity = 1,
                    amount_cents = 10000
                }
            },
        };
        var response = client.PostAsJsonAsync("https://accept.paymob.com/api/ecommerce/orders", payload).Result.Content.ReadAsStringAsync();
        var order = response.Result.ToString();
        return Task.FromResult(order);
    }

    public async Task<string> GetPaymentToken()
    {
        HttpClient client = new HttpClient();
        var payload = new {api_key = "ZXlKaGJHY2lPaUpJVXpVeE1pSXNJblI1Y0NJNklrcFhWQ0o5LmV5SmpiR0Z6Y3lJNklrMWxjbU5vWVc1MElpd2ljSEp2Wm1sc1pWOXdheUk2TVRBeU1USTBPQ3dpYm1GdFpTSTZJbWx1YVhScFlXd2lmUS5EQlVEcnM2cHUya3Z6NGhjSDFmaElsNzNuNDZ6V1pIU05oLXpWY2VWb25MeXZzY1hKbU9zQVhYS2tJSFh2ODhOWW8yVTBabE1RTFFTLWRON3ZWTnppQQ=="};
        var response = client.PostAsJsonAsync("https://accept.paymob.com/api/auth/tokens", payload).Result.Content.ReadAsStringAsync();
        var token = response.Result.ToString();
        return token;
    }


    
}
