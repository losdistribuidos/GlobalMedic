﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCita" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCita
    {

        [OperationContract]
        DataSet ObtenerCitaPorPacientes(string dni);
    }


}