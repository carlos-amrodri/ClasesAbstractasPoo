using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentasBancarias
{
    public abstract class ICuenta
    {
        protected Cuenta cuenta;
        protected string head = "El saldo de su cuenta es: $";

        protected ICuenta(Cuenta cuenta)
        {
            this.cuenta = cuenta;
        }

        public abstract string deposito(int valor);
        public abstract string retiro(int valor);
        public abstract string getSaldo();

        public abstract Cuenta getCuenta();
        public abstract void updateCuenta(Cuenta cuen);
    }
}
