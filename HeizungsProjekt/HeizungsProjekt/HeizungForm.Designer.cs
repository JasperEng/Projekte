namespace HeizungsProjekt
{
    partial class HeizungForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.temperaturLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.setzenButton = new System.Windows.Forms.Button();
            this.schrittweiteTextBox = new System.Windows.Forms.TextBox();
            this.senkenButton = new System.Windows.Forms.Button();
            this.schrittweiteLabel = new System.Windows.Forms.Label();
            this.ErhoehenButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.temperaturLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anzeige";
            // 
            // temperaturLabel
            // 
            this.temperaturLabel.AutoSize = true;
            this.temperaturLabel.Location = new System.Drawing.Point(22, 40);
            this.temperaturLabel.Name = "temperaturLabel";
            this.temperaturLabel.Size = new System.Drawing.Size(95, 15);
            this.temperaturLabel.TabIndex = 0;
            this.temperaturLabel.Text = "Temperatur  0 °C";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.setzenButton);
            this.groupBox2.Controls.Add(this.schrittweiteTextBox);
            this.groupBox2.Controls.Add(this.senkenButton);
            this.groupBox2.Controls.Add(this.schrittweiteLabel);
            this.groupBox2.Controls.Add(this.ErhoehenButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eingabe";
            // 
            // setzenButton
            // 
            this.setzenButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.setzenButton.Location = new System.Drawing.Point(253, 38);
            this.setzenButton.Name = "setzenButton";
            this.setzenButton.Size = new System.Drawing.Size(75, 23);
            this.setzenButton.TabIndex = 4;
            this.setzenButton.Text = "setzen";
            this.setzenButton.UseVisualStyleBackColor = false;
            this.setzenButton.Click += new System.EventHandler(this.setzenButton_Click);
            // 
            // schrittweiteTextBox
            // 
            this.schrittweiteTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.schrittweiteTextBox.Location = new System.Drawing.Point(117, 39);
            this.schrittweiteTextBox.Name = "schrittweiteTextBox";
            this.schrittweiteTextBox.Size = new System.Drawing.Size(130, 23);
            this.schrittweiteTextBox.TabIndex = 3;
            // 
            // senkenButton
            // 
            this.senkenButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.senkenButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senkenButton.Location = new System.Drawing.Point(208, 82);
            this.senkenButton.Name = "senkenButton";
            this.senkenButton.Size = new System.Drawing.Size(103, 41);
            this.senkenButton.TabIndex = 2;
            this.senkenButton.Text = "-";
            this.senkenButton.UseVisualStyleBackColor = false;
            this.senkenButton.Click += new System.EventHandler(this.senkenButton_Click);
            // 
            // schrittweiteLabel
            // 
            this.schrittweiteLabel.AutoSize = true;
            this.schrittweiteLabel.Location = new System.Drawing.Point(28, 42);
            this.schrittweiteLabel.Name = "schrittweiteLabel";
            this.schrittweiteLabel.Size = new System.Drawing.Size(72, 15);
            this.schrittweiteLabel.TabIndex = 1;
            this.schrittweiteLabel.Text = "Schrittweite:";
            // 
            // ErhoehenButton
            // 
            this.ErhoehenButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ErhoehenButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErhoehenButton.Location = new System.Drawing.Point(66, 82);
            this.ErhoehenButton.Name = "ErhoehenButton";
            this.ErhoehenButton.Size = new System.Drawing.Size(103, 41);
            this.ErhoehenButton.TabIndex = 0;
            this.ErhoehenButton.Text = "+";
            this.ErhoehenButton.UseVisualStyleBackColor = false;
            this.ErhoehenButton.Click += new System.EventHandler(this.ErhoehenButton_Click);
            // 
            // HeizungForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 242);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HeizungForm";
            this.Text = "Heizung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label schrittweiteLabel;
        private Button ErhoehenButton;
        private Button senkenButton;
        private TextBox schrittweiteTextBox;
        private Label temperaturLabel;
        private Button setzenButton;
    }
}