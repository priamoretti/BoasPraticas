

namespace TreinamentoLiskov.Log
{
    class Calculadora
    {
        // Inserir uma implementacao de Log
        public Log log { get; set; }

        public Calculadora(Log log) {

            this.log = log;
        }


        public int somar(int primeironumero, int segundonumero)
        {
            log.log("CHAMANDO SOMA " + (primeironumero + segundonumero));
            return primeironumero + segundonumero;
        }

        public int subtrair(int primeironumero, int segundonumero)
        {
            log.log("CHAMANDO SUBTRAIR   " + (primeironumero - segundonumero));
            return primeironumero - segundonumero;
        }
    }
}
