using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace PLCPhoenixContact
{
    public partial class Main : Form
    {
        private Clases.PLC plc;
        private string IP = "";

        public Main()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string r = "";
            while (!backgroundWorker1.CancellationPending)
            {
                Thread.Sleep(100);
                try
                {
                    if (this.plc.HacerPing())
                    {
                        IList<object> b = this.plc.GetPLC(new List<string> { "@GlobalVariables." + txtvar1.Text });
                        if (b.Count > 0)
                        {
                            r = b[0].ToString();
                            r = r + "," + b[0].GetType();
                        }
                        else
                        {
                            r = "Nada que leer :(";
                        }
                    }
                    else
                    {
                        r = "No hay comunicacion con el PLC";
                    }
                }
                catch
                {
                    r = "ERROR";
                }
                backgroundWorker1.ReportProgress(0, r);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                string[] plcvariable = ((string)e.UserState).Split(',');
                txtvalor1.Text = plcvariable[0];
                txttipo.Text = plcvariable[1];
            }
            catch
            {
            }
        }

        private void Leer_Click(object sender, EventArgs e)
        {
            if (Leer.Text == "Bajar Cambios")
            {
                Leer.Text = "Parar";
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                if (backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.CancelAsync();
                }
            }
        }

        // Para leer variables globales "@GlobalVariables.MyGlobalVariableName"
        // Para leer variables locales  "@InstanceVariables.MyResource.MyTask.MyProgram.MyProgramVariable"
        private void Escribir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.plc.HacerPing())
                {
                    if (rbool.Checked)
                    {
                        this.plc.SendPLC(new List<string> { "@GlobalVariables." + txtvar2.Text },
                            new List<object> { Convert.ToBoolean(txtvalor2.Text) });
                    }

                    if (rint32.Checked)
                    {
                        this.plc.SendPLC(new List<string> { "@GlobalVariables." + txtvar2.Text },
                           new List<object> { Convert.ToInt32(txtvalor2.Text) });
                    }

                    if (ruint16.Checked)
                    {
                        this.plc.SendPLC(new List<string> { "@GlobalVariables." + txtvar2.Text },
                           new List<object> { Convert.ToUInt16(txtvalor2.Text) });
                    }

                    if (runit32.Checked)
                    {
                        this.plc.SendPLC(new List<string> { "@GlobalVariables." + txtvar2.Text },
                           new List<object> { Convert.ToUInt32(txtvalor2.Text) });
                    }
                }
                else
                {
                    txtvalor2.Text = "No hay comunicacion con el PLC";
                }
            }
            catch
            {
                txtvalor2.Text = "ERROR";
            }
        }
        
        private void btnstop_Click(object sender, EventArgs e)
        {
            this.plc.ControlarPLC("Stop");
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            this.plc.ControlarPLC("Start");
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!backgroundWorker2.CancellationPending)
            {
                Thread.Sleep(600);
                IPAddress ipcheck;
                if(IPAddress.TryParse(this.IP, out ipcheck))
                {
                    this.plc.IP = this.IP;
                    if (this.plc.HacerPing())
                    {
                        while (!backgroundWorker2.CancellationPending)
                        {
                            Thread.Sleep(200);
                            backgroundWorker1.ReportProgress(0, this.plc.GetEstadoPLC());
                        }
                    }
                }
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            txtestado.Text = (string)e.UserState;
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            this.IP = txtIP.Text;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.plc = new Clases.PLC();
            this.backgroundWorker2.RunWorkerAsync();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.backgroundWorker2.CancelAsync();
        }
    }
}
