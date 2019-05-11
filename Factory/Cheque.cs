using System;

namespace Objeto
{
    class Cheque
    {
        public int BancoNumero { get; set; }

        public int ChequeNumero { get; set; }

        public string CpfCnpj { get; set; }

        public DateTime BomPara { get; set; }

        public decimal Valor { get; set; }
    }
}
