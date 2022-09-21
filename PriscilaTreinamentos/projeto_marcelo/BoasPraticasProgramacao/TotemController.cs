using System.Configuration;

namespace BoasPraticasProgramacao
{
    class TotemController
    {
        Sessao sessao = new Sessao();
        Perifericos perifericos = new Perifericos();
        TotemBusiness totemBusiness = new TotemBusiness();

        //Método de verificação de rotina
        public string VerificarStatus(int configuracao = 0, string porta = "")
        {
            //Debbug para não testar perifericos            
            if (!(bool.TryParse(ConfigurationManager.AppSettings["testaPerifericos"].ToString(), out bool testar) ? testar : true))
                configuracao = int.TryParse(configuracao.ToString().Replace("0", "12").Replace("3", "").Replace("4", ""), out int r) ? r : 2;

            sessao.mensagemErro = string.Empty;

            // 0 - Tudo  / 1 - LTotem / 2 - WS / 3 - PinPad / 4 - Impressora
            if (configuracao <= 0 || configuracao.ToString().Contains("2"))
                if (!TestarWSRodosoft())
                {
                    if (sessao.mensagem?.ToLower().Equals("falha ao  carregar as configurações do totem") ?? false)
                        sessao.mensagemErro += $"{sessao.mensagem}\n";
                    else sessao.mensagemErro += "WS indisponivel!\n";

                    return sessao.mensagemErro;
                }

            if (configuracao <= 0 || configuracao.ToString().Contains("1"))
            {
                //Verifica o LTotem
                int retorno = totemBusiness.RotinaRollback();

                if (retorno == 1)
                    sessao.mensagemErro += "LTotem indisponivel!\n"; //return RedirectToAction("Imprimir", "Voucher");
                else if (retorno == 2)
                    sessao.mensagemErro += "Impressora\n";
                else if (retorno == -1)
                    sessao.mensagemErro += "LTotem indisponivel!  ";
            }


            if (sessao.testaPerifericos && (configuracao <= 0 || configuracao.ToString().Contains("3")) && !sessao.mensagemErro.Contains("WS indisponivel"))
                if (perifericos.StatusPinPad().Contains("Sem Biblioteca de Acesso"))
                    perifericos.IniciaPinpadEx(sessao.configuracao.IpSitef, sessao.configuracao.IdLojaSitef, sessao.configuracao.IdTerminalSitef, 0, "");
                else
                    sessao.mensagemErro += perifericos.StatusPinPad() == "PinPad Iniciado" ? "" : perifericos.StatusPinPad();

            //Obtem Status da impressora
            if (sessao.testaPerifericos && (configuracao <= 0 || configuracao.ToString().Contains("4")))
            {
                string ret = perifericos.ObterStatusImpressoraElgin(string.IsNullOrEmpty(porta) ? sessao.portaImpressora : porta);
                if (!string.IsNullOrEmpty(ret) && (ret.Contains("0") || ret.Contains("3") || ret.Contains("4")))
                    sessao.mensagemErro += ret;
            }

            return sessao.mensagemErro;
        }


        public bool TestarWSRodosoft()
        {
            //var retorno = new JsonResult();
            bool ativo = false;

            try
            {
                //ConfiguracoesWebService cws = new ConfiguracoesWebService();
                //cws.CarregarDataHora(sessao.configuracoes.Chave);

                ativo = true;
                //error = string.Empty
            }
            catch
            {
                ativo = false;
                //error = "WS offline!"
            }

            return ativo;
        }
    }
}
