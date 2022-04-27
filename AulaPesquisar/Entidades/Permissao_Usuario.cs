using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaPesquisar.Entidades
{
    public class Permissao_Usuario
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PermissaoId { get; set; }
        public Permissao Permissao { get; set; }
        public Usuarios Usuario { get; set; }
    }
}
