using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prova3B;

namespace prova3B
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Matricula { get; set; }
        public DateOnly DataNasc { get; set; }
        
        public string Sexo { get; set; }
        public double Salario { get; set; }


        public Funcionario ()
        {
            

        }
    }
}
