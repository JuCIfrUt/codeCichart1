using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class FrmCalcularcompra : Form
    {
        double resultado, suma;

        public FrmCalcularcompra()
        {
            InitializeComponent();
        }

        public void LimpiarControles()
        {
            txtvalorproducto1.Text = "";
            txtvalorproducto2.Text = "";
            txtvalorproducto3.Text = "";
            txtvalorproducto4.Text = "";
            txtvalorproducto5.Text = "";
            txtcan1.Text = "";
            txtcan2.Text = "";
            txtcan3.Text = "";
            txtcan4.Text = "";
            txtcan5.Text = "";
            txtvalorproducto1.Focus();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public double CalcularCompra()
        {
            int can1, can2, can3, can4, can5;
            double valornumero1, valornumero2, valornumero3, valornumero4, valornumero5, resultado, opera, IVA;

            if (comboBox1.SelectedIndex == 0)
            {
                valornumero1 = double.Parse(txtvalorproducto1.Text);
                can1 = int.Parse(txtcan1.Text);

                opera = (valornumero1 * can1);
                IVA = (opera * 0.19);
                resultado = (opera - IVA);
                MessageBox.Show("El valor de la compra es: " + resultado.ToString());
            }
            else
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    valornumero1 = double.Parse(txtvalorproducto1.Text);
                    valornumero2 = double.Parse(txtvalorproducto2.Text);
                    can1 = int.Parse(txtcan1.Text);
                    can2 = int.Parse(txtcan2.Text);

                    opera = (valornumero1 * can1) + (valornumero2 * can2);
                    IVA = (opera * 0.19);
                    resultado = (opera - IVA);
                    MessageBox.Show("El valor de la compra es: " + resultado.ToString());
                }
                else
                {
                    if (comboBox1.SelectedIndex == 2)
                    {
                        valornumero1 = double.Parse(txtvalorproducto1.Text);
                        valornumero2 = double.Parse(txtvalorproducto2.Text);
                        valornumero3 = double.Parse(txtvalorproducto3.Text);
                        can1 = int.Parse(txtcan1.Text);
                        can2 = int.Parse(txtcan2.Text);
                        can3 = int.Parse(txtcan3.Text);

                        opera = (valornumero1 * can1) + (valornumero2 * can2) + (valornumero3 * can3);
                        IVA = (opera * 0.19);
                        resultado = (opera - IVA);
                        MessageBox.Show("El valor de la compra es: " + resultado.ToString());
                    }
                    else
                    {
                        if (comboBox1.SelectedIndex == 3)
                        {
                            valornumero1 = double.Parse(txtvalorproducto1.Text);
                            valornumero2 = double.Parse(txtvalorproducto2.Text);
                            valornumero3 = double.Parse(txtvalorproducto3.Text);
                            valornumero4 = double.Parse(txtvalorproducto4.Text);
                            can1 = int.Parse(txtcan1.Text);
                            can2 = int.Parse(txtcan2.Text);
                            can3 = int.Parse(txtcan3.Text);
                            can4 = int.Parse(txtcan4.Text);

                            opera = (valornumero1 * can1) + (valornumero2 * can2) + (valornumero3 * can3) + (valornumero4 * can4);
                            IVA = (opera * 0.19);
                            resultado = (opera - IVA);
                            MessageBox.Show("El valor de la compra es: " + resultado.ToString());
                        }
                        else
                        {
                            valornumero1 = double.Parse(txtvalorproducto1.Text);
                            valornumero2 = double.Parse(txtvalorproducto2.Text);
                            valornumero3 = double.Parse(txtvalorproducto3.Text);
                            valornumero4 = double.Parse(txtvalorproducto4.Text);
                            valornumero5 = double.Parse(txtvalorproducto5.Text);
                            can1 = int.Parse(txtcan1.Text);
                            can2 = int.Parse(txtcan2.Text);
                            can3 = int.Parse(txtcan3.Text);
                            can4 = int.Parse(txtcan4.Text);
                            can5 = int.Parse(txtcan5.Text);

                            opera = (valornumero1 * can1) + (valornumero2 * can2) + (valornumero3 * can3) + (valornumero4 * can4) + (valornumero5 * can5);
                            IVA = (opera * 0.19);
                            resultado = (opera - IVA);
                            MessageBox.Show("El valor de la compra es: " + resultado.ToString());
                        }
                    }
                }
            }
            return resultado; 
        }

        private void btncalcularcompra_Click(object sender, EventArgs e)
        {
            CalcularCompra();
        }

        private void txtvalorproducto1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtvalorproducto2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtvalorproducto3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtvalorproducto4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtvalorproducto5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtcan3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtcan2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcan1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtcan2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtcan3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtcan4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtcan5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                txtvalorproducto1.Enabled = true;
                lblproducto1.Enabled = true;
                txtcan1.Enabled = true;
                txtvalorproducto2.Enabled = false;
                lblproducto2.Enabled = false;
                txtcan2.Enabled = false;
                txtvalorproducto3.Enabled = false;
                lblproducto3.Enabled = false;
                txtcan3.Enabled = false;
                txtvalorproducto4.Enabled = false;
                lblproducto4.Enabled = false;
                txtcan4.Enabled = false;
                txtvalorproducto5.Enabled = false;
                lblproducto5.Enabled = false;
                txtcan5.Enabled = false;
            }
            else
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    txtvalorproducto1.Enabled = true;
                    lblproducto1.Enabled = true;
                    txtcan1.Enabled = true;
                    txtvalorproducto2.Enabled = true;
                    lblproducto2.Enabled = true;
                    txtcan2.Enabled = true;
                    txtvalorproducto3.Enabled = false;
                    lblproducto3.Enabled = false;
                    txtcan3.Enabled = false;
                    txtvalorproducto4.Enabled = false;
                    lblproducto4.Enabled = false;
                    txtcan4.Enabled = false;
                    txtvalorproducto5.Enabled = false;
                    lblproducto5.Enabled = false;
                    txtcan5.Enabled = false;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 2)
                    {
                        txtvalorproducto1.Enabled = true;
                        lblproducto1.Enabled = true;
                        txtcan1.Enabled = true;
                        txtvalorproducto2.Enabled = true;
                        lblproducto2.Enabled = true;
                        txtcan2.Enabled = true;
                        txtvalorproducto3.Enabled = true;
                        lblproducto3.Enabled = true;
                        txtcan3.Enabled = true;
                        txtvalorproducto4.Enabled = false;
                        lblproducto4.Enabled = false;
                        txtcan4.Enabled = false;
                        txtvalorproducto5.Enabled = false;
                        lblproducto5.Enabled = false;
                        txtcan5.Enabled = false; 
                    }
                    else
                    {
                        if (comboBox1.SelectedIndex == 3)
                        {
                            txtvalorproducto1.Enabled = true;
                            lblproducto1.Enabled = true;
                            txtcan1.Enabled = true;
                            txtvalorproducto2.Enabled = true;
                            lblproducto2.Enabled = true;
                            txtcan2.Enabled = true;
                            txtvalorproducto3.Enabled = true;
                            lblproducto3.Enabled = true;
                            txtcan3.Enabled = true;
                            txtvalorproducto4.Enabled = true;
                            lblproducto4.Enabled = true;
                            txtcan4.Enabled = true;
                            txtvalorproducto5.Enabled = false;
                            lblproducto5.Enabled = false;
                            txtcan5.Enabled = false;
                        }
                        else
                        {
                            if (comboBox1.SelectedIndex == 4)
                            {
                                txtvalorproducto1.Enabled = true;
                                lblproducto1.Enabled = true;
                                txtcan1.Enabled = true;
                                txtvalorproducto2.Enabled = true;
                                lblproducto2.Enabled = true;
                                txtcan2.Enabled = true;
                                txtvalorproducto3.Enabled = true;
                                lblproducto3.Enabled = true;
                                txtcan3.Enabled = true;
                                txtvalorproducto4.Enabled = true;
                                lblproducto4.Enabled = true;
                                txtcan4.Enabled = true;
                                txtvalorproducto5.Enabled = true;
                                lblproducto5.Enabled = true;
                                txtcan5.Enabled = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
