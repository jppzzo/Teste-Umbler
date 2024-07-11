namespace TesteCielo.Models
{
    public class CieloCreditCardModel
    {
        public string MerchantOrderId { get; set; }
        public CieloCreditCardCustomer Customer { get; set; }
        public CieloCreditCardPayment Payment { get; set; }
    }

    public class CieloCreditCardCustomer
    {
        public string Name { get; set; }
        public string Identity { get; set; }
        public string IdentityType { get; set; }
        public string Email { get; set; }
        public string Birthdate { get; set; }
    }

    public class CieloCreditCardPayment
    {
        public int Amount { get; set; }
        public int ServiceTaxAmount { get; set; } = 0;
        public int Installments { get; set; } = 1;
        public string Interest { get; set; } = "ByMerchant";
        public bool Capture { get; set; } = false;
        public bool Authenticate { get; set; } = false;
        public string Recurrent { get; set; } = "false";
        public string SoftDescriptor { get; set; } = "123456789ABCD";
        public CieloCreditCard CreditCard { get; set; }
        public string Type { get; set; } = "CreditCard";
    }

    public class CieloCreditCard
    {
        public string CardNumber { get; set; }
        public string Holder { get; set; }
        public string ExpirationDate { get; set; } = "12/2026";
        public string SecurityCode { get; set; }
        public string SaveCard { get; set; } = "false";
        public string Brand { get; set; }
        public CieloCreditCardCardOnFile CardOnFile { get; set; } = new CieloCreditCardCardOnFile();
    }

    public class CieloCreditCardCardOnFile
    {
        public string Usage { get; set; } = "Used";
        public string Reason { get; set; } = "Unscheduled";
    }
}