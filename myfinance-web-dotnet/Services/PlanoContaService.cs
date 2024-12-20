using myfinance_web_dotnet.Domain;
using myfinance_web_dotnet.Infrastructure;

namespace myfinance_web_dotnet.Services
{
    public class PlanoContaService : IPlanoContaService
    {
        private MyFinanceDBContext _myFinanceDbContext;
        
        public PlanoContaService(MyFinanceDBContext myFinanceDbContext)
        {
            _myFinanceDbContext = myFinanceDbContext;
        }
        public void Excluir(int id)
        {
            var item = RetornarRegistro(id);
            _myFinanceDbContext.Attach(item);
            _myFinanceDbContext.Remove(item);
            _myFinanceDbContext.SaveChanges();
        }

        public List<PlanoContas> ListarRegistros()
        {
            var lista = _myFinanceDbContext.PlanoContas.ToList();
            return lista;
        }

        public PlanoContas RetornarRegistro(int id)
        {
            var item = _myFinanceDbContext.PlanoContas.Where(x  => x.Id == id).First();
            return item;
        }

        public void Salvar(PlanoContas item)
        {
            var dbSet = _myFinanceDbContext.PlanoContas;
            if (item.Id == null)
                dbSet.Add(item);
            else
            {
                dbSet.Attach(item);
                _myFinanceDbContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _myFinanceDbContext.SaveChanges();
        }
    }
}