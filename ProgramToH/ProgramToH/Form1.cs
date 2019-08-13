using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgramToH
{
    public partial class Form1 : Form
    {
        TextWriter config;
        public Form1()
        {
            InitializeComponent();
            //config = new StreamWriter("Config.h");

            //btnNew.Enabled = false;
            //tbArchivoName.Enabled = false;

            cbtipe.Enabled = false;
            cbtipe1.Enabled = false;
            cbtipe2.Enabled = false;
            cbtipe3.Enabled = false;

            btnAbrir.Enabled = false;
            btnAdd.Enabled = false;
            btnGuardar.Enabled = false;

            tbNumSig.Enabled = false;
            tbNumSig1.Enabled = false;
            tbNumSig2.Enabled = false;
            tbNumSig3.Enabled = false;

            tbVia.Enabled = false;
            tbVia1.Enabled = false;
            tbVia2.Enabled = false;
            tbVia3.Enabled = false;

            tbEst.Enabled = false;
            tbEst1.Enabled = false;
            tbEst2.Enabled = false;
            tbEst3.Enabled = false;

            tbPinV.Enabled = false;
            tbPinV1.Enabled = false;
            tbPinV2.Enabled = false;
            tbPinV3.Enabled = false;

            tbPinR.Enabled = false;
            tbPinR1.Enabled = false;
            tbPinR2.Enabled = false;
            tbPinR3.Enabled = false;

            tbPinA.Enabled = false;
            tbPinA1.Enabled = false;
            tbPinA2.Enabled = false;
            tbPinA3.Enabled = false;

            tbPinB.Enabled = false;
            tbPinB1.Enabled = false;
            tbPinB2.Enabled = false;
            tbPinB3.Enabled = false;

            dataGridView1.Enabled = false;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            TextReader readArchivo;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                readArchivo = new StreamReader(openFileDialog1.FileName);
                int num = dataGridView1.Rows.Add();
                string Linea = readArchivo.ReadLine();
                while(Linea != null)
                {
                    string str = readArchivo.ReadLine();
                    MessageBox.Show(str);
                    /*dataGridView1.Rows[num].Cells[0].Value = str[0];
                    dataGridView1.Rows[num].Cells[1].Value = str[1];
                    dataGridView1.Rows[num].Cells[2].Value = str[2];
                    dataGridView1.Rows[num].Cells[3].Value = str[3];
                    dataGridView1.Rows[num].Cells[4].Value = str[4];
                    dataGridView1.Rows[num].Cells[5].Value = str[5];
                    dataGridView1.Rows[num].Cells[6].Value = str[6];
                    dataGridView1.Rows[num].Cells[7].Value = str[7];*/
                    Linea = readArchivo.ReadLine();
                }
 
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog1.FileName = tbArchivoName.Text;
                config.Close();

                cbtipe.Enabled = false;
                cbtipe1.Enabled = false;
                cbtipe2.Enabled = false;
                cbtipe3.Enabled = false;

                btnAbrir.Enabled = true;
                btnAdd.Enabled = false;
                btnGuardar.Enabled = false;

                tbNumSig.Enabled = false;
                tbNumSig1.Enabled = false;
                tbNumSig2.Enabled = false;
                tbNumSig3.Enabled = false;

                tbVia.Enabled = false;
                tbVia1.Enabled = false;
                tbVia2.Enabled = false;
                tbVia3.Enabled = false;

                tbEst.Enabled = false;
                tbEst1.Enabled = false;
                tbEst2.Enabled = false;
                tbEst3.Enabled = false;

                tbPinV.Enabled = false;
                tbPinV1.Enabled = false;
                tbPinV2.Enabled = false;
                tbPinV3.Enabled = false;

                tbPinR.Enabled = false;
                tbPinR1.Enabled = false;
                tbPinR2.Enabled = false;
                tbPinR3.Enabled = false;

                tbPinA.Enabled = false;
                tbPinA1.Enabled = false;
                tbPinA2.Enabled = false;
                tbPinA3.Enabled = false;

                tbPinB.Enabled = false;
                tbPinB1.Enabled = false;
                tbPinB2.Enabled = false;
                tbPinB3.Enabled = false;

                btnNew.Enabled = true;
                tbArchivoName.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                config.WriteLine("signal[0]" + "{" + cbtipe.Text + "," + tbNumSig.Text + "," + tbVia.Text + "," + tbEst.Text + "," + tbPinA.Text + "," + tbPinR.Text + "," + tbPinA.Text + "," + tbPinB.Text + "};");
                config.WriteLine("signal[1]" + "{" + cbtipe1.Text + "," + tbNumSig1.Text + "," + tbVia1.Text + "," + tbEst1.Text + "," + tbPinA1.Text + "," + tbPinR1.Text + "," + tbPinA1.Text + "," + tbPinB1.Text + "};");
                config.WriteLine("signal[2]" + "{" + cbtipe2.Text + "," + tbNumSig2.Text + "," + tbVia2.Text + "," + tbEst2.Text + "," + tbPinA2.Text + "," + tbPinR2.Text + "," + tbPinA2.Text + "," + tbPinB2.Text + "};");
                config.WriteLine("signal[3]" + "{" + cbtipe3.Text + "," + tbNumSig3.Text + "," + tbVia3.Text + "," + tbEst3.Text + "," + tbPinA3.Text + "," + tbPinR3.Text + "," + tbPinA3.Text + "," + tbPinB3.Text + "};");
            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            config = new StreamWriter(tbArchivoName.Text + ".h");
            config.WriteLine("#include\"structs.h\"\n");

            cbtipe.Enabled = true;
            cbtipe1.Enabled = true;
            cbtipe2.Enabled = true;
            cbtipe3.Enabled = true;

            btnAbrir.Enabled = false;
            btnAdd.Enabled = true;
            btnGuardar.Enabled = true;

            tbNumSig.Enabled = true;
            tbNumSig1.Enabled = true;
            tbNumSig2.Enabled = true;
            tbNumSig3.Enabled = true;

            tbVia.Enabled = true;
            tbVia1.Enabled = true;
            tbVia2.Enabled = true;
            tbVia3.Enabled = true;

            tbEst.Enabled = true;
            tbEst1.Enabled = true;
            tbEst2.Enabled = true;
            tbEst3.Enabled = true;

            tbPinV.Enabled = true;
            tbPinV1.Enabled = true;
            tbPinV2.Enabled = true;
            tbPinV3.Enabled = true;

            tbPinR.Enabled = true;
            tbPinR1.Enabled = true;
            tbPinR2.Enabled = true;
            tbPinR3.Enabled = true;

            tbPinA.Enabled = true;
            tbPinA1.Enabled = true;
            tbPinA2.Enabled = true;
            tbPinA3.Enabled = true;

            tbPinB.Enabled = true;
            tbPinB1.Enabled = true;
            tbPinB2.Enabled = true;
            tbPinB3.Enabled = true;

            dataGridView1.Enabled = false;

            btnNew.Enabled = false;
            tbArchivoName.Enabled = false;
        }
    }
}
