using System;

namespace BPP_1.aula2
{
    class BilheteServico
    {
        private BilheteValida bilheteValida = new BilheteValida();

        public void venderBilhete(Bilhete bilhete)
        {
            try
            {
                var okValidacao = bilheteValida.validar(bilhete);
                efetuarVenda(bilhete, okValidacao);
                encerrarVenda(bilhete);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
                // mostarr tela para usuario e.Message();
            }
            finally
            {

            }

        }

        public void encerrarVenda(Bilhete bilhete)
        {
            // blalblbllala
        }

        public void efetuarVenda(Bilhete bilhete, OkValidacao okValidacao)
        {
            // blalallbllalala
        }

        public Bilhete buscarBilhete(int id)
        {
            Bilhete bilhete = null;
            // processa a busca do bilhete
            if (bilhete == null)
            {
                bilhete = new BilheteNaoEncontrado();
            }
            return bilhete;

        }

    }
}
