namespace VELA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabellaDati = new System.Windows.Forms.DataGridView();
            this.numRighe = new System.Windows.Forms.NumericUpDown();
            this.numColonne = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreaTabella = new System.Windows.Forms.Button();
            this.messaggi = new System.Windows.Forms.TextBox();
            this.btnNordOvest = new System.Windows.Forms.Button();
            this.btnMinimiCosti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancellaMessaggi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabellaDati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRighe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColonne)).BeginInit();
            this.SuspendLayout();
            // 
            // tabellaDati
            // 
            this.tabellaDati.AllowUserToAddRows = false;
            this.tabellaDati.AllowUserToDeleteRows = false;
            this.tabellaDati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabellaDati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabellaDati.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tabellaDati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabellaDati.Location = new System.Drawing.Point(12, 116);
            this.tabellaDati.Name = "tabellaDati";
            this.tabellaDati.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabellaDati.RowTemplate.Height = 25;
            this.tabellaDati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tabellaDati.Size = new System.Drawing.Size(473, 317);
            this.tabellaDati.TabIndex = 0;
            this.tabellaDati.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.tabellaDati_EditingControlShowing);
            this.tabellaDati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabellaDati_KeyPress);
            // 
            // numRighe
            // 
            this.numRighe.Location = new System.Drawing.Point(12, 57);
            this.numRighe.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRighe.Name = "numRighe";
            this.numRighe.Size = new System.Drawing.Size(120, 23);
            this.numRighe.TabIndex = 1;
            this.numRighe.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numColonne
            // 
            this.numColonne.Location = new System.Drawing.Point(12, 28);
            this.numColonne.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numColonne.Name = "numColonne";
            this.numColonne.Size = new System.Drawing.Size(120, 23);
            this.numColonne.TabIndex = 2;
            this.numColonne.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Crea tabella";
            // 
            // btnCreaTabella
            // 
            this.btnCreaTabella.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreaTabella.ForeColor = System.Drawing.Color.Black;
            this.btnCreaTabella.Location = new System.Drawing.Point(12, 86);
            this.btnCreaTabella.Name = "btnCreaTabella";
            this.btnCreaTabella.Size = new System.Drawing.Size(120, 24);
            this.btnCreaTabella.TabIndex = 4;
            this.btnCreaTabella.Text = "Crea";
            this.btnCreaTabella.UseVisualStyleBackColor = true;
            this.btnCreaTabella.Click += new System.EventHandler(this.btnCreaTabella_Click);
            // 
            // messaggi
            // 
            this.messaggi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messaggi.BackColor = System.Drawing.Color.White;
            this.messaggi.Location = new System.Drawing.Point(491, 9);
            this.messaggi.Multiline = true;
            this.messaggi.Name = "messaggi";
            this.messaggi.ReadOnly = true;
            this.messaggi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messaggi.Size = new System.Drawing.Size(291, 424);
            this.messaggi.TabIndex = 5;
            // 
            // btnNordOvest
            // 
            this.btnNordOvest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNordOvest.ForeColor = System.Drawing.Color.Black;
            this.btnNordOvest.Location = new System.Drawing.Point(187, 28);
            this.btnNordOvest.Name = "btnNordOvest";
            this.btnNordOvest.Size = new System.Drawing.Size(120, 32);
            this.btnNordOvest.TabIndex = 6;
            this.btnNordOvest.Text = "Nord-Ovest";
            this.btnNordOvest.UseVisualStyleBackColor = true;
            this.btnNordOvest.Click += new System.EventHandler(this.btnNordOvest_Click);
            // 
            // btnMinimiCosti
            // 
            this.btnMinimiCosti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimiCosti.ForeColor = System.Drawing.Color.Black;
            this.btnMinimiCosti.Location = new System.Drawing.Point(187, 66);
            this.btnMinimiCosti.Name = "btnMinimiCosti";
            this.btnMinimiCosti.Size = new System.Drawing.Size(120, 32);
            this.btnMinimiCosti.TabIndex = 7;
            this.btnMinimiCosti.Text = "Minimi Costi";
            this.btnMinimiCosti.UseVisualStyleBackColor = true;
            this.btnMinimiCosti.Click += new System.EventHandler(this.btnMinimiCosti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Risolvi";
            // 
            // btnCancellaMessaggi
            // 
            this.btnCancellaMessaggi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancellaMessaggi.ForeColor = System.Drawing.Color.Black;
            this.btnCancellaMessaggi.Location = new System.Drawing.Point(334, 48);
            this.btnCancellaMessaggi.Name = "btnCancellaMessaggi";
            this.btnCancellaMessaggi.Size = new System.Drawing.Size(120, 32);
            this.btnCancellaMessaggi.TabIndex = 10;
            this.btnCancellaMessaggi.Text = "Pulisci";
            this.btnCancellaMessaggi.UseVisualStyleBackColor = true;
            this.btnCancellaMessaggi.Click += new System.EventHandler(this.btnCancellaMessaggi_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "VELA © - Valtrighe Eagles Logistic Agency";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(625, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "by Graziano Filippo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(794, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancellaMessaggi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMinimiCosti);
            this.Controls.Add(this.btnNordOvest);
            this.Controls.Add(this.messaggi);
            this.Controls.Add(this.btnCreaTabella);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numColonne);
            this.Controls.Add(this.numRighe);
            this.Controls.Add(this.tabellaDati);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(810, 500);
            this.Name = "Form1";
            this.Text = "VELA";
            ((System.ComponentModel.ISupportInitialize)(this.tabellaDati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRighe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tabellaDati;
        private NumericUpDown numRighe;
        private NumericUpDown numColonne;
        private Label label1;
        private Button btnCreaTabella;
        private TextBox messaggi;
        private Button btnNordOvest;
        private Button btnMinimiCosti;
        private Label label2;
        private Button btnCancellaMessaggi;
        private Label label4;
        private Label label3;
    }
}