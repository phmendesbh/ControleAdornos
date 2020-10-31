using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ControleAdornos.Entidades
{
    public class Palavra
    {
        public int? Id { get; set; }
        public string Descricao { get; set; }
        public Cor Cor { get; set; }
        public int Material_Id { get; protected set; }
        public string DescricaoAntiga { get; set; }

        public Palavra()
        {
            Material_Id = 1;
        }
    }
}
