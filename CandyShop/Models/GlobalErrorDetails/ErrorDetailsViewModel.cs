using Newtonsoft.Json;

namespace CandyShop.Models.GlobalErrorDetails
{
    public class ErrorDetailsViewModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
