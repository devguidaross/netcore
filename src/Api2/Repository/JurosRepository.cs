using System;
using System.Threading.Tasks;
using Api2.Api1;

namespace Api2.Repository
{
    public class JurosRepository : IJurosRepository
    {
#if DEBUG
        private const string BaseUrl = "https://localhost:5001/";
#else
        private const string BaseUrl = "http://taxajurosapi/";  
#endif

        private void ValidarArgumentos(double valorInicial, int meses)
        {
            if (valorInicial <= 0)
            {
                throw new ArgumentException("Valor inicial deve ser maior que zero");
            }

            if (meses < 1)
            {
                throw new ArgumentException("Meses deve ser maior ou igual à 1");
            }
        }

        public async Task<string> CalculaJuros(double valorInicial, int meses)
        {
            ValidarArgumentos(valorInicial, meses);
            var taxaJuros = (await TaxaJuros()) / 100;
            var calculoJuros = valorInicial * Math.Pow(taxaJuros + 1, meses);
            return $"{Math.Truncate(calculoJuros * 10) / 10:0.00}";
        }

        private async Task<double> TaxaJuros()
        {
            try
            {
                var api1Client = new Api1Client(BaseUrl);
                return await api1Client.TaxaJurosAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(
                    $"Conexão com {BaseUrl} falhou");
            }
        }

    }
}
