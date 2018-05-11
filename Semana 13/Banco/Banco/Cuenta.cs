using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cuenta
    {
        public int usuario;
        public double saldo;
        public string observaciones;
        public TipoCuenta tipoCuenta;

        public Cuenta(int usuario,double saldo,string observaciones, TipoCuenta tipoCuenta)
        {
            this.usuario = usuario;
            this.saldo = saldo;
            this.observaciones = observaciones;
            this.tipoCuenta = tipoCuenta;
        }

        public double Deposito(float monto)
        {
            this.saldo = this.saldo + monto;
            return this.saldo;
        }

        public double Retiro(float monto)
        {
            this.saldo = this.saldo - monto;
            return this.saldo;
        }

        public string Impresion()
        {
            string datos=String.Empty;
            datos += "************************************************";
            datos += "El usuario es " + this.usuario;
            datos += "El saldo es " + this.saldo;
            datos += "La cuenta es " + this.tipoCuenta;
            datos += "------------------------------------------------";
            return datos;
        }
    }
}
