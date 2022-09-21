using System;

namespace BoasPraticasProgramacao
{
    class PinPadService
    {

        public void salvarPinPad(Pinpad pinPad)
        {
            try
            {
                this.processaSalvarPinPad(pinPad);
            }
            catch (Exception)
            {
                // tratar o erro aqui.
            }
        }

        private void processaSalvarPinPad(Pinpad pinpad)
        {
            // realiza processamento para salvar o pinpad
        }


        public Pinpad buscaPinPad(int id)
        {
            Pinpad pinpad = null; // busca o PinPad em algum ponto do sistema
            if (pinpad == null)
            {
                pinpad = new PinPadNaoEncontrado();
            }
            return pinpad;
        }



    }

}
