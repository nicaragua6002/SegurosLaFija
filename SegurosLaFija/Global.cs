using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosLaFija
{
    public class Global
    {
        public static List<Cliente> Clientes = new List<Cliente>()
        {
            new Cliente(1, "Juan", "Perez","8874554")
            ,new Cliente(2, "Maria", "Lopez","2556974")
            ,new Cliente(3, "Sonia", "Castro Lopez","98452251")
        };
        public class Cliente
        {
            int id;
            string nombre;
            string apellido;
            string numTelf;
            public Cliente(int id, string nombre, string apellido, string numTelf)
            {
                this.Id = id;
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.NumTelf = numTelf;
            }
            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public string NumTelf { get => numTelf; set => numTelf = value; }
        }
    }
}
