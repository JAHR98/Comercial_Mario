
namespace devoluciones
{
    partial class frmdevolucion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdevolucion));
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.dtglista = new System.Windows.Forms.DataGridView();
            this.Nodevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtglista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(34, 53);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(125, 27);
            this.txtcodigo.TabIndex = 1;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::devoluciones.Properties.Resources.android_search_icon_icons_com_50501;
            this.btnbuscar.Location = new System.Drawing.Point(195, 45);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(48, 40);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Image = global::devoluciones.Properties.Resources.arrow_refresh_15732;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.Location = new System.Drawing.Point(510, 53);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(170, 29);
            this.btnactualizar.TabIndex = 3;
            this.btnactualizar.Text = "Actualizar Tabla";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // dtglista
            // 
            this.dtglista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nodevolucion,
            this.CodProveedor,
            this.CodProducto,
            this.Producto,
            this.Fecha});
            this.dtglista.Location = new System.Drawing.Point(12, 117);
            this.dtglista.Name = "dtglista";
            this.dtglista.RowHeadersWidth = 51;
            this.dtglista.RowTemplate.Height = 29;
            this.dtglista.Size = new System.Drawing.Size(668, 188);
            this.dtglista.TabIndex = 4;
            // 
            // Nodevolucion
            // 
            this.Nodevolucion.HeaderText = "No. Devolucion";
            this.Nodevolucion.MinimumWidth = 6;
            this.Nodevolucion.Name = "Nodevolucion";
            this.Nodevolucion.Width = 125;
            // 
            // CodProveedor
            // 
            this.CodProveedor.HeaderText = "codigo de Provedor";
            this.CodProveedor.MinimumWidth = 6;
            this.CodProveedor.Name = "CodProveedor";
            this.CodProveedor.Width = 125;
            // 
            // CodProducto
            // 
            this.CodProducto.HeaderText = "Codigo Producto";
            this.CodProducto.MinimumWidth = 6;
            this.CodProducto.Name = "CodProducto";
            this.CodProducto.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha Devolucion";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::devoluciones.Properties.Resources.Plus_36851;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.Location = new System.Drawing.Point(492, 354);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(188, 36);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Nueva devolusion";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // frmdevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dtglista);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdevolucion";
            this.Text = "Control de devoluciones";
            this.Load += new System.EventHandler(this.frmdevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.DataGridView dtglista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btnagregar;
    }
}

