namespace BoasPraticasProgramacao
{
    class Sessao
    {
        internal string mensagem;

        public string mensagemErro { get; internal set; }
        public bool testaPerifericos { get; internal set; }

        public string portaImpressora { get; internal set; }

        public Configuracao configuracao { get; set; }
    }
}