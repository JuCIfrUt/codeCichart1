
namespace Ejercicio_1
{
    partial class FrmCalcularcompra
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNproducto = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblproducto1 = new System.Windows.Forms.Label();
            this.lblproducto2 = new System.Windows.Forms.Label();
            this.lblproducto3 = new System.Windows.Forms.Label();
            this.lblproducto4 = new System.Windows.Forms.Label();
            this.lblproducto5 = new System.Windows.Forms.Label();
            this.txtvalorproducto1 = new System.Windows.Forms.TextBox();
            this.txtvalorproducto2 = new System.Windows.Forms.TextBox();
            this.txtvalorproducto3 = new System.Windows.Forms.TextBox();
            this.txtvalorproducto4 = new System.Windows.Forms.TextBox();
            this.txtvalorproducto5 = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncalcularcompra = new System.Windows.Forms.Button();
            this.lblcantidadproductos = new System.Windows.Forms.Label();
            this.txtcan1 = new System.Windows.Forms.TextBox();
            this.txtcan2 = new System.Windows.Forms.TextBox();
            this.txtcan3 = new System.Windows.Forms.TextBox();
            this.txtcan4 = new System.Windows.Forms.TextBox();
            this.txtcan5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNproducto
            // 
            this.lblNproducto.AutoSize = true;
            this.lblNproducto.Location = new System.Drawing.Point(51, 86);
            this.lblNproducto.Name = "lblNproducto";
            this.lblNproducto.Size = new System.Drawing.Size(100, 18);
            this.lblNproducto.TabIndex = 0;
            this.lblNproducto.Text = "N° Productos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(200, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblproducto1
            // 
            this.lblproducto1.AutoSize = true;
            this.lblproducto1.Location = new System.Drawing.Point(51, 157);
            this.lblproducto1.Name = "lblproducto1";
            this.lblproducto1.Size = new System.Drawing.Size(84, 18);
            this.lblproducto1.TabIndex = 2;
            this.lblproducto1.Text = "Producto 1";
            // 
            // lblproducto2
            // 
            this.lblproducto2.AutoSize = true;
            this.lblproducto2.Location = new System.Drawing.Point(51, 213);
            this.lblproducto2.Name = "lblproducto2";
            this.lblproducto2.Size = new System.Drawing.Size(84, 18);
            this.lblproducto2.TabIndex = 3;
            this.lblproducto2.Text = "Producto 2";
            // 
            // lblproducto3
            // 
            this.lblproducto3.AutoSize = true;
            this.lblproducto3.Location = new System.Drawing.Point(51, 273);
            this.lblproducto3.Name = "lblproducto3";
            this.lblproducto3.Size = new System.Drawing.Size(84, 18);
            this.lblproducto3.TabIndex = 4;
            this.lblproducto3.Text = "Producto 3";
            // 
            // lblproducto4
            // 
            this.lblproducto4.AutoSize = true;
            this.lblproducto4.Location = new System.Drawing.Point(51, 331);
            this.lblproducto4.Name = "lblproducto4";
            this.lblproducto4.Size = new System.Drawing.Size(88, 18);
            this.lblproducto4.TabIndex = 5;
            this.lblproducto4.Text = "Producto 4 ";
            // 
            // lblproducto5
            // 
            this.lblproducto5.AutoSize = true;
            this.lblproducto5.Location = new System.Drawing.Point(51, 386);
            this.lblproducto5.Name = "lblproducto5";
            this.lblproducto5.Size = new System.Drawing.Size(84, 18);
            this.lblproducto5.TabIndex = 6;
            this.lblproducto5.Text = "Producto 5";
            // 
            // txtvalorproducto1
            // 
            this.txtvalorproducto1.Location = new System.Drawing.Point(200, 154);
            this.txtvalorproducto1.Name = "txtvalorproducto1";
            this.txtvalorproducto1.Size = new System.Drawing.Size(118, 26);
            this.txtvalorproducto1.TabIndex = 7;
            this.txtvalorproducto1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorproducto1_KeyPress);
            // 
            // txtvalorproducto2
            // 
            this.txtvalorproducto2.Location = new System.Drawing.Point(200, 210);
            this.txtvalorproducto2.Name = "txtvalorproducto2";
            this.txtvalorproducto2.Size = new System.Drawing.Size(118, 26);
            this.txtvalorproducto2.TabIndex = 8;
            this.txtvalorproducto2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorproducto2_KeyPress);
            // 
            // txtvalorproducto3
            // 
            this.txtvalorproducto3.Location = new System.Drawing.Point(200, 270);
            this.txtvalorproducto3.Name = "txtvalorproducto3";
            this.txtvalorproducto3.Size = new System.Drawing.Size(118, 26);
            this.txtvalorproducto3.TabIndex = 9;
            this.txtvalorproducto3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorproducto3_KeyPress);
            // 
            // txtvalorproducto4
            // 
            this.txtvalorproducto4.Location = new System.Drawing.Point(200, 328);
            this.txtvalorproducto4.Name = "txtvalorproducto4";
            this.txtvalorproducto4.Size = new System.Drawing.Size(118, 26);
            this.txtvalorproducto4.TabIndex = 10;
            this.txtvalorproducto4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorproducto4_KeyPress);
            // 
            // txtvalorproducto5
            // 
            this.txtvalorproducto5.Location = new System.Drawing.Point(200, 383);
            this.txtvalorproducto5.Name = "txtvalorproducto5";
            this.txtvalorproducto5.Size = new System.Drawing.Size(118, 26);
            this.txtvalorproducto5.TabIndex = 11;
            this.txtvalorproducto5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorproducto5_KeyPress);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Peru;
            this.btnsalir.Location = new System.Drawing.Point(348, 524);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(121, 39);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Peru;
            this.btnlimpiar.Location = new System.Drawing.Point(192, 524);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(123, 39);
            this.btnlimpiar.TabIndex = 13;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncalcularcompra
            // 
            this.btncalcularcompra.BackColor = System.Drawing.Color.Peru;
            this.btncalcularcompra.Location = new System.Drawing.Point(54, 524);
            this.btncalcularcompra.Name = "btncalcularcompra";
            this.btncalcularcompra.Size = new System.Drawing.Size(102, 39);
            this.btncalcularcompra.TabIndex = 14;
            this.btncalcularcompra.Text = "Calcular";
            this.btncalcularcompra.UseVisualStyleBackColor = false;
            this.btncalcularcompra.Click += new System.EventHandler(this.btncalcularcompra_Click);
            // 
            // lblcantidadproductos
            // 
            this.lblcantidadproductos.AutoSize = true;
            this.lblcantidadproductos.Location = new System.Drawing.Point(379, 119);
            this.lblcantidadproductos.Name = "lblcantidadproductos";
            this.lblcantidadproductos.Size = new System.Drawing.Size(72, 18);
            this.lblcantidadproductos.TabIndex = 15;
            this.lblcantidadproductos.Text = "Cantidad";
            // 
            // txtcan1
            // 
            this.txtcan1.Enabled = false;
            this.txtcan1.Location = new System.Drawing.Point(382, 154);
            this.txtcan1.Name = "txtcan1";
            this.txtcan1.Size = new System.Drawing.Size(68, 26);
            this.txtcan1.TabIndex = 16;
            this.txtcan1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcan1_KeyPress);
            // 
            // txtcan2
            // 
            this.txtcan2.Enabled = false;
            this.txtcan2.Location = new System.Drawing.Point(382, 210);
            this.txtcan2.Name = "txtcan2";
            this.txtcan2.Size = new System.Drawing.Size(68, 26);
            this.txtcan2.TabIndex = 17;
            this.txtcan2.TextChanged += new System.EventHandler(this.txtcan2_TextChanged);
            this.txtcan2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcan2_KeyPress);
            // 
            // txtcan3
            // 
            this.txtcan3.Enabled = false;
            this.txtcan3.Location = new System.Drawing.Point(382, 270);
            this.txtcan3.Name = "txtcan3";
            this.txtcan3.Size = new System.Drawing.Size(68, 26);
            this.txtcan3.TabIndex = 18;
            this.txtcan3.TextChanged += new System.EventHandler(this.txtcan3_TextChanged);
            this.txtcan3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcan3_KeyPress);
            // 
            // txtcan4
            // 
            this.txtcan4.Enabled = false;
            this.txtcan4.Location = new System.Drawing.Point(382, 328);
            this.txtcan4.Name = "txtcan4";
            this.txtcan4.Size = new System.Drawing.Size(68, 26);
            this.txtcan4.TabIndex = 19;
            this.txtcan4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcan4_KeyPress);
            // 
            // txtcan5
            // 
            this.txtcan5.Enabled = false;
            this.txtcan5.Location = new System.Drawing.Point(382, 386);
            this.txtcan5.Name = "txtcan5";
            this.txtcan5.Size = new System.Drawing.Size(68, 26);
            this.txtcan5.TabIndex = 20;
            this.txtcan5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcan5_KeyPress);
            // 
            // FrmCalcularcompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(647, 611);
            this.Controls.Add(this.txtcan5);
            this.Controls.Add(this.txtcan4);
            this.Controls.Add(this.txtcan3);
            this.Controls.Add(this.txtcan2);
            this.Controls.Add(this.txtcan1);
            this.Controls.Add(this.lblcantidadproductos);
            this.Controls.Add(this.btncalcularcompra);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtvalorproducto5);
            this.Controls.Add(this.txtvalorproducto4);
            this.Controls.Add(this.txtvalorproducto3);
            this.Controls.Add(this.txtvalorproducto2);
            this.Controls.Add(this.txtvalorproducto1);
            this.Controls.Add(this.lblproducto5);
            this.Controls.Add(this.lblproducto4);
            this.Controls.Add(this.lblproducto3);
            this.Controls.Add(this.lblproducto2);
            this.Controls.Add(this.lblproducto1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNproducto);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCalcularcompra";
            this.Text = "Calcular compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNproducto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblproducto1;
        private System.Windows.Forms.Label lblproducto2;
        private System.Windows.Forms.Label lblproducto3;
        private System.Windows.Forms.Label lblproducto4;
        private System.Windows.Forms.Label lblproducto5;
        private System.Windows.Forms.TextBox txtvalorproducto1;
        private System.Windows.Forms.TextBox txtvalorproducto2;
        private System.Windows.Forms.TextBox txtvalorproducto3;
        private System.Windows.Forms.TextBox txtvalorproducto4;
        private System.Windows.Forms.TextBox txtvalorproducto5;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncalcularcompra;
        private System.Windows.Forms.Label lblcantidadproductos;
        private System.Windows.Forms.TextBox txtcan1;
        private System.Windows.Forms.TextBox txtcan2;
        private System.Windows.Forms.TextBox txtcan3;
        private System.Windows.Forms.TextBox txtcan4;
        private System.Windows.Forms.TextBox txtcan5;
    }
}

