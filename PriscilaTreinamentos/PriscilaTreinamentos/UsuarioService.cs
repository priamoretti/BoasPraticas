using PriscilaTreinamentos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriscilaTreinamentos
{
	public class UsuarioService
	{

		List<DTO.Usuario> lista = new List<DTO.Usuario>();

		public void salvar(DTO.Usuario usuario)
		{
			CalculaSalario processapagamento = new CalculaSalario();
			processapagamento.calculaSalario(usuario.Salario);
		}

	}


}
