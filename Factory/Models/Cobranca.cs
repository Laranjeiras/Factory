using System;

namespace Ltec.Factory.Models
{

    [Serializable]
    public class Cobranca
        {

            public Cobranca()
            {
                GuidCobranca = Guid.NewGuid();
            }

            public int IdCobranca { get; set; }

            public Guid GuidCobranca { get; set; }
    
            public Guid? GuidVenda { get; set; }

            public int IdVenda { get; set; }

            public string Documento { get; set; }

            public DateTime DataVcto { get; set; }

            public decimal Valor { get; set; }

            public DateTime DataPgto { get; set; }

            public decimal ValorPgto { get; set; }

            public int StatusPgto { get; set; }

            public string NossoNumero { get; set; }
        }
}
