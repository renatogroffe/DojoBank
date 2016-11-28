using DojoBank.ApiRest.Models;
using System.Web.Http;

namespace DojoBank.ApiRest.Controllers
{
    public class JurosCompostosController : ApiController
    {
        // GET api/values/5
        public CalculoJuros GetCalcular(double valor, int meses, double taxa)
        =>
            new CalculoJuros(valor, meses, taxa);
    }
}