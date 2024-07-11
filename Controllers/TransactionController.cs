using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Linq;
using System.Net;
using TesteCielo.Models;

namespace TesteCieloWeb.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTransaction(CieloCreditCardModel cieloCreditCard)
        {
            var resultCreateTransactionCreditCard = new Dictionary<bool, object>();

            var client = new RestClient("https://apisandbox.cieloecommerce.cielo.com.br/1/sales/");
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("MerchantId", "9a1388e3-68fe-4ad1-85e5-60b8d4766599");
            request.AddHeader("MerchantKey", "EYWONCYWECYTNWAOSDGFHVENUFYKZERAJOGWXZKU");
            request.AddJsonBody(cieloCreditCard);

            // Log JSON being sent
            var jsonBody = JsonConvert.SerializeObject(cieloCreditCard);
            Console.WriteLine("JSON Enviado: " + jsonBody);
            request.AddJsonBody(jsonBody);

            var response = client.Execute(request);

            // Log JSON response
            Console.WriteLine("JSON Recebido: " + response.Content);

            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted || response.StatusCode == HttpStatusCode.Created)
            {
                var objResponse = JsonConvert.DeserializeObject<ResultCreditCardModel>(response.Content);
                resultCreateTransactionCreditCard.Add(true, new { Message = "Transação criada com sucesso.", PaymentId = objResponse.Payment.PaymentId, Status = objResponse.Payment.Status});
                return Ok(resultCreateTransactionCreditCard);
            }
            else
            {
                resultCreateTransactionCreditCard.Add(false, response.Content);
                return BadRequest(resultCreateTransactionCreditCard);
            }
        }

        [HttpPost]
        public IActionResult CaptureTransaction(ResultCreditCardModel ResultCreditCardPayment)
        {
            var resultCaptureTransactionCreditCard = new Dictionary<bool, string>();
            var urlCompleta = "https://apisandbox.cieloecommerce.cielo.com.br/1/sales/" + ResultCreditCardPayment.Payment.PaymentId + "/capture";
            Console.WriteLine("urlCompleta : " + urlCompleta);

            var client = new RestClient(urlCompleta);
            
            var request = new RestRequest();
            request.Method = Method.Put;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("MerchantId", "9a1388e3-68fe-4ad1-85e5-60b8d4766599");
            request.AddHeader("MerchantKey", "EYWONCYWECYTNWAOSDGFHVENUFYKZERAJOGWXZKU");
            request.AddJsonBody(ResultCreditCardPayment);

            // Log JSON being sent
            var jsonBody = JsonConvert.SerializeObject(ResultCreditCardPayment);
            Console.WriteLine("JSON Enviado: " + jsonBody);
            request.AddJsonBody(jsonBody);

            var response = client.Execute(request);

            // Log JSON response
            Console.WriteLine("JSON Recebido: " + response.Content);

            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted || response.StatusCode == HttpStatusCode.Created)
            {
                var objResponse = JsonConvert.DeserializeObject<ResultCreditCardModel>(response.Content);
                resultCaptureTransactionCreditCard.Add(true, "Transacao Captura com sucesso");
                // Passa os dados para a view usando ViewBag
                return Ok(resultCaptureTransactionCreditCard);
            }
            else
            {
                resultCaptureTransactionCreditCard.Add(false, response.Content);
                return BadRequest(resultCaptureTransactionCreditCard);
            }
        }

        [HttpPost]
        public IActionResult CancelTransaction(ResultCreditCardModel ResultCreditCardPayment)
        {
            var resultCancelTransactionCreditCard = new Dictionary<bool, string>();
            var urlCompleta = "https://apisandbox.cieloecommerce.cielo.com.br/1/sales/" + ResultCreditCardPayment.Payment.PaymentId + "/void/";
            Console.WriteLine("urlCompleta : " + urlCompleta);

            var client = new RestClient(urlCompleta);
            
            var request = new RestRequest();
            request.Method = Method.Put;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("MerchantId", "9a1388e3-68fe-4ad1-85e5-60b8d4766599");
            request.AddHeader("MerchantKey", "EYWONCYWECYTNWAOSDGFHVENUFYKZERAJOGWXZKU");
            request.AddJsonBody(ResultCreditCardPayment);

            // Log JSON being sent
            var jsonBody = JsonConvert.SerializeObject(ResultCreditCardPayment);
            Console.WriteLine("JSON Enviado: " + jsonBody);
            request.AddJsonBody(jsonBody);

            var response = client.Execute(request);

            // Log JSON response
            Console.WriteLine("JSON Recebido: " + response.Content);

            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted || response.StatusCode == HttpStatusCode.Created)
            {
                var objResponse = JsonConvert.DeserializeObject<ResultCreditCardModel>(response.Content);
                resultCancelTransactionCreditCard.Add(true, "Transacao Cancelada com sucesso");
                // Passa os dados para a view usando ViewBag
                return Ok(resultCancelTransactionCreditCard);
            }
            else
            {
                resultCancelTransactionCreditCard.Add(false, response.Content);
                return BadRequest(resultCancelTransactionCreditCard);
            }
        }
    }
}
