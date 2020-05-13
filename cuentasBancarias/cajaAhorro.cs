using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentasBancarias
{
    //Esta es la implementaci{on simple
    public class cajaAhorro : ICuenta
    {
        

        public cajaAhorro(Cuenta cu) : base(cu) { }


        public override string deposito(int valor)
        {
            this.cuenta.saldo = +valor;
            return this.head + Convert.ToString(this.cuenta.saldo);
        }

        public override string getSaldo()
        {
            return this.head + Convert.ToString(this.cuenta.saldo);
        }

        public override string retiro(int valor)
        {
            if (valor < cuenta.saldo)
            {
                this.cuenta.saldo = -valor;
                return this.head + Convert.ToString(this.cuenta.saldo);
            }
            else
            {
                return "El valor que intenta retirar supera su saldo :(";
            }
        }


        public override Cuenta getCuenta()
        {
            return this.cuenta;
        }

        public override void updateCuenta(Cuenta cuen)
        {
            this.cuenta = cuen;
        }
    }
}
