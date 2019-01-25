using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaSeg
{
    class clienteCNPJ : cliente
    {

        private string cnpj,ie;

        public string getCNPJ()
        {
            return cnpj;
        }

        public void setCNPJ(string cnpj)
        {
            this.cnpj = cnpj;
        }
        public string getIE()
        {
            return ie;
        }

        public void setIE(string IE)
        {
            this.ie = IE;
        }











    }
}
