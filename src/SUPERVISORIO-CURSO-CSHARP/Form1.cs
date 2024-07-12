using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using MySql.Data.MySqlClient;

namespace SUPERVISORIO_CURSO_CSHARP
{
    public partial class Form1 : Form
    {
        private ModbusClient modbusClient;
        bool isModbusActive = true;
        int[] holdings;
        int prev_value = 0, current_value = 0;
        string connectionString = "server=127.0.0.1;port=3306;database=csharp;uid=root;password=admin123";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            modbusClient = new ModbusClient("192.168.0.1", 502);
            modbusClient.UnitIdentifier = 1;

            try
            {
                modbusClient.Connect();
                lblConected.BackColor = Color.Green;
                lblInfo.Text = "Conectado com sucesso!";
                Thread threadModbus = new Thread(new ThreadStart(modbusScan));
                threadModbus.Start();
            }catch(Exception ex)
            {
                lblInfo.Text = "Falha ao se conectar com o CLP";
                lblConected.BackColor = Color.Red;
            }
        }

        private void modbusScan()
        {
            while(isModbusActive)
            {
                try
                {
                    holdings = modbusClient.ReadHoldingRegisters(0, 10);                   
                    
                    lblCaixaAlta.Invoke((MethodInvoker)(() => lblCaixaAlta.Text = holdings[0].ToString()));
                    lblCaixaBaixa.Invoke((MethodInvoker)(() => lblCaixaBaixa.Text = holdings[1].ToString()));
                    current_value = holdings[7];

                    if(current_value != prev_value)
                    {
                        prev_value = current_value;

                        try
                        {
                            MySqlConnection conexao = new MySqlConnection(connectionString);
                            conexao.Open();
                            string SN = $"SN{prev_value.ToString("D6")}";
                            string query = $"INSERT INTO registro_producao (SN) VALUES ('{SN}')";
                            MySqlCommand cmd = new MySqlCommand(query, conexao);
                            int linhasAfetadas  = cmd.ExecuteNonQuery();
                            if(linhasAfetadas != 0)
                            {
                                lblInfo.Invoke((MethodInvoker)(() => lblInfo.Text = $"PRODUTO {SN} REGISTRADO COM SUCESSO"));
                            }
                            conexao.Close();

                        }catch(Exception ex)
                        {
                            MessageBox.Show("Erro:" + ex.Message);
                        }
                    }

                    
                    if (holdings[5] == 1)
                    {
                        //lblInfo.Invoke((MethodInvoker)(() => lblInfo.Text = "O SISTEMA ESTÉ EM FUNCIONAMENTO"));
                        //lblInfo.Invoke((MethodInvoker)(() => lblInfo.BackColor = Color.Green));
                    }
                    else
                    {
                        if (holdings[6] == 1)
                        {
                            //lblInfo.Invoke((MethodInvoker)(() => lblInfo.Text = "O SISTEMA ESTÁ EM EMERGÊNCIA"));
                            //lblInfo.Invoke((MethodInvoker)(() => lblInfo.BackColor = Color.Yellow));

                        }
                        else
                        {
                            //lblInfo.Invoke((MethodInvoker)(() => lblInfo.Text = "O SISTEMA ESTÉ DESLIGADO"));
                            //lblInfo.Invoke((MethodInvoker)(() => lblInfo.BackColor = Color.Red));
                        }
                       
                    }                    
                }
                catch
                {
                    lblInfo.Invoke((MethodInvoker)(() => lblInfo.Text = "Falha ao ler registradores"));
                    lblInfo.Invoke((MethodInvoker)(() => lblInfo.BackColor = Color.Red));                   
                }
                Thread.Sleep(300);
            }
        }

        private void Form1_Onclosing(object sender, FormClosingEventArgs e)
        {
            modbusClient.Disconnect();
            isModbusActive = false;
        }

        private void btnLiga_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleRegister(2, 1);
        }

        private void btnDesliga_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleRegister(3, 1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleRegister(4, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Width = Screen.PrimaryScreen.Bounds.Width;
            //this.Height = Screen.PrimaryScreen.Bounds.Height;
            //lblInfo.Text = this.Width.ToString() + "  " + this.Height.ToString();

            //// Definir a posição do formulário para o canto superior esquerdo da tela
            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
