using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.API.WebService.Abstracts;

namespace Jaeger.SAT.API.WebService.Consultas {
    /// <summary>
    ///     Resultado de la peticion de solicitud.
    /// </summary>
    [GeneratedCode("System.Xml", "4.7.2612.0")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    [Serializable]
    public class RespuestaSolicitudDescMasTercero : PropertyChangeImplementation {
        private string idSolicitudField;
        private string codEstatusField;
        private string mensajeField;

        /// <summary>
        ///     IdSolicitud - Contiene el resultado de la petición con el código de respuesta y los UUID de los CFDIs de los cuales
        ///     se solicitó la descarga, pero se encuentran en espera de una confirmación por parte del receptor.
        /// </summary>
        [XmlAttribute]
        public string IdSolicitud {
            get { return idSolicitudField; }
            set {
                idSolicitudField = value;
                OnPropertyChanged(nameof(IdSolicitud));
            }
        }

        /// <summary>
        ///     CodEstatus - Código de estatus de la solicitud.
        /// </summary>
        [XmlAttribute]
        public string CodEstatus {
            get { return codEstatusField; }
            set {
                codEstatusField = value;
                OnPropertyChanged(nameof(CodEstatus));
            }
        }

        /// <summary>
        ///     Mensaje - Pequeña descripción del código estatus.
        /// </summary>
        [XmlAttribute]
        public string Mensaje {
            get { return mensajeField; }
            set {
                mensajeField = value;
                OnPropertyChanged(nameof(Mensaje));
            }
        }
    }
}
