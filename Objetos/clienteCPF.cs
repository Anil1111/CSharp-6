using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaSeg
{
    class clienteCPF : cliente
    {

        private string cpf,rg;

        public string getCPF()
        {
            return cpf;
        }

        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }

        public string getRg()
        {
            return rg;
        }

        public void setRg(string rg)
        {
            this.rg = rg;
        }



    }
}
