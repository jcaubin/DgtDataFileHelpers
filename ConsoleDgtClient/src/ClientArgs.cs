using CommandLine;
using CommandLine.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDgtClient
{
    class ClientArgs
    {

        [Option('t', HelpText = "Tipo de fichero matriculas o bajas.", Required = false)]
        public TipoFichero? TipoFichero { get; set; }

        [Option('b', "begin", Required = true, HelpText = "Fecha desde.")]
        public DateTime Begin { get; set; }

        [Option('e', "end", Required = true, HelpText = "Fecha hasta.")]
        public DateTime End { get; set; }



        [HelpOption]
        public string GetUsage()
        {
            var help = new HelpText();
            help.AddPreOptionsLine("Utilizacion: ...");
            help.AddOptions(this);
            return help;
        }

    }
}
