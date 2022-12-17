namespace TicketAutomatProjekt
{
    partial class TicketAutomatForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.button10cent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ticketTextBox = new System.Windows.Forms.TextBox();
            this.rueckgeldtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aktutextBox = new System.Windows.Forms.TextBox();
            this.benoetigtextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDrucken = new System.Windows.Forms.Button();
            this.button2eur = new System.Windows.Forms.Button();
            this.button1eur = new System.Windows.Forms.Button();
            this.button50cent = new System.Windows.Forms.Button();
            this.button20cent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "benötigtes Geld";
            // 
            // button10cent
            // 
            this.button10cent.Location = new System.Drawing.Point(6, 113);
            this.button10cent.Name = "button10cent";
            this.button10cent.Size = new System.Drawing.Size(75, 23);
            this.button10cent.TabIndex = 1;
            this.button10cent.Text = "10 cent";
            this.button10cent.UseVisualStyleBackColor = true;
            this.button10cent.Click += new System.EventHandler(this.button10cent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ticketTextBox);
            this.groupBox1.Controls.Add(this.rueckgeldtextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.aktutextBox);
            this.groupBox1.Controls.Add(this.benoetigtextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // ticketTextBox
            // 
            this.ticketTextBox.Location = new System.Drawing.Point(6, 139);
            this.ticketTextBox.Name = "ticketTextBox";
            this.ticketTextBox.Size = new System.Drawing.Size(264, 23);
            this.ticketTextBox.TabIndex = 6;
            // 
            // rueckgeldtextBox
            // 
            this.rueckgeldtextBox.Location = new System.Drawing.Point(117, 89);
            this.rueckgeldtextBox.Name = "rueckgeldtextBox";
            this.rueckgeldtextBox.Size = new System.Drawing.Size(100, 23);
            this.rueckgeldtextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rückgeld";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aktueller Standt";
            // 
            // aktutextBox
            // 
            this.aktutextBox.Location = new System.Drawing.Point(117, 56);
            this.aktutextBox.Name = "aktutextBox";
            this.aktutextBox.Size = new System.Drawing.Size(100, 23);
            this.aktutextBox.TabIndex = 2;
            // 
            // benoetigtextBox
            // 
            this.benoetigtextBox.Location = new System.Drawing.Point(117, 27);
            this.benoetigtextBox.Name = "benoetigtextBox";
            this.benoetigtextBox.Size = new System.Drawing.Size(100, 23);
            this.benoetigtextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDrucken);
            this.groupBox2.Controls.Add(this.button2eur);
            this.groupBox2.Controls.Add(this.button1eur);
            this.groupBox2.Controls.Add(this.button50cent);
            this.groupBox2.Controls.Add(this.button20cent);
            this.groupBox2.Controls.Add(this.button10cent);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 214);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eingabe";
            // 
            // buttonDrucken
            // 
            this.buttonDrucken.Location = new System.Drawing.Point(195, 161);
            this.buttonDrucken.Name = "buttonDrucken";
            this.buttonDrucken.Size = new System.Drawing.Size(75, 23);
            this.buttonDrucken.TabIndex = 6;
            this.buttonDrucken.Text = "Drucken";
            this.buttonDrucken.UseVisualStyleBackColor = true;
            this.buttonDrucken.Click += new System.EventHandler(this.buttonDrucken_Click);
            // 
            // button2eur
            // 
            this.button2eur.Location = new System.Drawing.Point(96, 161);
            this.button2eur.Name = "button2eur";
            this.button2eur.Size = new System.Drawing.Size(75, 23);
            this.button2eur.TabIndex = 5;
            this.button2eur.Text = "2€";
            this.button2eur.UseVisualStyleBackColor = true;
            this.button2eur.Click += new System.EventHandler(this.button2eur_Click);
            // 
            // button1eur
            // 
            this.button1eur.Location = new System.Drawing.Point(6, 161);
            this.button1eur.Name = "button1eur";
            this.button1eur.Size = new System.Drawing.Size(75, 23);
            this.button1eur.TabIndex = 4;
            this.button1eur.Text = "1€";
            this.button1eur.UseVisualStyleBackColor = true;
            this.button1eur.Click += new System.EventHandler(this.button1eur_Click);
            // 
            // button50cent
            // 
            this.button50cent.Location = new System.Drawing.Point(195, 113);
            this.button50cent.Name = "button50cent";
            this.button50cent.Size = new System.Drawing.Size(75, 23);
            this.button50cent.TabIndex = 3;
            this.button50cent.Text = "50 cent";
            this.button50cent.UseVisualStyleBackColor = true;
            this.button50cent.Click += new System.EventHandler(this.button50cent_Click);
            // 
            // button20cent
            // 
            this.button20cent.Location = new System.Drawing.Point(96, 113);
            this.button20cent.Name = "button20cent";
            this.button20cent.Size = new System.Drawing.Size(75, 23);
            this.button20cent.TabIndex = 2;
            this.button20cent.Text = "20 cent";
            this.button20cent.UseVisualStyleBackColor = true;
            this.button20cent.Click += new System.EventHandler(this.button20cent_Click);
            // 
            // TicketAutomatForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TicketAutomatForms";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button button10cent;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox aktutextBox;
        private TextBox benoetigtextBox;
        private GroupBox groupBox2;
        private TextBox rueckgeldtextBox;
        private Label label3;
        private Button buttonDrucken;
        private Button button2eur;
        private Button button1eur;
        private Button button50cent;
        private Button button20cent;
        private TextBox ticketTextBox;
    }
}