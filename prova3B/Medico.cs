using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prova3B;

namespace prova3B
{
    public class Medico: Funcionario //22% de acrescimo 
    {
        public string CRM { get; set; }
        public double ValorHoraExtra { get; set; }
        public string Especialidade { get; set; }


        public Medico()
        {
            
        }
    }
}
