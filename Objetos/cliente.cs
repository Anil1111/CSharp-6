using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaSeg
{
    class cliente
    {
        private int codigo;
        private string nome, end, cidade;
        private string cep, tell, uf;
        private string email, obs;


        public cliente()
        {
        }

        public cliente(string nome)
        {
            this.nome = nome;
        }

        
        public cliente(int codigo)
        {
            this.codigo = codigo;
        }


       
        public cliente(int codigo,  string nome, string end, string cidade, string cep, string tell, string uf, string email, string obs)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.end = end;
            this.cidade = cidade;
            this.cep = cep;
            this.tell = tell;
            this.uf = uf;
            
            
            this.email = email;
            this.obs = obs;

        }

       
        public cliente( string nome, string end, string cidade, string cep, string tell, string uf, string email, string obs)
        {
            
            this.nome = nome;
            this.end = end;
            this.cidade = cidade;
            this.cep = cep;
            this.tell = tell;
            this.uf = uf;
            
            this.email = email;
            this.obs = obs;

        }




        public int getCodigo()
        {
            return codigo;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getEnd()
        {
            return end;
        }

        public void setEnd(string end)
        {
            this.end = end;
        }

        public string getCidade()
        {
            return cidade;
        }

        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string getCep()
        {
            return cep;
        }

        public void setCep(string cep)
        {
            this.cep = cep;
        }

        public string getTell()
        {
            return tell;
        }

        public void setTell(string tell)
        {
            this.tell = tell;
        }

        public string getUf()
        {
            return uf;
        }

        public void setUf(string uf)
        {
            this.uf = uf;
        }




        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getObs()
        {
            return obs;
        }

        public void setObs(string obs)
        {
            this.obs = obs;
        }





    }
}
