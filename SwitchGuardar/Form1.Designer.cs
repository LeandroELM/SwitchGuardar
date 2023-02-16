namespace SwitchGuardar
{
    partial class Form1
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
            this.dvgdatos = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbotipoformato = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgdatos
            // 
            this.dvgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.lastname,
            this.phone});
            this.dvgdatos.Location = new System.Drawing.Point(136, 193);
            this.dvgdatos.Name = "dvgdatos";
            this.dvgdatos.Size = new System.Drawing.Size(341, 150);
            this.dvgdatos.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Apellido";
            this.lastname.Name = "lastname";
            // 
            // phone
            // 
            this.phone.HeaderText = "Telefono";
            this.phone.Name = "phone";
            // 
            // cbotipoformato
            // 
            this.cbotipoformato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipoformato.FormattingEnabled = true;
            this.cbotipoformato.Items.AddRange(new object[] {
            "Excel",
            "PDF",
            "TXT"});
            this.cbotipoformato.Location = new System.Drawing.Point(223, 349);
            this.cbotipoformato.Name = "cbotipoformato";
            this.cbotipoformato.Size = new System.Drawing.Size(125, 21);
            this.cbotipoformato.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Formato:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbotipoformato);
            this.Controls.Add(this.dvgdatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgdatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.ComboBox cbotipoformato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

