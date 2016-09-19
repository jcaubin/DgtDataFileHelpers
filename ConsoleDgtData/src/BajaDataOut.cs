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
    /// Preparada para salida en CSV
    /// </summary>
    [DelimitedRecord(";")]
    public class BajaDataOut
    {
        /// <summary>
        /// Fecha de matriculación del vehículos
        /// </summary>
        public string FecMatricula;

        /// <summary>
        /// Código de clase de matrícula
        /// </summary>
        public string CodClaseMat;

        /// <summary>
        /// Fecha de tramitación, que se corresponde con la fecha de transferencia del vehículo contenida en los datos de transferencias.
        /// </summary>
        public string FecTramitacion;

        /// <summary>
        /// Descripción de la marca del vehículo
        /// </summary>
        public string MarcaItv;

        /// <summary>
        /// Modelo del vehículo
        /// </summary>
        public string ModeloItv;

        /// <summary>
        /// Código de la procedencia del vehículo.
        /// </summary>
        public string CodProcedenciaItv;

        /// <summary>
        /// Número de bastidor
        /// </summary>
        public string BastidorItv;

        /// <summary>
        /// Código del tipo de vehículo
        /// </summary>
        public string CodTipo;

        /// <summary>
        /// Código del tipo de propulsión
        /// </summary>
        public string CodPropulsionItv;

        /// <summary>
        /// Cilindrada del  vehículo
        /// </summary>
        public string CilindradaItv;

        /// <summary>
        /// Potencia fiscal del vehículo. En CVF. Redondeado a la segunda cifra  decimal. 3 enteros y 2 decimales  EEEDD
        /// </summary>
        public string PotenciaItv;

        /// <summary>
        /// Tara del vehículo (peso del vehículo). la carga útil será la el peso_max - tara
        /// </summary>
        public string Tara;

        /// <summary>
        /// Peso máximo del vehículo
        /// </summary>
        public string PesoMax;

        /// <summary>
        /// Número de plazas de un vehículo. Para un vehículo de carga, este campo indicará el número de plazas máximo permitido cuando el vehículo está descargado.
        /// </summary>
        public string NumPlazasItv;

        /// <summary>
        /// Indicador de vehículo precintado
        /// </summary>
        public string IndPrecinto;

        /// <summary>
        /// Indicador de vehículo embargado
        /// </summary>
        public string IndEmbargo;

        /// <summary>
        /// Número de transmisiones que ha tenido el vehículo
        /// </summary>
        public string NumTransmisiones;

        /// <summary>
        /// Número de titulares del vehículo
        /// </summary>
        public string NumTitulares;

        /// <summary>
        /// Localidad del domicilio del vehículo
        /// </summary>
        public string LocalidadVehiculo;

        /// <summary>
        /// Código de la provincia donde está domiciliado el vehículo
        /// </summary>
        public string CodProvinciaVeh;

        /// <summary>
        /// Código de la provincia donde fue matriculado el vehículo
        /// </summary>
        public string CodProvinciaMat;

        /// <summary>
        /// Código del trámite
        /// </summary>
        public string ClaveTramite;

        /// <summary>
        /// Fecha en la que se realizó el trámite
        /// </summary>
        public string FecTramite;

        /// <summary>
        /// Código postal donde está domiciliado el vehículo
        /// </summary>
        public string CodigoPostal;

        /// <summary>
        /// Fecha de la primera matriculación del vehículo.
        /// </summary>
        public string FecPrimMatriculacion;

        /// <summary>
        /// Indica si el vehículo es nuevo (N)i o usado (U)  al momento de la matriculación FEC_MATRICULA.  Este campo se calcula en el almacén de datos.
        /// </summary>
        public string IndNuevoUsado;

        /// <summary>
        /// Si es una persona física o jurídica el titular del vehículo
        /// </summary>
        public string PersonaFisicaJuridica;

        /// <summary>
        /// Código ITV
        /// </summary>
        public string CodigoItv;

        /// <summary>
        /// Código de servicio del vehículo (nueva versión del campo)
        /// </summary>
        public string Servicio;

        /// <summary>
        /// Código INE del municipio del domicilio del vehículo
        /// </summary>
        public string CodMunicipioIneVeh;

        /// <summary>
        /// Nombre del municipio donde esta domiciliado el vehículo
        /// </summary>
        public string Municipio;

        /// <summary>
        /// Potencia neta máxima en KW)
        /// </summary>
        public string KwItv;

        /// <summary>
        /// Número de plazas máximo de un vehículo.  Ejemplo 1: para un vehículo de carga, este campo indicará el número de plazas máximo permitido cuando el vehículo está cargado.
        /// </summary>
        public string NumPlazasMax;

        /// <summary>
        /// Emisiones CO2.
        /// </summary>
        public string Co2Itv;

        /// <summary>
        /// Indica si es vehículo de renting
        /// </summary>
        public string Renting;

        /// <summary>
        /// Indica si un vehículo está a nombre de un titular menor de edad o con tutela judicial
        /// </summary>
        public string CodTutela;

        /// <summary>
        /// Código del tipo de posesión del vehículo. Indica si es un vehículo con posesión por alguien distinto al titular (herencias, compraventas...)
        /// </summary>
        public string CodPosesion;

        /// <summary>
        /// Indicador de baja definitiva del vehículo
        /// </summary>
        public string IndBajaDef;

        /// <summary>
        /// Indicador de baja temporal del vehículo
        /// </summary>
        public string IndBajaTemp;

        /// <summary>
        /// Indicador de vehículo robado
        /// </summary>
        public string IndSustraccion;

        /// <summary>
        /// Si es una baja telemática su valor será “En desguace”. En caso contrario vendrá a blancos.
        /// </summary>
        public string BajaTelematica;

        /// <summary>
        /// Tipo del vehículo
        /// </summary>
        public string TipoItv;

        /// <summary>
        /// Variante del vehículo 
        /// </summary>
        public string VarianteItv;

        /// <summary>
        /// Versión del vehículo
        /// </summary>
        public string VersionItv;

        /// <summary>
        /// Fabricante del vehículo completo o completado
        /// </summary>
        public string FabricanteItv;

        /// <summary>
        /// Masa en orden de marcha
        /// </summary>
        public string MasaOrdenMarchaItv;

        /// <summary>
        /// Masa máxima técnicamente admisible
        /// </summary>
        public string MasaMáximaTecnicaAdmisibleItv;

        /// <summary>
        /// Categoría homologación UE
        /// </summary>
        public string CategoríaHomologaciónEuropeaItv;

        /// <summary>
        /// Carrocería del vehículo
        /// </summary>
        public string Carroceria;

        /// <summary>
        /// Número plazas de pié
        /// </summary>
        public string PlazasPie;

        /// <summary>
        /// Nivel emisiones EURO
        /// </summary>
        public string NivelEmisionesEuroItv;

        /// <summary>
        /// Consumo energía eléctrica
        /// </summary>
        public string ConsumowhKmItv;

        /// <summary>
        ///  Clasificación Anexo II RD 2822
        /// </summary>
        public string ClasificaciónReglamentoVehiculosItv;

        /// <summary>
        /// Categoría de vehículo eléctrico
        /// </summary>
        public string CategoríaVehículoEléctrico;

        /// <summary>
        /// Autonomía del vehículo eléctrico
        /// </summary>
        public string AutonomíaVehículoEléctrico;

        /// <summary>
        /// Marca del vehículo base
        /// </summary>
        public string MarcaVehículoBase;

        /// <summary>
        /// Fabricante del vehículo base
        /// </summary>
        public string FabricanteVehículoBase;

        /// <summary>
        ///  Tipo del vehículo base
        /// </summary>
        public string TipoVehículoBase;

        /// <summary>
        /// Variante del vehículo base
        /// </summary>
        public string VarianteVehículoBase;

        /// <summary>
        /// Versión del vehículo base
        /// </summary>
        public string VersiónVehículoBase;

        /// <summary>
        /// Distancia entre ejes 1-2
        /// </summary>
        public string DistanciaEjes12Itv;

        /// <summary>
        /// En mm.
        /// </summary>
        public string ViaAnteriorItv;

        /// <summary>
        /// En mm.
        /// </summary>
        public string ViaPosteriorItv;

        /// <summary>
        /// M= monocombustible. B= bicombustible F= flexicombustiblel.
        /// </summary>
        public string TipoAlimentacionItv;

        /// <summary>
        /// Contraseña de homologación.
        /// </summary>
        public string ContraseñaHomologacionItv;

        /// <summary>
        /// S= SI, N= NO. A la espera de definir por UE, hasta entonces se deja en blanco.
        /// </summary>
        public string EcoInnovacionItv;

        /// <summary>
        /// A la espera de definir por UE, hasta entonces se deba en blanco.
        /// </summary>
        public string ReduccionEcoItv;

        /// <summary>
        /// A la espera de definir por UE, hasta entonces se deba en blanco.
        /// </summary>
        public string CodigoEcoItv;

        /// <summary>
        /// Fecha en la que grabo el proceso de la operación (matriculación, baja o transferencia)
        /// </summary>
        public string FecProceso;
    }
}
