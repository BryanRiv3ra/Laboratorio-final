namespace Laboratorio_final
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
            this.dataconsolas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonBuscarId = new System.Windows.Forms.Button();
            this.buttonInsertarmodel = new System.Windows.Forms.Button();
            this.buttonTodos = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxCompañia = new System.Windows.Forms.TextBox();
            this.textBoxGeneracion = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataconsolas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataconsolas
            // 
            this.dataconsolas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataconsolas.Location = new System.Drawing.Point(486, 68);
            this.dataconsolas.Name = "dataconsolas";
            this.dataconsolas.Size = new System.Drawing.Size(240, 150);
            this.dataconsolas.TabIndex = 0;
            this.dataconsolas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "BRYAN JOSUE RIVERA HERNANDEZ 0905-23-1623";
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(190, 79);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertar.TabIndex = 4;
            this.buttonInsertar.Text = "insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(190, 108);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarId
            // 
            this.buttonBuscarId.Location = new System.Drawing.Point(190, 150);
            this.buttonBuscarId.Name = "buttonBuscarId";
            this.buttonBuscarId.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarId.TabIndex = 6;
            this.buttonBuscarId.Text = "Buscar por id";
            this.buttonBuscarId.UseVisualStyleBackColor = true;
            // 
            // buttonInsertarmodel
            // 
            this.buttonInsertarmodel.Location = new System.Drawing.Point(215, 179);
            this.buttonInsertarmodel.Name = "buttonInsertarmodel";
            this.buttonInsertarmodel.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertarmodel.TabIndex = 7;
            this.buttonInsertarmodel.Text = "Insertar model";
            this.buttonInsertarmodel.UseVisualStyleBackColor = true;
            // 
            // buttonTodos
            // 
            this.buttonTodos.Location = new System.Drawing.Point(190, 208);
            this.buttonTodos.Name = "buttonTodos";
            this.buttonTodos.Size = new System.Drawing.Size(75, 23);
            this.buttonTodos.TabIndex = 8;
            this.buttonTodos.Text = "Todos";
            this.buttonTodos.UseVisualStyleBackColor = true;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(595, 278);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonCrear.TabIndex = 9;
            this.buttonCrear.Text = "insertar";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(63, 111);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 10;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(63, 82);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 11;
            // 
            // textBoxCompañia
            // 
            this.textBoxCompañia.Location = new System.Drawing.Point(63, 150);
            this.textBoxCompañia.Name = "textBoxCompañia";
            this.textBoxCompañia.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompañia.TabIndex = 12;
            // 
            // textBoxGeneracion
            // 
            this.textBoxGeneracion.Location = new System.Drawing.Point(63, 211);
            this.textBoxGeneracion.Name = "textBoxGeneracion";
            this.textBoxGeneracion.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeneracion.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 410);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxGeneracion);
            this.Controls.Add(this.textBoxCompañia);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonTodos);
            this.Controls.Add(this.buttonInsertarmodel);
            this.Controls.Add(this.buttonBuscarId);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataconsolas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataconsolas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataconsolas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonBuscarId;
        private System.Windows.Forms.Button buttonInsertarmodel;
        private System.Windows.Forms.Button buttonTodos;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxCompañia;
        private System.Windows.Forms.TextBox textBoxGeneracion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

