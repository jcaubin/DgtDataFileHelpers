using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace ConsoleDgtData
{
    public class CmOptions
    {
        [Option('f', "file", Required = true, HelpText = "Fichero a procesar.")]
        public string FileName { get; set; }

        [Option('t', HelpText ="Tipo de fichero matriculas o bajas.", Required =false)]
        public TipoFichero? TipoFichero { get; set; }

        [Option('m', HelpText = "Filtro nombre de marca.", Required = false)]
        public string Marca { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            var help = new HelpText();
            help.AddPreOptionsLine("Utilizacion: consoledgtdata -f fichero -t tipo -m marca");
            help.AddOptions(this);
            return help;
        }
    }



}
