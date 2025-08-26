using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patterns_gof_builder
{
    public class NotebookBuilder : ComputadorBuilder
    {
         Computador computador;
        public NotebookBuilder()
        {
            computador = new Computador("Notebook");
        }
        public override void BuildDispositivos()
        {
            Console.WriteLine("Build dispositivos no Notebook...");
        }

        public override void BuildSO()
        {
            Console.WriteLine("Build Sistema Operacional no Notebook...");
        }

        public Computador TipoComputador
        {
            get { return computador; }
        }
    }
}