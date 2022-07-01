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

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }
        List<DateTime> fechas = new List<DateTime>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {      
            String nombre=null;
            String telefon=null;
            DateTime fecha;
            String numClie=null;
            int cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0;
            decimal grupo;
     
            grupo = numericUpDown1.Value;
   
            switch (grupo)
            {
                case 1: cont1++;
                    break;

                case 2: cont2++;
                    break;

                case 3: cont3++;
                    break;

                case 4: cont4++;
                    break;


            }
            if (cont1>4)
            {
                MessageBox.Show("Limite de integrantes del grupo "+1+" alcanzado! Seleccione otro grupo.");
            }
            else
            {
              
                nombre = textBox1.Text;
               
                telefon = textBox2.Text;
               
                numClie = textBox3.Text;

            }
            if (cont2>4)
            {
                MessageBox.Show("Limite de integrantes del grupo "+2+" alcanzado! Seleccione otro grupo.");
            }
            else
            {

                nombre = textBox1.Text;

                telefon = textBox2.Text;

                numClie = textBox3.Text;

            }
            if (cont3 > 4)
            {
                MessageBox.Show("Limite de integrantes del grupo "+3+" alcanzado! Seleccione otro grupo.");
            }
            else
            {

                nombre = textBox1.Text;

                telefon = textBox2.Text;

                numClie = textBox3.Text;


            }
            if (cont4 > 4)
            {
                MessageBox.Show("Limite de integrantes del grupo "+4+" alcanzado! Seleccione otro grupo.");
            }
            else
            {

                nombre = textBox1.Text;

                telefon = textBox2.Text;

                numClie = textBox3.Text;

            }
            

            

            StreamWriter escribir = new StreamWriter(@"C:\Users\augus\Desktop\turnos.txt", true);
           
            

            fecha = dateTimePicker1.Value;
            string fechastr = fecha.ToString("dd/MM/yyyy");

            if (fechas != null)
            {
                foreach (DateTime p in fechas)
                {

                    if (fechastr.Equals(p.ToString("dd/MM/yyyy")))
                    {

                        MessageBox.Show("Esta fecha coincide con otra fecha de otro grupo.");
                    }
                    else
                    {
                        fechas.Add(fecha);
                    }
                }
            }
            else
            {
                fechas.Add(fecha);
            }
            
            escribir.WriteLine(nombre+" "+telefon+" "+grupo+" "+fecha+" "+numClie+" ");
            escribir.Close();

            textBox1.Text=null;

            textBox2.Text=null;

            textBox3.Text=null;

            numericUpDown1.Value = 1;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\Users\augus\Desktop\turnos.txt");
            String linea;
            richTextBox1.Clear();
            linea = leer.ReadLine();
            while (linea!=null)
            {
                richTextBox1.AppendText(linea + "\n");
                linea = leer.ReadLine();
            }
            leer.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
