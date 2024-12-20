using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myfinance_web_dotnet.Domain;

namespace myfinance_web_dotnet.Services
{
    public interface IPlanoContaService
    {
        List<PlanoContas> ListarRegistros();
        
        void Salvar(PlanoContas item);
        
        void Excluir(int id);
        
        PlanoContas RetornarRegistro(int id);
    }
}