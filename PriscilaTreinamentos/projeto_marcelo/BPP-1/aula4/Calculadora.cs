﻿namespace BPP_1.aula4
{
    class Calculadora
    {
        // Inserir uma implementacao de Log
        public Log log;
        
        public Calculadora(Log log)
        {
            this.log = log;
        }


        public int somar(int a, int b)
        {
            log.log("CHAMANDO SOMA");
            return a + b;
        }

        public int subtrair(int a, int b)
        {
            log.log("CHAMANDO SUBTRAIR");
            return a - b;
        }
    }
}
