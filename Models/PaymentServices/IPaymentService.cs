using System;

namespace models.PaymentServices;

public interface IPaymentService
{
    public Task<string> GetPaymentToken();

    public Task<string> CreateOrder(string paymentToken, Guid courseId);
}
