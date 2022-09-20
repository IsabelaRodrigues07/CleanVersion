//instalei o entity pra usar o dbcontext
using Microsoft.EntityFrameworkCore;

namespace AtacadistaCrud1App.Models.ContextoDb
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        // gerencia o banco
        public DbSet<Produto> Produto { get; set; }
    }
}
