namespace ContainerSchip
{
    partial class Form1
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
            this.HeightShiptext = new System.Windows.Forms.TextBox();
            this.LengthShiptext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContainerTypebox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lengthcontainertext = new System.Windows.Forms.TextBox();
            this.heightcontainertext = new System.Windows.Forms.TextBox();
            this.CreateShip = new System.Windows.Forms.Button();
            this.AddContainer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeightShiptext
            // 
            this.HeightShiptext.Location = new System.Drawing.Point(12, 31);
            this.HeightShiptext.Name = "HeightShiptext";
            this.HeightShiptext.Size = new System.Drawing.Size(100, 20);
            this.HeightShiptext.TabIndex = 0;
            // 
            // LengthShiptext
            // 
            this.LengthShiptext.Location = new System.Drawing.Point(12, 76);
            this.LengthShiptext.Name = "LengthShiptext";
            this.LengthShiptext.Size = new System.Drawing.Size(100, 20);
            this.LengthShiptext.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height Ship:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Length Ship:";
            // 
            // ContainerTypebox
            // 
            this.ContainerTypebox.Enabled = false;
            this.ContainerTypebox.FormattingEnabled = true;
            this.ContainerTypebox.Location = new System.Drawing.Point(12, 169);
            this.ContainerTypebox.Name = "ContainerTypebox";
            this.ContainerTypebox.Size = new System.Drawing.Size(100, 21);
            this.ContainerTypebox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Container Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Length Container:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Height Container:";
            // 
            // lengthcontainertext
            // 
            this.lengthcontainertext.Enabled = false;
            this.lengthcontainertext.Location = new System.Drawing.Point(12, 259);
            this.lengthcontainertext.Name = "lengthcontainertext";
            this.lengthcontainertext.Size = new System.Drawing.Size(100, 20);
            this.lengthcontainertext.TabIndex = 7;
            // 
            // heightcontainertext
            // 
            this.heightcontainertext.Enabled = false;
            this.heightcontainertext.Location = new System.Drawing.Point(12, 214);
            this.heightcontainertext.Name = "heightcontainertext";
            this.heightcontainertext.Size = new System.Drawing.Size(100, 20);
            this.heightcontainertext.TabIndex = 6;
            // 
            // CreateShip
            // 
            this.CreateShip.Location = new System.Drawing.Point(13, 111);
            this.CreateShip.Name = "CreateShip";
            this.CreateShip.Size = new System.Drawing.Size(99, 23);
            this.CreateShip.TabIndex = 10;
            this.CreateShip.Text = "Create";
            this.CreateShip.UseVisualStyleBackColor = true;
            this.CreateShip.Click += new System.EventHandler(this.CreateShip_Click);
            // 
            // AddContainer
            // 
            this.AddContainer.Location = new System.Drawing.Point(12, 294);
            this.AddContainer.Name = "AddContainer";
            this.AddContainer.Size = new System.Drawing.Size(99, 23);
            this.AddContainer.TabIndex = 11;
            this.AddContainer.Text = "Add";
            this.AddContainer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 345);
            this.Controls.Add(this.AddContainer);
            this.Controls.Add(this.CreateShip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lengthcontainertext);
            this.Controls.Add(this.heightcontainertext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContainerTypebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LengthShiptext);
            this.Controls.Add(this.HeightShiptext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HeightShiptext;
        private System.Windows.Forms.TextBox LengthShiptext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ContainerTypebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lengthcontainertext;
        private System.Windows.Forms.TextBox heightcontainertext;
        private System.Windows.Forms.Button CreateShip;
        private System.Windows.Forms.Button AddContainer;
    }
}

