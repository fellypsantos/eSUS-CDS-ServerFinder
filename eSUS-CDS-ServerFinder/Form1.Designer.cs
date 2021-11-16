
namespace eSUS_CDS_ServerFinder
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_MacAddress = new System.Windows.Forms.TextBox();
            this.Button_SaveSetting = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_OpenCDS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_MacAddress
            // 
            this.TextBox_MacAddress.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MacAddress.Location = new System.Drawing.Point(16, 33);
            this.TextBox_MacAddress.Name = "TextBox_MacAddress";
            this.TextBox_MacAddress.Size = new System.Drawing.Size(193, 31);
            this.TextBox_MacAddress.TabIndex = 1;
            this.TextBox_MacAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button_SaveSetting
            // 
            this.Button_SaveSetting.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SaveSetting.Location = new System.Drawing.Point(16, 72);
            this.Button_SaveSetting.Name = "Button_SaveSetting";
            this.Button_SaveSetting.Size = new System.Drawing.Size(193, 31);
            this.Button_SaveSetting.TabIndex = 2;
            this.Button_SaveSetting.Text = "Salvar Endereço MAC";
            this.Button_SaveSetting.UseVisualStyleBackColor = true;
            this.Button_SaveSetting.Click += new System.EventHandler(this.Button_SaveSetting_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBox_MacAddress);
            this.groupBox1.Controls.Add(this.Button_SaveSetting);
            this.groupBox1.Location = new System.Drawing.Point(15, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração de Rede";
            // 
            // Button_OpenCDS
            // 
            this.Button_OpenCDS.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_OpenCDS.Location = new System.Drawing.Point(15, 18);
            this.Button_OpenCDS.Name = "Button_OpenCDS";
            this.Button_OpenCDS.Size = new System.Drawing.Size(224, 77);
            this.Button_OpenCDS.TabIndex = 0;
            this.Button_OpenCDS.Text = "Abrir e-SUS-CDS!";
            this.Button_OpenCDS.UseVisualStyleBackColor = true;
            this.Button_OpenCDS.Click += new System.EventHandler(this.Button_OpenCDS_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(15, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "finder.v1.0 - github.com/fellypsantos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_OpenCDS);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "e-SUS-CDS-ServerFinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_MacAddress;
        private System.Windows.Forms.Button Button_SaveSetting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_OpenCDS;
        private System.Windows.Forms.Label label1;
    }
}

