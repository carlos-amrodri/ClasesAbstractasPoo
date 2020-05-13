using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuentasBancarias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string mostrar;
        List<ICuenta> listadoCuentas = new List<ICuenta>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Cuenta c1 = new Cuenta(123, "Juan", 12);
            Cuenta c2 = new Cuenta(456, "pedro", 45);

            ICuenta cajaAh = new cajaAhorro(c1);
            listadoCuentas.Add(cajaAh);
            cajaGold gold = new cajaGold(c2);
            listadoCuentas.Add(gold);

            mostrar = cajaAh.deposito(1200);
            MessageBox.Show(mostrar);
            mostrar = cajaAh.retiro(1500);
            MessageBox.Show(mostrar);


            MessageBox.Show(gold.deposito(5000));

            MessageBox.Show(gold.depositoDolar(1000));

            MessageBox.Show(gold.getSaldoTotal(65));

            
            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cantidad = listadoCuentas.Count;
            MessageBox.Show("Tengo :" + cantidad + " cuentas");
            foreach(ICuenta cu in listadoCuentas)
            {

                var c = cu.getCuenta();
                MessageBox.Show("El Numero de la cuenta es:" + c.numeroCuenta + " el cliente es: " + c.nombreCliente);
            }

        }
    }
}
