namespace EMPRESAFD
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.textdocumento = new System.Windows.Forms.TextBox();
            this.textclave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ingrasar = new FontAwesome.Sharp.IconButton();
            this.cancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 274);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(23, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de Ventas";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(269, 299);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Teal;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconPictureBox1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 127;
            this.iconPictureBox1.Location = new System.Drawing.Point(42, 30);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(130, 127);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // textdocumento
            // 
            this.textdocumento.Location = new System.Drawing.Point(308, 42);
            this.textdocumento.Name = "textdocumento";
            this.textdocumento.Size = new System.Drawing.Size(195, 20);
            this.textdocumento.TabIndex = 4;
            this.textdocumento.Text = "document";
            // 
            // textclave
            // 
            this.textclave.Location = new System.Drawing.Point(308, 125);
            this.textclave.Name = "textclave";
            this.textclave.PasswordChar = '*';
            this.textclave.Size = new System.Drawing.Size(195, 20);
            this.textclave.TabIndex = 5;
            this.textclave.Text = "txtclave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero de Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña";
            // 
            // ingrasar
            // 
            this.ingrasar.BackColor = System.Drawing.Color.Teal;
            this.ingrasar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingrasar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingrasar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ingrasar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ingrasar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ingrasar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ingrasar.IconSize = 21;
            this.ingrasar.Location = new System.Drawing.Point(289, 215);
            this.ingrasar.Name = "ingrasar";
            this.ingrasar.Size = new System.Drawing.Size(92, 23);
            this.ingrasar.TabIndex = 8;
            this.ingrasar.Text = "Ingresar";
            this.ingrasar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ingrasar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ingrasar.UseVisualStyleBackColor = false;
            this.ingrasar.Click += new System.EventHandler(this.ingrasar_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.Red;
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.cancelar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelar.IconSize = 21;
            this.cancelar.Location = new System.Drawing.Point(406, 215);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(97, 23);
            this.cancelar.TabIndex = 9;
            this.cancelar.Text = "Cancelar";
            this.cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(539, 274);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.ingrasar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textclave);
            this.Controls.Add(this.textdocumento);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox textdocumento;
        private System.Windows.Forms.TextBox textclave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton ingrasar;
        private FontAwesome.Sharp.IconButton cancelar;
    }
}