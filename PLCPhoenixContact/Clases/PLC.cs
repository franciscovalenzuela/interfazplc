using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using PhoenixContact.PlciDotNet;
namespace PLCPhoenixContact.Clases
{
    class PLC
    {
        public string IP { get; set; }
        private Plci device;

        public PLC()
        {
            device = new Plci();
        }
        
        public  Boolean HacerPing()
        {
            try
            {
                Ping Pings = new Ping();
                int timeout = 10;

                if (Pings.Send(this.IP, timeout).Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        
        /// <summary>
        /// Funcion para enviar valores a variables en el PLC
        /// </summary>
        /// <param name="variables">Lista de variables</param>
        /// <param name="values">Lista de Valores</param>
        /// <returns>Regresa Bool si tiene exito o no en el envio</returns>
        public Boolean SendPLC(List<string> variables, List<object> values)
        {
            try
            {
                device.Connect(this.IP, 41100, 2000);
                IDataAccessService myDataAccessService1 = device.GetService<IDataAccessService>();

                if (myDataAccessService1 != null)
                {
                    myDataAccessService1.WriteVariables(variables, values);
                }

                device.Disconnect();
                device.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Funcion para obtener valores del PLC
        /// </summary>
        /// <param name="variables">Lista de variables a obtener</param>
        /// <returns>lista de objetos con valores obtenidos</returns>
        public  IList<object> GetPLC(List<string> variables)
        {
            try
            {
                device.Connect(this.IP, 41100, 2000);
                IDataAccessService myDataAccessService1 = device.GetService<IDataAccessService>();
                IList<object> value = new List<object>();

                if (myDataAccessService1 != null)
                {
                    value = myDataAccessService1.ReadVariables(variables);
                }

                device.Disconnect();
                device.Dispose();
                return value;
            }
            catch
            {
                return new List<object> { false };
            }
        }

        /// <summary>
        /// Controlar PLC 
        /// </summary>
        /// <param name="opcion">accion a controlar</param>
        /// <returns>boolean si logra enviar la accion</returns>
        public Boolean ControlarPLC(string opcion)
        {
            Boolean consulta = false;   
            device.Connect(this.IP, 41100, 2000);
            IPlcControlService myPlcControlService = device.GetService<IPlcControlService>();
            try
            {
                switch (opcion)
                {
                    case "Start":
                        myPlcControlService.StartPlc(StartMode.ColdStart);
                        break;
                    case "Stop":
                        myPlcControlService.StopPlc();
                        break;
                    default:
                        myPlcControlService.StartPlc(StartMode.ColdStart);
                        break;
                }
                consulta = true;
            }
            catch (Exception)
            {

            }
            if (myPlcControlService != null)
            {
                myPlcControlService.Dispose();
                myPlcControlService = null;
            }
            device.Disconnect();
            device.Dispose();
            return consulta;
        }

        public string GetEstadoPLC()
        {
            string respuesta = "";
            device.Connect(this.IP, 41100, 2000);
            IDeviceAttributeService myDeviceAttributeService = device.GetService<IDeviceAttributeService>();
            if (myDeviceAttributeService != null)
            {
                UInt32 plcStateNumber = myDeviceAttributeService.GetAttribute<UInt32>(StandardDeviceAttribute.PlcState);
                respuesta = ((PlcState)plcStateNumber).ToString();
                device.Disconnect();
                device.Dispose();
                return respuesta;
            }

            respuesta = PlcState.PlcOn.ToString();
            device.Disconnect();
            device.Dispose();
            return respuesta;
        }
    }
}
