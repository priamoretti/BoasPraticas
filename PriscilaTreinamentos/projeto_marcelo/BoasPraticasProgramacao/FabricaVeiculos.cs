using System;

namespace BoasPraticasProgramacao
{
    public class FabricaVeiculos
    {
        public IVeiculo criaVeiculo(string tipoVeiculo)
        {
            if (tipoVeiculo.Equals("empresaA"))
            {
                return new OnibusEmpresaA();
            }
            else if (tipoVeiculo.Equals("empresaB"))
            {
                return new OnibusEmpresaB();
            }
            throw new Exception("veiculo desconhecido");

        }
    }


}
