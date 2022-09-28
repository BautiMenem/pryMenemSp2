namespace pryMenemCabaña
{
    partial class frmMain
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
            this.mrcTipo = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lstPersonas = new System.Windows.Forms.ComboBox();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.mrcAdi = new System.Windows.Forms.GroupBox();
            this.chkTele = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.mrcForma = new System.Windows.Forms.GroupBox();
            this.lstTarjetas = new System.Windows.Forms.ComboBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.mrcTitular = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblTele = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mrcTipo.SuspendLayout();
            this.mrcAdi.SuspendLayout();
            this.mrcForma.SuspendLayout();
            this.mrcTitular.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTipo
            // 
            this.mrcTipo.Controls.Add(this.txtDias);
            this.mrcTipo.Controls.Add(this.lblDias);
            this.mrcTipo.Controls.Add(this.lstPersonas);
            this.mrcTipo.Controls.Add(this.lblPersonas);
            this.mrcTipo.Controls.Add(this.lstTipo);
            this.mrcTipo.Controls.Add(this.lblTipo);
            this.mrcTipo.Location = new System.Drawing.Point(54, 38);
            this.mrcTipo.Name = "mrcTipo";
            this.mrcTipo.Size = new System.Drawing.Size(641, 100);
            this.mrcTipo.TabIndex = 0;
            this.mrcTipo.TabStop = false;
            this.mrcTipo.Text = "Tipo de Cabaña";
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Location = new System.Drawing.Point(526, 48);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(85, 20);
            this.txtDias.TabIndex = 5;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(475, 51);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 4;
            this.lblDias.Text = "Dias";
            // 
            // lstPersonas
            // 
            this.lstPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPersonas.Enabled = false;
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.Location = new System.Drawing.Point(311, 48);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(121, 21);
            this.lstPersonas.TabIndex = 3;
            this.lstPersonas.SelectedIndexChanged += new System.EventHandler(this.lstPersonas_SelectedIndexChanged);
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(254, 48);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblPersonas.TabIndex = 2;
            this.lblPersonas.Text = "Personas";
            // 
            // lstTipo
            // 
            this.lstTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Items.AddRange(new object[] {
            "Tipo A",
            "Tipo B"});
            this.lstTipo.Location = new System.Drawing.Point(79, 48);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(121, 21);
            this.lstTipo.TabIndex = 1;
            this.lstTipo.SelectedIndexChanged += new System.EventHandler(this.lstTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(37, 48);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // mrcAdi
            // 
            this.mrcAdi.Controls.Add(this.chkTele);
            this.mrcAdi.Controls.Add(this.chkHeladera);
            this.mrcAdi.Controls.Add(this.chkCocina);
            this.mrcAdi.Enabled = false;
            this.mrcAdi.Location = new System.Drawing.Point(54, 154);
            this.mrcAdi.Name = "mrcAdi";
            this.mrcAdi.Size = new System.Drawing.Size(188, 100);
            this.mrcAdi.TabIndex = 1;
            this.mrcAdi.TabStop = false;
            this.mrcAdi.Text = "Adicionales";
            // 
            // chkTele
            // 
            this.chkTele.AutoSize = true;
            this.chkTele.Location = new System.Drawing.Point(7, 80);
            this.chkTele.Name = "chkTele";
            this.chkTele.Size = new System.Drawing.Size(69, 17);
            this.chkTele.TabIndex = 2;
            this.chkTele.Text = "Televisor";
            this.chkTele.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(7, 57);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(69, 17);
            this.chkHeladera.TabIndex = 1;
            this.chkHeladera.Text = "Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(7, 34);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 0;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // mrcForma
            // 
            this.mrcForma.Controls.Add(this.lstTarjetas);
            this.mrcForma.Controls.Add(this.lblTarjeta);
            this.mrcForma.Controls.Add(this.optTarjeta);
            this.mrcForma.Controls.Add(this.optEfectivo);
            this.mrcForma.Enabled = false;
            this.mrcForma.Location = new System.Drawing.Point(264, 154);
            this.mrcForma.Name = "mrcForma";
            this.mrcForma.Size = new System.Drawing.Size(431, 100);
            this.mrcForma.TabIndex = 2;
            this.mrcForma.TabStop = false;
            this.mrcForma.Text = "Forma de Pago";
            this.mrcForma.Enter += new System.EventHandler(this.mrcForma_Enter);
            // 
            // lstTarjetas
            // 
            this.lstTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTarjetas.Enabled = false;
            this.lstTarjetas.FormattingEnabled = true;
            this.lstTarjetas.Items.AddRange(new object[] {
            "Card Red (Recargo 10%)",
            "Card Green (Recargo 20%)",
            "Card Blue (Recargo 20%)"});
            this.lstTarjetas.Location = new System.Drawing.Point(206, 53);
            this.lstTarjetas.Name = "lstTarjetas";
            this.lstTarjetas.Size = new System.Drawing.Size(195, 21);
            this.lstTarjetas.TabIndex = 3;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(203, 34);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(45, 13);
            this.lblTarjeta.TabIndex = 2;
            this.lblTarjeta.Text = "Tarjetas";
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(16, 58);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(58, 17);
            this.optTarjeta.TabIndex = 1;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            this.optTarjeta.CheckedChanged += new System.EventHandler(this.opTarjeta_CheckedChanged);
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Checked = true;
            this.optEfectivo.Location = new System.Drawing.Point(16, 34);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(64, 17);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // mrcTitular
            // 
            this.mrcTitular.Controls.Add(this.txtTel);
            this.mrcTitular.Controls.Add(this.txtNom);
            this.mrcTitular.Controls.Add(this.lblTele);
            this.mrcTitular.Controls.Add(this.lblNombre);
            this.mrcTitular.Location = new System.Drawing.Point(54, 290);
            this.mrcTitular.Name = "mrcTitular";
            this.mrcTitular.Size = new System.Drawing.Size(641, 100);
            this.mrcTitular.TabIndex = 3;
            this.mrcTitular.TabStop = false;
            this.mrcTitular.Text = "Titular de la Reserva";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(117, 63);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(494, 20);
            this.txtTel.TabIndex = 3;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(117, 29);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(494, 20);
            this.txtNom.TabIndex = 2;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblTele
            // 
            this.lblTele.AutoSize = true;
            this.lblTele.Location = new System.Drawing.Point(21, 63);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(54, 13);
            this.lblTele.TabIndex = 1;
            this.lblTele.Text = "Teléfonos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(645, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mrcTitular);
            this.Controls.Add(this.mrcForma);
            this.Controls.Add(this.mrcAdi);
            this.Controls.Add(this.mrcTipo);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Cabañas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcTipo.ResumeLayout(false);
            this.mrcTipo.PerformLayout();
            this.mrcAdi.ResumeLayout(false);
            this.mrcAdi.PerformLayout();
            this.mrcForma.ResumeLayout(false);
            this.mrcForma.PerformLayout();
            this.mrcTitular.ResumeLayout(false);
            this.mrcTitular.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTipo;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.ComboBox lstPersonas;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.ComboBox lstTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox mrcAdi;
        private System.Windows.Forms.CheckBox chkTele;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.GroupBox mrcForma;
        private System.Windows.Forms.ComboBox lstTarjetas;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.GroupBox mrcTitular;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblTele;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
    }
}

