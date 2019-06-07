using System;

namespace calculadoradecombustivel.Models
{
    public class CalculoDeCombustivel
    {
        private Decimal _valorPorLitro;
        public Decimal ValorPorLitro
        {
            get { return _valorPorLitro; }
            set { _valorPorLitro = value; }
        }
        private Decimal _valorPago;
        public Decimal ValorPago
        {
            get { return _valorPago; }
            set { _valorPago = value; }
        }
        public Decimal LitrosAbastecidos() 
        {
            Decimal litros = 0;
            if (_valorPago > 0 && _valorPorLitro > 0)
            {
                litros = Decimal.Round( (_valorPago / _valorPorLitro) ,2);
            }
            return litros;
        }
    }
}