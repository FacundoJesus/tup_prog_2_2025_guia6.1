using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DepartamentoVehicular depVehicular = new DepartamentoVehicular();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = Convert.ToInt32(tbDNI.Text);
                string nombre = tbNombre.Text;
                string patente = tbPatente.Text;

                Persona nuevaPersona = new Persona(dni, nombre);
                RegistroVehiculo nuevoRegistro = depVehicular.RegistrarVehiculo(nuevaPersona, patente);

                #region Limpio Campos
                tbNombre.Clear();
                tbDNI.Clear();
                tbPatente.Clear();
                #endregion

            }
            catch (RangoDniIncorrectoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatoPatenteNoValidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                FormVer formVer = new FormVer();

                formVer.lsbResultado.Items.Clear();
                for (int i = 0; i < depVehicular.CantidadRegistros; i++)
                {
                    formVer.lsbResultado.Items.Add(depVehicular.VerRegistro(i));
                }
                formVer.ShowDialog();
                formVer.Dispose();
            } catch (VerRegistroException ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
