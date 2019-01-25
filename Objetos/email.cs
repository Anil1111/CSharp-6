
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSoft
{
    class email
    {

     private  string emailc;
     private  string senha;
     private  string smtp;
     private  string assunto;
     private  string msg;



     public void setEmail(string email)
     {
             this.emailc = email;
     }


        public  bool ValidarEmail(string email)
        {
            bool validEmail = false;
            int indexArr = email.IndexOf('@');
            if (indexArr > 0)
            {
                int indexDot = email.IndexOf('.', indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < email.Length)
                    {
                        string indexDot2 = email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            validEmail = true;
                        }
                    }
                }
            }
            return validEmail;
        }


        public string getEmail()
        {
            return emailc;
        }
        public string getSenha()
        {
            return senha;
        }
        public string getSmtp()
        {
            return smtp;
        }
        public string getAssunto()
        {
            return assunto;
        }
        public string getMsg()
        {
            return msg;
        }


        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        public void setSmtp(string smtp)
        {
            this.smtp = smtp;
        }

        public void setAssunto(string assunto)
        {
            this.assunto = assunto;
        }
        public void setMsg(string msg)
        {
            this.msg = msg;
        }




    }
}
