
namespace SistemaDeArchivo_Gerarquico
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtEstructura = new TextBox();
            groupBox1 = new GroupBox();
            btnAgregarArchivo = new Button();
            btnAgregarCarpeta = new Button();
            txtNombre = new TextBox();
            txtRutaPadre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btnEliminar = new Button();
            txtRutaEliminar = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            btnListarArchivos = new Button();
            btnBFS = new Button();
            btnPostOrden = new Button();
            btnPreOrden = new Button();
            txtResultado = new TextBox();
            label5 = new Label();
            lblEstadisticas = new Label();
            groupBox5 = new GroupBox();
            btnRutaAbsoluta = new Button();
            txtRutaAbsoluta = new TextBox();
            label6 = new Label();
            btnLimpiar = new Button();
            btnReiniciar = new Button();
            pictureBox = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // txtEstructura
            // 
            txtEstructura.Font = new Font("Consolas", 10F);
            txtEstructura.Location = new Point(22, 85);
            txtEstructura.Margin = new Padding(6);
            txtEstructura.Multiline = true;
            txtEstructura.Name = "txtEstructura";
            txtEstructura.ReadOnly = true;
            txtEstructura.ScrollBars = ScrollBars.Vertical;
            txtEstructura.Size = new Size(739, 1062);
            txtEstructura.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregarArchivo);
            groupBox1.Controls.Add(btnAgregarCarpeta);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtRutaPadre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(799, 85);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(557, 341);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Elementos";
            // 
            // btnAgregarArchivo
            // 
            btnAgregarArchivo.Location = new Point(297, 256);
            btnAgregarArchivo.Margin = new Padding(6);
            btnAgregarArchivo.Name = "btnAgregarArchivo";
            btnAgregarArchivo.Size = new Size(223, 64);
            btnAgregarArchivo.TabIndex = 5;
            btnAgregarArchivo.Text = "Agregar Archivo";
            btnAgregarArchivo.UseVisualStyleBackColor = true;
            btnAgregarArchivo.Click += btnAgregarArchivo_Click;
            // 
            // btnAgregarCarpeta
            // 
            btnAgregarCarpeta.Location = new Point(37, 256);
            btnAgregarCarpeta.Margin = new Padding(6);
            btnAgregarCarpeta.Name = "btnAgregarCarpeta";
            btnAgregarCarpeta.Size = new Size(223, 64);
            btnAgregarCarpeta.TabIndex = 4;
            btnAgregarCarpeta.Text = "Agregar Carpeta";
            btnAgregarCarpeta.UseVisualStyleBackColor = true;
            btnAgregarCarpeta.Click += btnAgregarCarpeta_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(186, 171);
            txtNombre.Margin = new Padding(6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(331, 39);
            txtNombre.TabIndex = 3;
            // 
            // txtRutaPadre
            // 
            txtRutaPadre.Location = new Point(186, 85);
            txtRutaPadre.Margin = new Padding(6);
            txtRutaPadre.Name = "txtRutaPadre";
            txtRutaPadre.Size = new Size(331, 39);
            txtRutaPadre.TabIndex = 2;
            txtRutaPadre.Text = "/root";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 177);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 92);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 0;
            label1.Text = "Ruta Padre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtBuscar);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(799, 448);
            groupBox2.Margin = new Padding(6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6);
            groupBox2.Size = new Size(557, 192);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(371, 107);
            btnBuscar.Margin = new Padding(6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(149, 53);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(149, 64);
            txtBuscar.Margin = new Padding(6);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(368, 39);
            txtBuscar.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 70);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 0;
            label3.Text = "Término:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(txtRutaEliminar);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(799, 661);
            groupBox3.Margin = new Padding(6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(6);
            groupBox3.Size = new Size(557, 192);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(371, 107);
            btnEliminar.Margin = new Padding(6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 53);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtRutaEliminar
            // 
            txtRutaEliminar.Location = new Point(111, 64);
            txtRutaEliminar.Margin = new Padding(6);
            txtRutaEliminar.Name = "txtRutaEliminar";
            txtRutaEliminar.Size = new Size(405, 39);
            txtRutaEliminar.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 70);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 0;
            label4.Text = "Ruta:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnListarArchivos);
            groupBox4.Controls.Add(btnBFS);
            groupBox4.Controls.Add(btnPostOrden);
            groupBox4.Controls.Add(btnPreOrden);
            groupBox4.Location = new Point(1393, 85);
            groupBox4.Margin = new Padding(6);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(6);
            groupBox4.Size = new Size(409, 384);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Recorridos";
            // 
            // btnListarArchivos
            // 
            btnListarArchivos.Location = new Point(37, 288);
            btnListarArchivos.Margin = new Padding(6);
            btnListarArchivos.Name = "btnListarArchivos";
            btnListarArchivos.Size = new Size(334, 64);
            btnListarArchivos.TabIndex = 3;
            btnListarArchivos.Text = "Listar Archivos";
            btnListarArchivos.UseVisualStyleBackColor = true;
            btnListarArchivos.Click += btnListarArchivos_Click;
            // 
            // btnBFS
            // 
            btnBFS.Location = new Point(37, 213);
            btnBFS.Margin = new Padding(6);
            btnBFS.Name = "btnBFS";
            btnBFS.Size = new Size(334, 64);
            btnBFS.TabIndex = 2;
            btnBFS.Text = "BFS";
            btnBFS.UseVisualStyleBackColor = true;
            btnBFS.Click += btnBFS_Click;
            // 
            // btnPostOrden
            // 
            btnPostOrden.Location = new Point(37, 139);
            btnPostOrden.Margin = new Padding(6);
            btnPostOrden.Name = "btnPostOrden";
            btnPostOrden.Size = new Size(334, 64);
            btnPostOrden.TabIndex = 1;
            btnPostOrden.Text = "Post-Orden";
            btnPostOrden.UseVisualStyleBackColor = true;
            btnPostOrden.Click += btnPostOrden_Click;
            // 
            // btnPreOrden
            // 
            btnPreOrden.Location = new Point(37, 64);
            btnPreOrden.Margin = new Padding(6);
            btnPreOrden.Name = "btnPreOrden";
            btnPreOrden.Size = new Size(334, 64);
            btnPreOrden.TabIndex = 0;
            btnPreOrden.Text = "Pre-Orden";
            btnPreOrden.UseVisualStyleBackColor = true;
            btnPreOrden.Click += btnPreOrden_Click;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Consolas", 9F);
            txtResultado.Location = new Point(1393, 533);
            txtResultado.Margin = new Padding(6);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(405, 507);
            txtResultado.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(22, 32);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(268, 32);
            label5.TabIndex = 6;
            label5.Text = "Estructura del Sistema";
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Location = new Point(22, 1173);
            lblEstadisticas.Margin = new Padding(6, 0, 6, 0);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(148, 32);
            lblEstadisticas.TabIndex = 7;
            lblEstadisticas.Text = "Estadisticas...";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnRutaAbsoluta);
            groupBox5.Controls.Add(txtRutaAbsoluta);
            groupBox5.Controls.Add(label6);
            groupBox5.Location = new Point(799, 875);
            groupBox5.Margin = new Padding(6);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(6);
            groupBox5.Size = new Size(557, 192);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "Información";
            // 
            // btnRutaAbsoluta
            // 
            btnRutaAbsoluta.Location = new Point(334, 107);
            btnRutaAbsoluta.Margin = new Padding(6);
            btnRutaAbsoluta.Name = "btnRutaAbsoluta";
            btnRutaAbsoluta.Size = new Size(186, 53);
            btnRutaAbsoluta.TabIndex = 2;
            btnRutaAbsoluta.Text = "Ver Info";
            btnRutaAbsoluta.UseVisualStyleBackColor = true;
            btnRutaAbsoluta.Click += btnRutaAbsoluta_Click;
            // 
            // txtRutaAbsoluta
            // 
            txtRutaAbsoluta.Location = new Point(111, 64);
            txtRutaAbsoluta.Margin = new Padding(6);
            txtRutaAbsoluta.Name = "txtRutaAbsoluta";
            txtRutaAbsoluta.Size = new Size(405, 39);
            txtRutaAbsoluta.TabIndex = 1;
            txtRutaAbsoluta.TextChanged += txtRutaAbsoluta_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 70);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 32);
            label6.TabIndex = 0;
            label6.Text = "Ruta:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1393, 1067);
            btnLimpiar.Margin = new Padding(6);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(186, 64);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(799, 1088);
            btnReiniciar.Margin = new Padding(6);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(557, 75);
            btnReiniciar.TabIndex = 10;
            btnReiniciar.Text = "Reiniciar Sistema";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(1407, 555);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(342, 464);
            pictureBox.TabIndex = 11;
            pictureBox.TabStop = false;
            pictureBox.Tag = "pictureBox";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 1239);
            Controls.Add(pictureBox);
            Controls.Add(btnReiniciar);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox5);
            Controls.Add(lblEstadisticas);
            Controls.Add(label5);
            Controls.Add(txtResultado);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtEstructura);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Sistema de Archivos";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtEstructura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarArchivo;
        private System.Windows.Forms.Button btnAgregarCarpeta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRutaPadre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtRutaEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnListarArchivos;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEstadisticas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRutaAbsoluta;
        private System.Windows.Forms.TextBox txtRutaAbsoluta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnReiniciar;
        private PictureBox pictureBox;
    }
}