using exPagamento;

Console.WriteLine("Valor pra pagar");
var value = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("tipo de pagamento");
Console.WriteLine("1 - boleto | 2 - credito");
var paymentMethod = Convert.ToDecimal(Console.ReadLine());

if(paymentMethod == 1)
{
    var pay = new SlipPayment();
    pay.PaymentProcess(DateTime.Now, value);
} else if(paymentMethod == 2)
{
    var pay = new CreditCardPayment();
    pay.PaymentProcess(DateTime.Now, value);
}