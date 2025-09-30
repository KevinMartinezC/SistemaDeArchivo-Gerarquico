
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
            this.txtEstructura = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarArchivo = new System.Windows.Forms.Button();
            this.btnAgregarCarpeta = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRutaPadre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtRutaEliminar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnListarArchivos = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEstadisticas = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRutaAbsoluta = new System.Windows.Forms.Button();
            this.txtRutaAbsoluta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEstructura
            // 
            this.txtEstructura.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtEstructura.Location = new System.Drawing.Point(12, 40);
            this.txtEstructura.Multiline = true;
            this.txtEstructura.Name = "txtEstructura";
            this.txtEstructura.ReadOnly = true;
            this.txtEstructura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEstructura.Size = new System.Drawing.Size(400, 500);
            this.txtEstructura.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarArchivo);
            this.groupBox1.Controls.Add(this.btnAgregarCarpeta);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtRutaPadre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(430, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Elementos";
            // 
            // btnAgregarArchivo
            // 
            this.btnAgregarArchivo.Location = new System.Drawing.Point(160, 120);
            this.btnAgregarArchivo.Name = "btnAgregarArchivo";
            this.btnAgregarArchivo.Size = new System.Drawing.Size(120, 30);
            this.btnAgregarArchivo.TabIndex = 5;
            this.btnAgregarArchivo.Text = "Agregar Archivo";
            this.btnAgregarArchivo.UseVisualStyleBackColor = true;
            this.btnAgregarArchivo.Click += new System.EventHandler(this.btnAgregarArchivo_Click);
            // 
            // btnAgregarCarpeta
            // 
            this.btnAgregarCarpeta.Location = new System.Drawing.Point(20, 120);
            this.btnAgregarCarpeta.Name = "btnAgregarCarpeta";
            this.btnAgregarCarpeta.Size = new System.Drawing.Size(120, 30);
            this.btnAgregarCarpeta.TabIndex = 4;
            this.btnAgregarCarpeta.Text = "Agregar Carpeta";
            this.btnAgregarCarpeta.UseVisualStyleBackColor = true;
            this.btnAgregarCarpeta.Click += new System.EventHandler(this.btnAgregarCarpeta_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // txtRutaPadre
            // 
            this.txtRutaPadre.Location = new System.Drawing.Point(100, 40);
            this.txtRutaPadre.Name = "txtRutaPadre";
            this.txtRutaPadre.Size = new System.Drawing.Size(180, 23);
            this.txtRutaPadre.TabIndex = 2;
            this.txtRutaPadre.Text = "/root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta Padre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(430, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(200, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(80, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 23);
            this.txtBuscar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Término:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.txtRutaEliminar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(430, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 90);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(200, 50);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 25);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtRutaEliminar
            // 
            this.txtRutaEliminar.Location = new System.Drawing.Point(60, 30);
            this.txtRutaEliminar.Name = "txtRutaEliminar";
            this.txtRutaEliminar.Size = new System.Drawing.Size(220, 23);
            this.txtRutaEliminar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ruta:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnListarArchivos);
            this.groupBox4.Controls.Add(this.btnBFS);
            this.groupBox4.Controls.Add(this.btnPostOrden);
            this.groupBox4.Controls.Add(this.btnPreOrden);
            this.groupBox4.Location = new System.Drawing.Point(750, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 180);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recorridos";
            // 
            // btnListarArchivos
            // 
            this.btnListarArchivos.Location = new System.Drawing.Point(20, 135);
            this.btnListarArchivos.Name = "btnListarArchivos";
            this.btnListarArchivos.Size = new System.Drawing.Size(180, 30);
            this.btnListarArchivos.TabIndex = 3;
            this.btnListarArchivos.Text = "Listar Archivos";
            this.btnListarArchivos.UseVisualStyleBackColor = true;
            this.btnListarArchivos.Click += new System.EventHandler(this.btnListarArchivos_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.Location = new System.Drawing.Point(20, 100);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(180, 30);
            this.btnBFS.TabIndex = 2;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.Location = new System.Drawing.Point(20, 65);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(180, 30);
            this.btnPostOrden.TabIndex = 1;
            this.btnPostOrden.Text = "Post-Orden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(20, 30);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(180, 30);
            this.btnPreOrden.TabIndex = 0;
            this.btnPreOrden.Text = "Pre-Orden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtResultado.Location = new System.Drawing.Point(750, 250);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(220, 240);
            this.txtResultado.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estructura del Sistema";
            // 
            // lblEstadisticas
            // 
            this.lblEstadisticas.AutoSize = true;
            this.lblEstadisticas.Location = new System.Drawing.Point(12, 550);
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Size = new System.Drawing.Size(73, 15);
            this.lblEstadisticas.TabIndex = 7;
            this.lblEstadisticas.Text = "Estadisticas...";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRutaAbsoluta);
            this.groupBox5.Controls.Add(this.txtRutaAbsoluta);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(430, 410);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 90);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Información";
            // 
            // btnRutaAbsoluta
            // 
            this.btnRutaAbsoluta.Location = new System.Drawing.Point(180, 50);
            this.btnRutaAbsoluta.Name = "btnRutaAbsoluta";
            this.btnRutaAbsoluta.Size = new System.Drawing.Size(100, 25);
            this.btnRutaAbsoluta.TabIndex = 2;
            this.btnRutaAbsoluta.Text = "Ver Info";
            this.btnRutaAbsoluta.UseVisualStyleBackColor = true;
            this.btnRutaAbsoluta.Click += new System.EventHandler(this.btnRutaAbsoluta_Click);
            // 
            // txtRutaAbsoluta
            // 
            this.txtRutaAbsoluta.Location = new System.Drawing.Point(60, 30);
            this.txtRutaAbsoluta.Name = "txtRutaAbsoluta";
            this.txtRutaAbsoluta.Size = new System.Drawing.Size(220, 23);
            this.txtRutaAbsoluta.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ruta:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(750, 500);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(430, 510);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(300, 35);
            this.btnReiniciar.TabIndex = 10;
            this.btnReiniciar.Text = "Reiniciar Sistema";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblEstadisticas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEstructura);
            this.Name = "Form1";
            this.Text = "Sistema de Archivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}