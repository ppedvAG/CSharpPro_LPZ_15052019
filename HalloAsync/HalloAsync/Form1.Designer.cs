namespace HalloAsync
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
            this.startOhneThreadMetroButton = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.starteTaskMetroButton = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.abbrechenMetroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // startOhneThreadMetroButton
            // 
            this.startOhneThreadMetroButton.AutoSize = true;
            this.startOhneThreadMetroButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startOhneThreadMetroButton.Location = new System.Drawing.Point(23, 75);
            this.startOhneThreadMetroButton.Name = "startOhneThreadMetroButton";
            this.startOhneThreadMetroButton.Size = new System.Drawing.Size(158, 30);
            this.startOhneThreadMetroButton.TabIndex = 0;
            this.startOhneThreadMetroButton.Text = "Start ohne Threading";
            this.startOhneThreadMetroButton.UseSelectable = true;
            this.startOhneThreadMetroButton.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(23, 298);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(250, 23);
            this.metroProgressBar1.TabIndex = 1;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(444, 89);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(213, 154);
            this.metroProgressSpinner1.Speed = 2F;
            this.metroProgressSpinner1.TabIndex = 2;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // starteTaskMetroButton
            // 
            this.starteTaskMetroButton.AutoSize = true;
            this.starteTaskMetroButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.starteTaskMetroButton.Location = new System.Drawing.Point(23, 130);
            this.starteTaskMetroButton.Name = "starteTaskMetroButton";
            this.starteTaskMetroButton.Size = new System.Drawing.Size(207, 30);
            this.starteTaskMetroButton.TabIndex = 3;
            this.starteTaskMetroButton.Text = "Starte Task (Method Invoker)";
            this.starteTaskMetroButton.UseSelectable = true;
            this.starteTaskMetroButton.Click += new System.EventHandler(this.StarteTaskMetroButton_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSize = true;
            this.metroButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton1.Location = new System.Drawing.Point(23, 166);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(195, 30);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Starte Task (TaskScheduler)";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click_1);
            // 
            // abbrechenMetroButton2
            // 
            this.abbrechenMetroButton2.AutoSize = true;
            this.abbrechenMetroButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.abbrechenMetroButton2.Location = new System.Drawing.Point(264, 166);
            this.abbrechenMetroButton2.Name = "abbrechenMetroButton2";
            this.abbrechenMetroButton2.Size = new System.Drawing.Size(91, 30);
            this.abbrechenMetroButton2.TabIndex = 5;
            this.abbrechenMetroButton2.Text = "Abbrechen";
            this.abbrechenMetroButton2.UseSelectable = true;
            this.abbrechenMetroButton2.Click += new System.EventHandler(this.AbbrechenMetroButton2_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.AutoSize = true;
            this.metroButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton2.Location = new System.Drawing.Point(23, 237);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(140, 30);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Starte asnyc/await";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.AutoSize = true;
            this.metroButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton3.Location = new System.Drawing.Point(222, 224);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(121, 30);
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "asnyc/await DB";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.MetroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.AutoSize = true;
            this.metroButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton4.Location = new System.Drawing.Point(361, 249);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(106, 30);
            this.metroButton4.TabIndex = 8;
            this.metroButton4.Text = "Alte Funktion";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.MetroButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(566, 385);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.abbrechenMetroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.starteTaskMetroButton);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.startOhneThreadMetroButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Hallo Async";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton startOhneThreadMetroButton;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroButton starteTaskMetroButton;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton abbrechenMetroButton2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
    }
}

