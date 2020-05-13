using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentasBancarias
{
    public class Cuenta
    {
        public Cuenta (int numCuent, string nombre, int id)
        {
            this.numeroCuenta = numCuent;
            this.nombreCliente = nombre;
            this.idCliente = id;
            this.saldo = 0;
        }
        public int numeroCuenta { get; set; }
        public string nombreCliente { get; set; }
        public int idCliente { get; set; }
        public int saldo { get; set; }
    }
}
