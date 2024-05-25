using Laboratorio_final.data.datacces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Laboratorio_final.data.datacces.consolas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Laboratorio_final
{
    public partial class Form1 : Form
    {
        ConexionMySql Clscone = new ConexionMySql();
        model mdl = new model();
        List<model> todos;
        cursorclc cursor1 = new cursorclc();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            Clscone.Insertar(textBoxNombre.Text, textBoxCompañia.Text, dateTimePicker1.Value, int.Parse(textBoxGeneracion.Text));

        }
        private void MostrarRegistro()
        {
            if (cursor1.current >= 0 && cursor1.current < cursor1.totalRegistros)
            {
                model u = todos[cursor1.current];
                textBoxId.Text = u.id_Consola.ToString();
                textBoxNombre.Text = u.nombre_consola;
                textBoxCompañia.Text = u.compania;
                dateTimePicker1.Value = u.fecha_lanzamiento;
                textBoxGeneracion.Text = u.generacion.ToString();
            }
            cursor1.current++;
                if (cursor1.current >= cursor1.totalRegistros)
                {
                    cursor1.current = 0;
                    MessageBox.Show("Fin de los registros");
                }
            }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            MostrarRegistro();
        }
    }

 }

