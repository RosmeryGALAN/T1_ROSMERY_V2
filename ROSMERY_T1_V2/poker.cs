using System;
using System.Collections.Generic;
using System.Text;

namespace ROSMERY_T1_V2
{
    public class poker
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string carta { get; set; }
        public int IdUsuario { get; set; }

        public poker(int id, int numero, string carta, int Id_usuario)
        {
            Id = id;
            Numero = numero;
            this.carta = carta;
            IdUsuario = IdUsuario;
        }
    }
}
