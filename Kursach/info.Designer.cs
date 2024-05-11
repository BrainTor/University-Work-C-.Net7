namespace Kursach
{
    partial class info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(info));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 22);
            label1.TabIndex = 0;
            label1.Text = "Название:\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono SemiBold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(702, 20);
            label2.TabIndex = 1;
            label2.Text = "Визуализация операций добавления и удаления по номеру отсортированном массиве";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 2;
            label3.Text = "Описание:";
            // 
            // label4
            // 
            label4.Font = new Font("Cascadia Mono SemiBold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(950, 500);
            label4.TabIndex = 3;
            label4.Text = resources.GetString("label4.Text");
            
            // 
            // info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(984, 661);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(238, 238, 238);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "info";
            Text = "info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}