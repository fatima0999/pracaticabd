namespace EMPRESAFD
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.MenuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProvedores = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuAserca = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuario,
            this.MenuMantenedor,
            this.MenuVentas,
            this.MenuCompras,
            this.MenuClientes,
            this.MenuProvedores,
            this.MenuReportes,
            this.MenuAserca});
            this.menu.Location = new System.Drawing.Point(0, 46);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(1200, 75);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.AutoSize = false;
            this.MenuUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.MenuUsuario.IconColor = System.Drawing.Color.Black;
            this.MenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(80, 69);
            this.MenuUsuario.Text = "Usuario";
            this.MenuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuMantenedor
            // 
            this.MenuMantenedor.AutoSize = false;
            this.MenuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem2});
            this.MenuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.MenuMantenedor.IconColor = System.Drawing.Color.Black;
            this.MenuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuMantenedor.Name = "MenuMantenedor";
            this.MenuMantenedor.Size = new System.Drawing.Size(80, 69);
            this.MenuMantenedor.Text = "Mantenedo";
            this.MenuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.iconMenuItem1.Text = "Categoria";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.iconMenuItem2.Text = "Producto";
            // 
            // MenuVentas
            // 
            this.MenuVentas.AutoSize = false;
            this.MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.MenuVentas.IconColor = System.Drawing.Color.Black;
            this.MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(80, 69);
            this.MenuVentas.Text = "Ventas";
            this.MenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuCompras
            // 
            this.MenuCompras.AutoSize = false;
            this.MenuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.MenuCompras.IconColor = System.Drawing.Color.Black;
            this.MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(80, 69);
            this.MenuCompras.Text = "Compras";
            this.MenuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuClientes
            // 
            this.MenuClientes.AutoSize = false;
            this.MenuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MenuClientes.IconColor = System.Drawing.Color.Black;
            this.MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(80, 69);
            this.MenuClientes.Text = "Clientes";
            this.MenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuProvedores
            // 
            this.MenuProvedores.AutoSize = false;
            this.MenuProvedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.MenuProvedores.IconColor = System.Drawing.Color.Black;
            this.MenuProvedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProvedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProvedores.Name = "MenuProvedores";
            this.MenuProvedores.Size = new System.Drawing.Size(80, 69);
            this.MenuProvedores.Text = "Proveedores";
            this.MenuProvedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuReportes
            // 
            this.MenuReportes.AutoSize = false;
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.MenuReportes.IconColor = System.Drawing.Color.Black;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(80, 69);
            this.MenuReportes.Text = "Reportes";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuAserca
            // 
            this.MenuAserca.AutoSize = false;
            this.MenuAserca.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MenuAserca.IconColor = System.Drawing.Color.Black;
            this.MenuAserca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAserca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAserca.Name = "MenuAserca";
            this.MenuAserca.Size = new System.Drawing.Size(80, 69);
            this.MenuAserca.Text = "Acerca de ";
            this.MenuAserca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Teal;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1200, 46);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 121);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1200, 571);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(487, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(590, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "lblusu";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuMantenedor;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private FontAwesome.Sharp.IconMenuItem MenuProvedores;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem MenuAserca;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
    }
}

