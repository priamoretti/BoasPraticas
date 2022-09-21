using System;

namespace BPP_1.aula2
{
    class BilheteValida
    {
        public OkValidacao validar(Bilhete bilhete)
        {

            this.processaValidaca(bilhete);
            return new OkValidacao();

        }

        private void processaValidaca(Bilhete bilhete)
        {
            validaDescricao(bilhete);
            validaPreco(bilhete);
        }

        private void validaDescricao(Bilhete bilhete)
        {
            if (string.IsNullOrEmpty(bilhete.descricao))
            {
                throw new Exception("Descricao nao pode ser null ou vazio");
            }
        }

        private void validaPreco(Bilhete bilhete)
        {
            if (bilhete.preco < 0)
            {
                throw new Exception("Preco não pode ser menor que 0");
            }
        }

    }
}
