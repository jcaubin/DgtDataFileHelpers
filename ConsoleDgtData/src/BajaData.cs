using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace ConsoleDgtData
{
    /// <summary>
    /// Estructura de datos de BAJA de la DGT
    /// </summary>
    [FixedLengthRecord(FixedMode.AllowMoreChars)]
    public class BajaData
    {
        /// <summary>
        /// Fecha de matriculación del vehículos
        /// </summary>
        [FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public DateTime? FecMatricula;


        /// <summary>
        /// Código de clase de matrícula
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public CodClaseMatricula? CodClaseMat;


        /// <summary>
        /// Fecha de tramitación, que se corresponde con la fecha de transferencia del vehículo contenida en los datos de transferencias.
        /// </summary>
        [FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public DateTime? FecTramitacion;


        /// <summary>
        /// Descripción de la marca del vehículo
        /// </summary>
        [FieldFixedLength(30)]
        [FieldTrim(TrimMode.Both)]
        public string MarcaItv;


        /// <summary>
        /// Modelo del vehículo
        /// </summary>
        [FieldFixedLength(22)]
        [FieldTrim(TrimMode.Both)]
        public string ModeloItv;


        /// <summary>
        /// Código de la procedencia del vehículo.
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public CodProcedencia? CodProcedenciaItv;


        /// <summary>
        /// Número de bastidor
        /// </summary>
        [FieldFixedLength(21)]
        [FieldTrim(TrimMode.Both)]
        public string BastidorItv;


        /// <summary>
        /// Código del tipo de vehículo
        /// </summary>
        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string CodTipo;


        /// <summary>
        /// Código del tipo de propulsión
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string CodPropulsionItv;


        /// <summary>
        /// Cilindrada del  vehículo
        /// </summary>
        [FieldFixedLength(5)]
        [FieldTrim(TrimMode.Both)]
        public string CilindradaItv;


        /// <summary>
        /// Potencia fiscal del vehículo. En CVF. Redondeado a la segunda cifra  decimal. 3 enteros y 2 decimales  EEEDD
        /// </summary>
        [FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string PotenciaItv;


        /// <summary>
        /// Tara del vehículo (peso del vehículo). la carga útil será la el peso_max - tara
        /// </summary>
        [FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string Tara;


        /// <summary>
        /// Peso máximo del vehículo
        /// </summary>
        [FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string PesoMax;


        /// <summary>
        /// Número de plazas de un vehículo. Para un vehículo de carga, este campo indicará el número de plazas máximo permitido cuando el vehículo está descargado.
        /// </summary>
        [FieldFixedLength(3)]
        [FieldTrim(TrimMode.Both)]
        public string NumPlazasItv;


        /// <summary>
        /// Indicador de vehículo precintado
        /// </summary>
        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string IndPrecinto;


        /// <summary>
        /// Indicador de vehículo embargado
        /// </summary>
        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string IndEmbargo;


        /// <summary>
        /// Número de transmisiones que ha tenido el vehículo
        /// </summary>
        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string NumTransmisiones;


        /// <summary>
        /// Número de titulares del vehículo
        /// </summary>
        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string NumTitulares;


        /// <summary>
        /// Localidad del domicilio del vehículo
        /// </summary>
        [FieldFixedLength(24)]
        [FieldTrim(TrimMode.Both)]
        public string LocalidadVehiculo;


        /// <summary>
        /// Código de la provincia donde está domiciliado el vehículo
        /// </summary>
        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string CodProvinciaVeh;


        /// <summary>
        /// Código de la provincia donde fue matriculado el vehículo
        /// </summary>
        [FieldFixedLength(2)]
        [FieldTrim(TrimMode.Both)]
        public string CodProvinciaMat;


        /// <summary>
        /// Código del trámite
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string ClaveTramite;


        /// <summary>
        /// Fecha en la que se realizó el trámite
        /// </summary>
        [FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public DateTime? FecTramite;


        /// <summary>
        /// Código postal donde está domiciliado el vehículo
        /// </summary>
        [FieldFixedLength(5)]
        [FieldTrim(TrimMode.Both)]
        public string CodigoPostal;


        /// <summary>
        /// Fecha de la primera matriculación del vehículo.
        /// </summary>
        [FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public DateTime? FecPrimMatriculacion;


        /// <summary>
        /// Indica si el vehículo es nuevo (N)i o usado (U)  al momento de la matriculación FEC_MATRICULA.  Este campo se calcula en el almacén de datos.
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string IndNuevoUsado;


        /// <summary>
        /// Si es una persona física o jurídica el titular del vehículo
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string PersonaFisicaJuridica;


        /// <summary>
        /// Código ITV
        /// </summary>
        [FieldFixedLength(9)]
        [FieldTrim(TrimMode.Both)]
        public string CodigoItv;


        /// <summary>
        /// Código de servicio del vehículo (nueva versión del campo)
        /// </summary>
        [FieldFixedLength(3)]
        [FieldTrim(TrimMode.Both)]
        public string Servicio;


        /// <summary>
        /// Código INE del municipio del domicilio del vehículo
        /// </summary>
        [FieldFixedLength(5)]
        [FieldTrim(TrimMode.Both)]
        public string CodMunicipioIneVeh;


        /// <summary>
        /// Nombre del municipio donde esta domiciliado el vehículo
        /// </summary>
        [FieldFixedLength(30)]
        [FieldTrim(TrimMode.Both)]
        public string Municipio;


        /// <summary>
        /// Potencia neta máxima en KW)
        /// </summary>
        [FieldFixedLength(7)]
        [FieldTrim(TrimMode.Both)]
        public string KwItv;


        /// <summary>
        /// Número de plazas máximo de un vehículo.  Ejemplo 1: para un vehículo de carga, este campo indicará el número de plazas máximo permitido cuando el vehículo está cargado.
        /// </summary>
        [FieldFixedLength(3)]
        [FieldTrim(TrimMode.Both)]
        public string NumPlazasMax;


        /// <summary>
        /// Emisiones CO2.
        /// </summary>
        [FieldFixedLength(5)]
        [FieldTrim(TrimMode.Both)]
        public string Co2Itv;


        /// <summary>
        /// Indica si es vehículo de renting
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string Renting;


        /// <summary>
        /// Indica si un vehículo está a nombre de un titular menor de edad o con tutela judicial
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string CodTutela;


        /// <summary>
        /// Código del tipo de posesión del vehículo. Indica si es un vehículo con posesión por alguien distinto al titular (herencias, compraventas...)
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string CodPosesion;


        /// <summary>
        /// Indicador de baja definitiva del vehículo
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string IndBajaDef;


        /// <summary>
        /// Indicador de baja temporal del vehículo
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string IndBajaTemp;


        /// <summary>
        /// Indicador de vehículo robado
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string IndSustraccion;


        /// <summary>
        /// Si es una baja telemática su valor será “En desguace”. En caso contrario vendrá a blancos.
        /// </summary>
        [FieldFixedLength(11)]
        [FieldTrim(TrimMode.Both)]
        public string BajaTelematica;


        /// <summary>
        /// Tipo del vehículo
        /// </summary>
        [FieldFixedLength(25)]
        [FieldTrim(TrimMode.Both)]
        public string TipoItv;


        /// <summary>
        /// Variante del vehículo 
        /// </summary>
        [FieldFixedLength(25)]
        [FieldTrim(TrimMode.Both)]
        public string VarianteItv;


        /// <summary>
        /// Versión del vehículo
        /// </summary>
        [FieldFixedLength(35)]
        [FieldTrim(TrimMode.Both)]
        public string VersionItv;


        /// <summary>
        /// Fabricante del vehículo completo o completado
        /// </summary>
        [FieldFixedLength(70)]
        [FieldTrim(TrimMode.Both)]
        public string FabricanteItv;


        /// <summary>
        /// Masa en orden de marcha
        /// </summary>
        [FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string MasaOrdenMarchaItv;


        /// <summary>
        /// Masa máxima técnicamente admisible
        /// </summary>
        [FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string MasaMáximaTecnicaAdmisibleItv;


        /// <summary>
        /// Categoría homologación UE
        /// </summary>
        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string CategoríaHomologaciónEuropeaItv;


        /// <summary>
        /// Carrocería del vehículo
        /// </summary>
        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string Carroceria;


        /// <summary>
        /// Número plazas de pié
        /// </summary>
        [FieldFixedLength(3)]
        [FieldTrim(TrimMode.Both)]
        public string PlazasPie;


        /// <summary>
        /// Nivel emisiones EURO
        /// </summary>
        [FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public string NivelEmisionesEuroItv;


        /// <summary>
        /// Consumo energía eléctrica
        /// </summary>
        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string ConsumowhKmItv;


        /// <summary>
        ///  Clasificación Anexo II RD 2822
        /// </summary>
        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string ClasificaciónReglamentoVehiculosItv;


        /// <summary>
        /// Categoría de vehículo eléctrico
        /// </summary>
        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string CategoríaVehículoEléctrico;


        /// <summary>
        /// Autonomía del vehículo eléctrico
        /// </summary>
        [FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string AutonomíaVehículoEléctrico;


        /// <summary>
        /// Marca del vehículo base
        /// </summary>
        [FieldFixedLength(30)]
        [FieldTrim(TrimMode.Both)]
        public string MarcaVehículoBase;


        /// <summary>
        /// Fabricante del vehículo base
        /// </summary>
        [FieldFixedLength(50)]
        [FieldTrim(TrimMode.Both)]
        public string FabricanteVehículoBase;


        /// <summary>
        ///  Tipo del vehículo base
        /// </summary>
        [FieldFixedLength(35)]
        [FieldTrim(TrimMode.Both)]
        public string TipoVehículoBase;


        /// <summary>
        /// Variante del vehículo base
        /// </summary>
        [FieldFixedLength(25)]
        [FieldTrim(TrimMode.Both)]
        public string VarianteVehículoBase;


        /// <summary>
        /// Versión del vehículo base
        /// </summary>
        [FieldFixedLength(35)]
        [FieldTrim(TrimMode.Both)]
        public string VersiónVehículoBase;


        /// <summary>
        /// Distancia entre ejes 1-2
        /// </summary>
        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string DistanciaEjes12Itv;


        /// <summary>
        /// En mm.
        /// </summary>
        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string ViaAnteriorItv;


        /// <summary>
        /// En mm.
        /// </summary>
        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string ViaPosteriorItv;


        /// <summary>
        /// M= monocombustible. B= bicombustible F= flexicombustiblel.
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string TipoAlimentacionItv;


        /// <summary>
        /// Contraseña de homologación.
        /// </summary>
        [FieldFixedLength(25)]
        [FieldTrim(TrimMode.Both)]
        public string ContraseñaHomologacionItv;


        /// <summary>
        /// S= SI, N= NO. A la espera de definir por UE, hasta entonces se deja en blanco.
        /// </summary>
        [FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string EcoInnovacionItv;


        /// <summary>
        /// A la espera de definir por UE, hasta entonces se deba en blanco.
        /// </summary>
        [FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public string ReduccionEcoItv;


        /// <summary>
        /// A la espera de definir por UE, hasta entonces se deba en blanco.
        /// </summary>
        [FieldFixedLength(25)]
        [FieldTrim(TrimMode.Both)]
        public string CodigoEcoItv;


        /// <summary>
        /// Fecha en la que grabo el proceso de la operación (matriculación, baja o transferencia)
        /// </summary>
        [FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public DateTime? FecProceso;
    }
}
