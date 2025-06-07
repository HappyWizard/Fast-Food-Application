namespace FastFoodApp
{
    partial class FirstCustomerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstCustomerControl));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 27);
            label1.TabIndex = 0;
            label1.Text = "Only";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(39, 49);
            label2.Name = "label2";
            label2.Size = new Size(298, 155);
            label2.TabIndex = 0;
            label2.Text = "$19";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(71, 204);
            label3.Name = "label3";
            label3.Size = new Size(277, 44);
            label3.TabIndex = 0;
            label3.Text = "Cheeseburger";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(71, 303);
            label4.Name = "label4";
            label4.Size = new Size(958, 180);
            label4.TabIndex = 0;
            label4.Text = resources.GetString("label4.Text");
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(71, 259);
            label5.Name = "label5";
            label5.Size = new Size(401, 29);
            label5.TabIndex = 0;
            label5.Text = "When life throw you a buger, Eat it !";
            label5.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(71, 503);
            button1.Name = "button1";
            button1.Size = new Size(262, 51);
            button1.TabIndex = 1;
            button1.Text = "Order Now";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(500, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(539, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FirstCustomerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FirstCustomerControl";
            Size = new Size(1076, 572);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
