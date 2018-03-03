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
        public TipoFichero TipoFichero { get; set; }

        [Option('m', HelpText = "Filtro nombre de marca.", Required = false)]
        public string Marca { get; set; } = string.Empty;

        [Option('o', HelpText = "Tipo fichero de salida csv o zip.", Required = false)]
        public TipoSalida Salida { get; set; } = TipoSalida.csv;

        //[HelpOption]
        //public string GetUsage()
        //{
        //    var help = new HelpText();
        //    help.AddPreOptionsLine("Utilizacion: consoledgtdata -f fichero -t tipo -m marca");
        //    help.AddOptions(this);
        //    return help;
        //}
    }

    public enum TipoFichero
    {
        matriculas,
        bajas,
        transferencias
    }

    public enum TipoSalida
    {
        zip,
        csv
    }


}
