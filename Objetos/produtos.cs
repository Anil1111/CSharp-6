using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSoft
{
    class produtos
    {
        int codProduto;
        string codBarras, obs;
        float valorCusto, valorVenda;
        int quantia;
        string data,descricao;


        public produtos()
        {

        }



        public produtos(int codProduto, int quantia, string codBarras, string obs, string data, string descricao, float valorCusto, float valorVenda)
        {
            this.codProduto = codProduto;
            this.quantia = quantia;
            this.codBarras = codBarras;
            this.obs = obs;
            this.data = data;
            this.descricao = descricao;
            this.valorCusto = valorCusto;
            this.valorVenda = valorVenda;

        }

        public produtos(int quantia, string codBarras, string obs, string data, string descricao, float valorCusto, float valorVenda)
        {
           
            this.quantia = quantia;
            this.codBarras = codBarras;
            this.obs = obs;
            this.data = data;
            this.descricao = descricao;
            this.valorCusto = valorCusto;
            this.valorVenda = valorVenda;

        }


        public int getCodigoP()
        {
            return codProduto;
        }

        public void setCodigoP(int codProduto)
        {
            this.codProduto = codProduto;
        }

        public string getCodigoBarras()
        {
            return codBarras;
        }

        public void setCodigoBarras(string codBarras)
        {
            this.codBarras = codBarras;
        }
        public string getObs()
        {
            return obs;
        }

        public void setObs(string obs)
        {
            this.obs = obs;
        }

        public string getData()
        {
            return data;
        }

        public void setData(string data)
        {
            this.data = data;
        }

        public string getDescricao()
        {
            return descricao;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public float getValorCusto()
        {
            return valorCusto;
        }

        public void setValorCursto(float valorCusto)
        {
            this.valorCusto = valorCusto;
        }


        public float getValorVenda()
        {
            return valorVenda;
        }

        public void setValorVenda(float valorVenda)
        {
            this.valorVenda = valorVenda;
        }


        public int getQuantia()
        {
            return quantia;
        }

        public void setQuantia(int quantia)
        {
            this.quantia = quantia;
        }



    }
}
