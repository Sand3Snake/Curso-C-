using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
   public class Advogado
    {
        public string nome;
        public string oab;
        public double salario;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O nome do advogado é {nome}\nSeu oab é {oab}\nSeu salário é {salario}");
        }
    }
    
 }
