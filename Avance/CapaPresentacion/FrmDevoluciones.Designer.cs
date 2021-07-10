
namespace CapaPresentacion
{
    partial class FrmDevoluciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevoluciones));
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.tbCProducto = new System.Windows.Forms.TextBox();
            this.tbproveedor = new System.Windows.Forms.TextBox();
            this.tbrtn = new System.Windows.Forms.TextBox();
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbProd = new System.Windows.Forms.Label();
            this.lbProv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDevol = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 7;
            this.btnCancelar.ButtonText = "CANCELAR";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Iconimage")));
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 50D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(456, 359);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnCancelar.OnHovercolor = System.Drawing.Color.DarkRed;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(254, 74);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 7;
            this.btnGuardar.ButtonText = "GUARDAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 50D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(160, 359);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(254, 74);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(561, 154);
            this.tbProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(198, 26);
            this.tbProduct.TabIndex = 23;
            // 
            // tbCProducto
            // 
            this.tbCProducto.Location = new System.Drawing.Point(188, 266);
            this.tbCProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCProducto.Name = "tbCProducto";
            this.tbCProducto.Size = new System.Drawing.Size(198, 26);
            this.tbCProducto.TabIndex = 22;
            // 
            // tbproveedor
            // 
            this.tbproveedor.Location = new System.Drawing.Point(180, 154);
            this.tbproveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbproveedor.Name = "tbproveedor";
            this.tbproveedor.Size = new System.Drawing.Size(206, 26);
            this.tbproveedor.TabIndex = 21;
            this.tbproveedor.TextChanged += new System.EventHandler(this.tbnombre_TextChanged);
            // 
            // tbrtn
            // 
            this.tbrtn.Location = new System.Drawing.Point(222, 17);
            this.tbrtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbrtn.Name = "tbrtn";
            this.tbrtn.Size = new System.Drawing.Size(229, 26);
            this.tbrtn.TabIndex = 20;
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Location = new System.Drawing.Point(431, 160);
            this.lbProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(73, 20);
            this.lbProducto.TabIndex = 19;
            this.lbProducto.Text = "Producto";
            this.lbProducto.Click += new System.EventHandler(this.lbProducto_Click);
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Location = new System.Drawing.Point(32, 272);
            this.lbProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(127, 20);
            this.lbProd.TabIndex = 18;
            this.lbProd.Text = "Codigo Producto";
            this.lbProd.Click += new System.EventHandler(this.lbProd_Click);
            // 
            // lbProv
            // 
            this.lbProv.AutoSize = true;
            this.lbProv.Location = new System.Drawing.Point(32, 160);
            this.lbProv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProv.Name = "lbProv";
            this.lbProv.Size = new System.Drawing.Size(135, 20);
            this.lbProv.TabIndex = 17;
            this.lbProv.Text = "Codigo Proveedor";
            this.lbProv.Click += new System.EventHandler(this.lbProv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "RTN Proveedor";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 68);
            this.label1.TabIndex = 26;
            this.label1.Text = "DEVOLUCIONES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDevol
            // 
            this.lbDevol.AutoSize = true;
            this.lbDevol.Location = new System.Drawing.Point(431, 269);
            this.lbDevol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDevol.Name = "lbDevol";
            this.lbDevol.Size = new System.Drawing.Size(136, 20);
            this.lbDevol.TabIndex = 27;
            this.lbDevol.Text = "Fecha Devolucion";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(578, 257);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(209, 32);
            this.dtpFecha.TabIndex = 85;
            // 
            // FrmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lbDevol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbProduct);
            this.Controls.Add(this.tbCProducto);
            this.Controls.Add(this.tbproveedor);
            this.Controls.Add(this.tbrtn);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.lbProv);
            this.Controls.Add(this.label3);
            this.Name = "FrmDevoluciones";
            this.Load += new System.EventHandler(this.FrmDevoluciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        public System.Windows.Forms.TextBox tbProduct;
        public System.Windows.Forms.TextBox tbCProducto;
        public System.Windows.Forms.TextBox tbproveedor;
        public System.Windows.Forms.TextBox tbrtn;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.Label lbProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDevol;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}