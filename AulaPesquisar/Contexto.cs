using AulaPesquisar.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AulaPesquisar
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt) { }
        public DbSet<Pessoa> PESSOAS { get; set; }

        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<Permissao> permissao { get; set; }
        public DbSet<Permissao_Usuario> permissao_usuario { get; set; }
    }
}
