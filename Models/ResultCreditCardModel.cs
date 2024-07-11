using System.Collections.Generic;

namespace TesteCielo.Models
{
    public class ResultCreditCardAddress
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }
    }

    public class ResultCreditCardCardOnFile
    {
        public string Usage { get; set; }
        public string Reason { get; set; }
    }

    public class ResultCreditCard
    {
        public string CardNumber { get; set; }
        public string Holder { get; set; }
        public string ExpirationDate { get; set; }
        public bool SaveCard { get; set; }
        public string Brand { get; set; }
        public ResultCreditCardCardOnFile CardOnFile { get; set; }
    }

    public class ResultCreditCardCustomer
    {
        public string Name { get; set; }
        public string Identity { get; set; }
        public string IdentityType { get; set; }
        public string Email { get; set; }
        public string Birthdate { get; set; }
        public ResultCreditCardAddress Address { get; set; }
        public ResultCreditCardDeliveryAddress DeliveryAddress { get; set; }
    }

    public class ResultCreditCardDeliveryAddress
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }
    }

    public class ResultCreditCardLink
    {
        public string Method { get; set; }
        public string Rel { get; set; }
        public string Href { get; set; }
    }

    public class ResultCreditCardPayment
    {
        public int ServiceTaxAmount { get; set; }
        public int Installments { get; set; }
        public int Interest { get; set; }
        public bool Capture { get; set; }
        public bool Authenticate { get; set; }
        public bool Recurrent { get; set; }
        public ResultCreditCard CreditCard { get; set; }
        public string Tid { get; set; }
        public string SoftDescriptor { get; set; }
        public string Provider { get; set; }
        public bool IsQrCode { get; set; }
        public bool DynamicCurrencyConversion { get; set; }
        public int Amount { get; set; }
        public string ReceivedDate { get; set; }
        public int Status { get; set; }
        public bool IsSplitted { get; set; }
        public string ReturnMessage { get; set; }
        public string ReturnCode { get; set; }
        public string PaymentId { get; set; }
        public string Type { get; set; }
        public string Currency { get; set; }
        public string Country { get; set; }
        public List<ResultCreditCardLink> Links { get; set; }
        public object AuthorizationCode { get; internal set; }
    }

    public class ResultCreditCardModel
    {
        public string MerchantOrderId { get; set; }
        public ResultCreditCardCustomer Customer { get; set; }
        public ResultCreditCardPayment Payment { get; set; }
    }
}
