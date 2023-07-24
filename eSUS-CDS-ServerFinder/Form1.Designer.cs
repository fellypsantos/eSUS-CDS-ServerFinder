
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBox_MacAddress = new System.Windows.Forms.TextBox();
            this.Button_SaveSetting = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_OpenCDS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Logger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LinkLabel_TargetURL = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_MacAddress
            // 
            this.TextBox_MacAddress.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MacAddress.Location = new System.Drawing.Point(21, 41);
            this.TextBox_MacAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_MacAddress.Name = "TextBox_MacAddress";
            this.TextBox_MacAddress.Size = new System.Drawing.Size(256, 36);
            this.TextBox_MacAddress.TabIndex = 1;
            this.TextBox_MacAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button_SaveSetting
            // 
            this.Button_SaveSetting.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SaveSetting.Location = new System.Drawing.Point(21, 89);
            this.Button_SaveSetting.Margin = new System.Windows.Forms.Padding(4);
            this.Button_SaveSetting.Name = "Button_SaveSetting";
            this.Button_SaveSetting.Size = new System.Drawing.Size(257, 38);
            this.Button_SaveSetting.TabIndex = 2;
            this.Button_SaveSetting.Text = "Salvar Endereço MAC";
            this.Button_SaveSetting.UseVisualStyleBackColor = true;
            this.Button_SaveSetting.Click += new System.EventHandler(this.Button_SaveSetting_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBox_MacAddress);
            this.groupBox1.Controls.Add(this.Button_SaveSetting);
            this.groupBox1.Location = new System.Drawing.Point(24, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(299, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração de Rede";
            // 
            // Button_OpenCDS
            // 
            this.Button_OpenCDS.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_OpenCDS.Location = new System.Drawing.Point(24, 31);
            this.Button_OpenCDS.Margin = new System.Windows.Forms.Padding(4);
            this.Button_OpenCDS.Name = "Button_OpenCDS";
            this.Button_OpenCDS.Size = new System.Drawing.Size(299, 101);
            this.Button_OpenCDS.TabIndex = 0;
            this.Button_OpenCDS.Text = "Abrir e-SUS-CDS!";
            this.Button_OpenCDS.UseVisualStyleBackColor = true;
            this.Button_OpenCDS.Click += new System.EventHandler(this.Button_OpenCDS_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(20, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "finder.v1.2 - github.com/fellypsantos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_Logger
            // 
            this.TextBox_Logger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Logger.Location = new System.Drawing.Point(339, 158);
            this.TextBox_Logger.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Logger.Multiline = true;
            this.TextBox_Logger.Name = "TextBox_Logger";
            this.TextBox_Logger.Size = new System.Drawing.Size(371, 144);
            this.TextBox_Logger.TabIndex = 6;
            this.TextBox_Logger.Text = "Logs serão adicionados aqui...";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(335, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "fellypsantos2011@gmail.com";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LinkLabel_TargetURL);
            this.groupBox2.Location = new System.Drawing.Point(339, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(372, 101);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Link Gerado";
            // 
            // LinkLabel_TargetURL
            // 
            this.LinkLabel_TargetURL.Enabled = false;
            this.LinkLabel_TargetURL.Location = new System.Drawing.Point(7, 22);
            this.LinkLabel_TargetURL.Name = "LinkLabel_TargetURL";
            this.LinkLabel_TargetURL.Size = new System.Drawing.Size(358, 66);
            this.LinkLabel_TargetURL.TabIndex = 2;
            this.LinkLabel_TargetURL.TabStop = true;
            this.LinkLabel_TargetURL.Text = "aguardando endereço...";
            this.LinkLabel_TargetURL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkLabel_TargetURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_TargetURL_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Logger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_OpenCDS);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eSUS APS Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_MacAddress;
        private System.Windows.Forms.Button Button_SaveSetting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_OpenCDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Logger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LinkLabel_TargetURL;
    }
}

