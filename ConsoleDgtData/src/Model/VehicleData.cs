using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDgtData
{
    /// <summary>
    /// Registro de datos de un vehiculo
    /// </summary>
    public class VehicleData
    {
        [Key]
        public int Id { get; set; }

        public TipoFichero? TipoFichero { get; set; }

        [MaxLength(250)]
        public string NombreFichero { get; set; }

        /// <summary>
        /// Fecha de matriculación del vehículos
        /// </summary>

        public DateTime? FecMatricula { get; set; }


        /// <summary>
        /// Código de clase de matrícula
        /// </summary>
        //[MaxLength(1)]
        public int? CodClaseMat { get; set; }


        /// <summary>
        /// Fecha de tramitación, que se corresponde con la fecha de transferencia del vehículo contenida en los datos de transferencias.
        /// </summary>

        public DateTime? FecTramitacion { get; set; }


        /// <summary>
        /// Descripción de la marca del vehículo
        /// </summary>
        [MaxLength(30)]
        public string MarcaItv { get; set; }


        /// <summary>
        /// Modelo del vehículo
        /// </summary>
        [MaxLength(22)]
        public string ModeloItv { get; set; }


        /// <summary>
        /// Código de la procedencia del vehículo.
        /// </summary>
        [MaxLength(1)]
        public string CodProcedenciaItv { get; set; }


        /// <summary>
        /// Número de bastidor
        /// </summary>
        [MaxLength(21)]
        public string BastidorItv { get; set; }


        /// <summary>
        /// Código del tipo de vehículo
        /// </summary>
        [MaxLength(2)]
        public string CodTipo { get; set; }


        /// <summary>
        /// Código del tipo de propulsión
        /// </summary>
        [MaxLength(1)]
        public string CodPropulsionItv { get; set; }


        /// <summary>
        /// Cilindrada del  vehículo
        /// </summary>

        public decimal? CilindradaItv { get; set; }


        /// <summary>
        /// Potencia fiscal del vehículo. En CVF. Redondeado a la segunda cifra  decimal. 3 enteros y 2 decimales  EEEDD
        /// </summary>

        public decimal? PotenciaItv { get; set; }


        /// <summary>
        /// Tara del vehículo (peso del vehículo). la carga útil será la el peso_max - tara
        /// </summary>

        public decimal? Tara { get; set; }


        /// <summary>
        /// Peso máximo del vehículo
        /// </summary>

        public decimal? PesoMax { get; set; }


        /// <summary>
        /// Número de plazas de un vehículo. Para un vehículo de carga, este campo indicará el número de plazas máximo permitido cuando el vehículo está descargado.
        /// </summary>

        public int? NumPlazasItv { get; set; }


        /// <summary>
        /// Indicador de vehículo precintado
        /// </summary>
        [MaxLength(2)]
        public string IndPrecinto { get; set; }


        /// <summary>
        /// Indicador de vehículo embargado
        /// </summary>
        [MaxLength(2)]
        public string IndEmbargo { get; set; }


        /// <summary>
        /// Número de transmisiones que ha tenido el vehículo
        /// </summary>

        public int? NumTransmisiones { get; set; }


        /// <summary>
        /// Número de titulares del vehículo
        /// </summary>

        public int? NumTitulares { get; set; }


        /// <summary>
        /// Localidad del domicilio del vehículo
        /// </summary>
        [MaxLength(24)]
        public string LocalidadVehiculo { get; set; }


        /// <summary>
        /// Código de la provincia donde está domiciliado el vehículo
        /// </summary>
        [MaxLength(2)]
        public string CodProvinciaVeh { get; set; }


        /// <summary>
        /// Código de la provincia donde fue matriculado el vehículo
        /// </summary>
        [MaxLength(2)]
        public string CodProvinciaMat { get; set; }


        /// <summary>
        /// Código del trámite
        /// </summary>
        [MaxLength(1)]
        public string ClaveTramite { get; set; }


        /// <summary>
        /// Fecha en la que se realizó el trámite
        /// </summary>
        [MaxLength(8)]
        public string FecTramite { get; set; }


        /// <summary>
        /// Código postal donde está domiciliado el vehículo
        /// </summary>

        public int? CodigoPostal { get; set; }


        /// <summary>
        /// Fecha de la primera matriculación del vehículo.
        /// </summary>

        public DateTime? FecPrimMatriculacion { get; set; }


        /// <summary>
        /// Indica si el vehículo es nuevo (N)i o usado (U)  al momento de la matriculación FEC_MATRICULA.  Este campo se calcula en el almacén de datos.
        /// </summary>
        [MaxLength(1)]
        public string IndNuevoUsado { get; set; }


        /// <summary>
        /// Si es una persona física o jurídica el titular del vehículo
        /// </summary>
        [MaxLength(1)]
        public string PersonaFisicaJuridica { get; set; }


        /// <summary>
        /// Código ITV
        /// </summary>
        [MaxLength(9)]
        public string CodigoItv { get; set; }


        /// <summary>
        /// Código de servicio del vehículo (nueva versión del campo)
        /// </summary>
        [MaxLength(3)]
        public string Servicio { get; set; }


        /// <summary>
        /// Código INE del municipio del domicilio del vehículo
        /// </summary>

        public int? CodMunicipioIneVeh { get; set; }


        /// <summary>
        /// Nombre del municipio donde esta domiciliado el vehículo
        /// </summary>
        [MaxLength(30)]
        public string Municipio { get; set; }


        /// <summary>
        /// Potencia neta máxima en KW)
        /// </summary>

        public decimal? KwItv { get; set; }


        /// <summary>
        /// Número de plazas máximo de un vehículo.  Ejemplo 1: para un vehículo de carga, este campo indicará el número de plazas máximo permitido cuando el vehículo está cargado.
        /// </summary>

        public int? NumPlazasMax { get; set; }


        /// <summary>
        /// Emisiones CO2.
        /// </summary>

        public int? Co2Itv { get; set; }


        /// <summary>
        /// Indica si es vehículo de renting
        /// </summary>
        [MaxLength(1)]
        public string Renting { get; set; }


        /// <summary>
        /// Indica si un vehículo está a nombre de un titular menor de edad o con tutela judicial
        /// </summary>
        [MaxLength(1)]
        public string CodTutela { get; set; }


        /// <summary>
        /// Código del tipo de posesión del vehículo. Indica si es un vehículo con posesión por alguien distinto al titular (herencias, compraventas...)
        /// </summary>
        [MaxLength(1)]
        public string CodPosesion { get; set; }


        /// <summary>
        /// Indicador de baja definitiva del vehículo
        /// </summary>
        [MaxLength(1)]
        public string IndBajaDef { get; set; }


        /// <summary>
        /// Indicador de baja temporal del vehículo
        /// </summary>
        [MaxLength(1)]
        public string IndBajaTemp { get; set; }


        /// <summary>
        /// Indicador de vehículo robado
        /// </summary>
        [MaxLength(1)]
        public string IndSustraccion { get; set; }


        /// <summary>
        /// Si es una baja telemática su valor será “En desguace”. En caso contrario vendrá a blancos.
        /// </summary>
        [MaxLength(11)]
        public string BajaTelematica { get; set; }


        /// <summary>
        /// Tipo del vehículo
        /// </summary>
        [MaxLength(25)]
        public string TipoItv { get; set; }


        /// <summary>
        /// Variante del vehículo 
        /// </summary>
        [MaxLength(25)]
        public string VarianteItv { get; set; }


        /// <summary>
        /// Versión del vehículo
        /// </summary>
        [MaxLength(35)]
        public string VersionItv { get; set; }


        /// <summary>
        /// Fabricante del vehículo completo o completado
        /// </summary>
        [MaxLength(70)]
        public string FabricanteItv { get; set; }


        /// <summary>
        /// Masa en orden de marcha
        /// </summary>

        public int? MasaOrdenMarchaItv { get; set; }


        /// <summary>
        /// Masa máxima técnicamente admisible
        /// </summary>

        public int? MasaMáximaTecnicaAdmisibleItv { get; set; }


        /// <summary>
        /// Categoría homologación UE
        /// </summary>
        [MaxLength(4)]
        public string CategoríaHomologaciónEuropeaItv { get; set; }


        /// <summary>
        /// Carrocería del vehículo
        /// </summary>
        [MaxLength(4)]
        public string Carroceria { get; set; }


        /// <summary>
        /// Número plazas de pié
        /// </summary>

        public int? PlazasPie { get; set; }


        /// <summary>
        /// Nivel emisiones EURO
        /// </summary>
        [MaxLength(8)]
        public string NivelEmisionesEuroItv { get; set; }


        /// <summary>
        /// Consumo energía eléctrica
        /// </summary>
        [MaxLength(4)]
        public string ConsumowhKmItv { get; set; }


        /// <summary>
        ///  Clasificación Anexo II RD 2822
        /// </summary>
        [MaxLength(4)]
        public string ClasificaciónReglamentoVehiculosItv { get; set; }


        /// <summary>
        /// Categoría de vehículo eléctrico
        /// </summary>
        [MaxLength(4)]
        public string CategoríaVehículoEléctrico { get; set; }


        /// <summary>
        /// Autonomía del vehículo eléctrico
        /// </summary>
        [MaxLength(6)]
        public string AutonomíaVehículoEléctrico { get; set; }


        /// <summary>
        /// Marca del vehículo base
        /// </summary>
        [MaxLength(30)]
        public string MarcaVehículoBase { get; set; }


        /// <summary>
        /// Fabricante del vehículo base
        /// </summary>
        [MaxLength(50)]
        public string FabricanteVehículoBase { get; set; }


        /// <summary>
        ///  Tipo del vehículo base
        /// </summary>
        [MaxLength(35)]
        public string TipoVehículoBase { get; set; }


        /// <summary>
        /// Variante del vehículo base
        /// </summary>
        [MaxLength(25)]
        public string VarianteVehículoBase { get; set; }


        /// <summary>
        /// Versión del vehículo base
        /// </summary>
        [MaxLength(35)]
        public string VersiónVehículoBase { get; set; }


        /// <summary>
        /// Distancia entre ejes 1-2
        /// </summary>
        [MaxLength(4)]
        public string DistanciaEjes12Itv { get; set; }


        /// <summary>
        /// En mm.
        /// </summary>
        [MaxLength(4)]
        public string ViaAnteriorItv { get; set; }


        /// <summary>
        /// En mm.
        /// </summary>
        [MaxLength(4)]
        public string ViaPosteriorItv { get; set; }


        /// <summary>
        /// M= monocombustible. B= bicombustible F= flexicombustiblel.
        /// </summary>
        [MaxLength(1)]
        public string TipoAlimentacionItv { get; set; }


        /// <summary>
        /// Contraseña de homologación.
        /// </summary>
        [MaxLength(25)]
        public string ContraseñaHomologacionItv { get; set; }


        /// <summary>
        /// S= SI, N= NO. A la espera de definir por UE, hasta entonces se deja en blanco.
        /// </summary>
        [MaxLength(1)]
        public string EcoInnovacionItv { get; set; }


        /// <summary>
        /// A la espera de definir por UE, hasta entonces se deba en blanco.
        /// </summary>
        [MaxLength(4)]
        public string ReduccionEcoItv { get; set; }


        /// <summary>
        /// A la espera de definir por UE, hasta entonces se deba en blanco.
        /// </summary>
        [MaxLength(25)]
        public string CodigoEcoItv { get; set; }


        /// <summary>
        /// Fecha en la que grabo el proceso de la operación (matriculación, baja o transferencia)
        /// </summary>

        public DateTime? FecProceso { get; set; }


    }
}
