using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Kursach
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
            menuStrip1 = new MenuStrip();
            переходПоСтраницамToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            начатьРаботуToolStripMenuItem = new ToolStripMenuItem();
            добавитьУдалитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
        
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 173, 181);
            menuStrip1.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ForeColor = Color.FromArgb(238, 238, 238);
            menuStrip1.Items.AddRange(new ToolStripItem[] { переходПоСтраницамToolStripMenuItem, toolStripMenuItem1, начатьРаботуToolStripMenuItem, добавитьУдалитьToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, удалитьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(984, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // переходПоСтраницамToolStripMenuItem
            // 
            переходПоСтраницамToolStripMenuItem.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            переходПоСтраницамToolStripMenuItem.Name = "переходПоСтраницамToolStripMenuItem";
            переходПоСтраницамToolStripMenuItem.Size = new Size(111, 29);
            переходПоСтраницамToolStripMenuItem.Text = "Информация";
            переходПоСтраницамToolStripMenuItem.Click += open_info;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 29);
            // 
            // начатьРаботуToolStripMenuItem
            // 
            начатьРаботуToolStripMenuItem.Name = "start";
            начатьРаботуToolStripMenuItem.Size = new Size(138, 29);
            начатьРаботуToolStripMenuItem.Text = "Начать работу";
            начатьРаботуToolStripMenuItem.Click += open_add;
            // 
            // добавитьУдалитьToolStripMenuItem
            // 
            добавитьУдалитьToolStripMenuItem.Name = "add";
            добавитьУдалитьToolStripMenuItem.Size = new Size(93, 29);
            добавитьУдалитьToolStripMenuItem.Text = "Добавить";
            добавитьУдалитьToolStripMenuItem.Click += open_add;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(45, 29);
            toolStripMenuItem2.Text = "🔁";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem3.Font = new Font("Cascadia Mono", 14F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(35, 29);
            toolStripMenuItem3.Text = "→";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem4.Font = new Font("Cascadia Mono", 14F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(35, 29);
            toolStripMenuItem4.Text = "←";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(12, 29);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "delete";
            удалитьToolStripMenuItem.Size = new Size(84, 29);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += open_add;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(110, 22);
            label1.TabIndex = 1;
            label1.Text = "Состояние:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 50);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Старт";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 16.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(165, 309);
            label3.Name = "label3";
            label3.Size = new Size(611, 29);
            label3.TabIndex = 3;
            label3.Text = "Данные не добавленны, добавьте для продолжения";
            // 
            // button1
            // 
 
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(984, 661);
           
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(238, 238, 238);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Курсовая работа";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem переходПоСтраницамToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem начатьРаботуToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem добавитьУдалитьToolStripMenuItem;
        private Label label1;
        private Label label3;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem удалитьToolStripMenuItem;
    
        public Label label2;
    }
}