using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace ConsoleDgtData
{
    [FixedLengthRecord(FixedMode.AllowMoreChars)]
    [IgnoreFirst(1)]
    public class MatriculacionData
    {

        [FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        [FieldConverter(ConverterKind.Date, "ddMMyyyy")]
        public DateTime? FecMatricula;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public CodClaseMatricula? CodClaseMat;


        [FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        [FieldConverter(ConverterKind.Date, "ddMMyyyy")]
        public DateTime? FecTramitacion;


        [FieldFixedLength(30)]
        [FieldTrim(TrimMode.Both)]
        public string MarcaItv;


        [FieldFixedLength(22)]
        [FieldTrim(TrimMode.Both)]
        public string ModeloItv;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public CodProcedencia? CodProcedenciaItv;


        [FieldFixedLength(21)]
        [FieldTrim(TrimMode.Both)]
        public string BastidorItv;


        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string CodTipo;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string CodPropulsionItv;


        [FieldFixedLength(5)]
        [FieldTrim(TrimMode.Both)]
        public string CilindradaItv;


        [FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string PotenciaItv;


        [FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string Tara;


        [FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string PesoMax;


        [FieldFixedLength(3)]
        [FieldTrim(TrimMode.Both)]
        public string NumPlazas;


        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string IndPrecinto;


        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string IndEmbargo;


        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string NumTransmisiones;


        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string NumTitulares;


        [FieldFixedLength(24)]
        [FieldTrim(TrimMode.Both)]
        public string LocalidadVehiculo;


        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string CodProvinciaVeh;


        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string CodProvinciaMat;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string ClaveTramite;


        [FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        [FieldConverter(ConverterKind.Date, "ddMMyyyy")]
        public DateTime? FecTramite;


        [FieldFixedLength(5)]
        [FieldTrim(TrimMode.Both)]
        public string CodigoPostal;


        [FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        [FieldConverter(ConverterKind.Date, "ddMMyyyy")]
        public DateTime? FecPrimMatriculacion;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string IndNuevoUsado;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string PersonaFisicaJuridica;


        [FieldFixedLength(9)]
        [FieldTrim(TrimMode.Both)]
        public string CodigoItv;


        [FieldFixedLength(3)]
        [FieldTrim(TrimMode.Both)]
        public string Servicio;


        [FieldFixedLength(5)]
        [FieldTrim(TrimMode.Both)]
        public string CodMunicipioIneVeh;


        [FieldFixedLength(30)]
        [FieldTrim(TrimMode.Both)]
        public string Municipio;


        [FieldFixedLength(7)]
        [FieldTrim(TrimMode.Both)]
        public string KwItv;


        [FieldFixedLength(3)]
        [FieldTrim(TrimMode.Both)]
        public string NumPlazasMax;


        [FieldFixedLength(5)]
        [FieldTrim(TrimMode.Both)]
        public string Co2Itv;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string Renting;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string CodTutela;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string CodPosesion;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string IndBajaDef;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string IndBajaTemp;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string IndSustraccion;


        [FieldFixedLength(11)]
        [FieldTrim(TrimMode.Both)]
        public string BajaTelematica;


        [FieldFixedLength(25)]
        [FieldTrim(TrimMode.Both)]
        public string TipoItv;


        [FieldFixedLength(25)]
        [FieldTrim(TrimMode.Both)]
        public string VarianteItv;


        [FieldFixedLength(35)]
        [FieldTrim(TrimMode.Both)]
        public string VersionItv;


        [FieldFixedLength(70)]
        [FieldTrim(TrimMode.Both)]
        public string FabricanteItv;


        [FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string MasaOrdenMarchaItv;


        [FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string MasaMáximaTecnicaAdmisibleItv;


        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string CategoríaHomologaciónEuropeaItv;


        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string Carroceria;


        [FieldFixedLength(3)]
        [FieldTrim(TrimMode.Both)]
        public string PlazasPie;


        [FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public string NivelEmisionesEuroItv;


        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string ConsumowhKmItv;


        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string ClasificaciónReglamentoVehiculosItv;


        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string CategoríaVehículoEléctrico;


        [FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string AutonomíaVehículoEléctrico;


        [FieldFixedLength(30)]
        [FieldTrim(TrimMode.Both)]
        public string MarcaVehículoBase;


        [FieldFixedLength(50)]
        [FieldTrim(TrimMode.Both)]
        public string FabricanteVehículoBase;


        [FieldFixedLength(35)]
        [FieldTrim(TrimMode.Both)]
        public string TipoVehículoBase;


        [FieldFixedLength(25)]
        [FieldTrim(TrimMode.Both)]
        public string VarianteVehículoBase;


        [FieldFixedLength(35)]
        [FieldTrim(TrimMode.Both)]
        public string VersiónVehículoBase;


        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string DistanciaEjes12Itv;


        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string ViaAnteriorItv;


        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string ViaPosteriorItv;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string TipoAlimentacionItv;


        [FieldFixedLength(25)]
        [FieldTrim(TrimMode.Both)]
        public string ContraseñaHomologacionItv;


        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string EcoInnovacionItv;


        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string ReduccionEcoItv;


        [FieldFixedLength(25)]
        [FieldTrim(TrimMode.Both)]
        public string CodigoEcoItv;


        [FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        [FieldConverter(ConverterKind.Date, "ddMMyyyy")]
        public DateTime? FecProceso;
    }
}


























