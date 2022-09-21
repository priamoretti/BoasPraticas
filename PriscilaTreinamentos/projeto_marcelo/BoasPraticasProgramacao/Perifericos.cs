namespace BoasPraticasProgramacao
{


    class Perifericos
    {
        Pinpad pinpad = new Pinpad();

        public string StatusPinPad()
        {
            int Retorno = 1;
            if (Retorno != 1)
            {
                if (Retorno == 0)
                {
                    return "Sem PinPad\n";
                }
                if (Retorno == -1)
                {
                    return "Sem Biblioteca de Acesso\n";
                }
            }
            return "PinPad Iniciado";
        }

        // Funcoes especificas Pinpad
        public string IniciaPinpadEx(string Servidor, string Loja, string Terminal, int? ConfiguraResultado = 0, string ParamAdicional = "")
        {
            if (pinpad == null) pinpad = new Pinpad();

            int retorno = pinpad.ConfiguraEx(Servidor, Loja, Terminal, 0, ParamAdicional);
            if (retorno == 0)
            {
                return "SITEMA CONECTADO COM WEBTEF";
            }
            else
            {
                return "ERRO DE CONEXÃO";
            }
        }

        public string ObterStatusImpressoraElgin(string value)
        {
            return "";
        }


    }
}
