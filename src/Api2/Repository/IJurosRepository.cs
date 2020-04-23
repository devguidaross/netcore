using System.Threading.Tasks;

namespace Api2.Repository
{
    public interface IJurosRepository
    {
        Task<string> CalculaJuros(double valorInicial, int meses);
    }
}
