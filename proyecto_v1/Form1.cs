using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Server=10.12.205.193,1433;Database=CFP;trusted_Connection=true;");
                    con.Open();
                    String consulta = "INSERT INTO Alumnos (CUI, Edad, Genero, Telefono, Telefono_familiar, NIT, Correo, Direccion, Curso, Taller, Jornada, Estudia_ademas_de_estar_en_el_CFP, Nivel_de_estudio, Porque_decidio_escoger_una_carrera_tecnica, Continuara_estudios_formales, Dificultades_para_estudios_formales, Vehiculos_que_sabe_conducir, Idiomas, Con_quien_vive, Personas_que_dependen_de_el_o_ella, Vivienda, Vehiculos_propios, Licencia_de_conducir, Trabaja, Trabajo, Salario, Benificios, Le_gustaria_cambiar_de_trabajo, Comentario_sobre_el_CFP) " +
                        "VALUES (CUI, Edad, Genero, Telefono, Telefono_familiar, NIT, Correo, Direccion, Curso, Taller, Jornada, Estudia_ademas_de_estar_en_el_CFP, Nivel_de_estudio, Porque_decidio_escoger_una_carrera_tecnica, Continuara_estudios_formales, Dificultades_para_estudios_formales, Vehiculos_que_sabe_conducir, Idiomas, Con_quien_vive, Personas_que_dependen_de_el_o_ella, Vivienda, Vehiculos_propios, Licencia_de_conducir, Trabaja, Trabajo, Salario, Benificios, Le_gustaria_cambiar_de_trabajo, Comentario_sobre_el_CFP)";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(textBox2.Text));
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(comboBox1.Text));
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox4.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Persona agregado correctamente.");
                    //obtenerDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el Persona: " + ex.Message);
            }
        }
    }
    
}
