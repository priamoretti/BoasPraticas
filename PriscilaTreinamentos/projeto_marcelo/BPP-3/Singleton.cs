using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3
{
    public class ConectaBanco
    {

        // construtor
        private ConectaBanco() { }

        public static ConectaBanco instancia;


        public static ConectaBanco GetInstancia()
        {
            if (instancia != null)
            {
                return instancia;

            }
            return new ConectaBanco();
        }


        public void conecta() { }

    }

}
