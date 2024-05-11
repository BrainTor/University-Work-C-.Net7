namespace Kursach
{
    partial class add_data_form
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
            title = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            start = new Panel();
            delete = new Panel();
            add = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            label4 = new Label();
            numericUpDown3 = new NumericUpDown();
            button2 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            numericUpDown5 = new NumericUpDown();
            label7 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            numericUpDown4 = new NumericUpDown();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            start.SuspendLayout();
            delete.SuspendLayout();
            add.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.Font = new Font("Cascadia Mono", 15.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(776, 28);
            title.TabIndex = 0;
            title.Text = "label1";
            title.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(38, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(425, 183);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(215, 124);
            textBox1.Name = "mas_box";
            textBox1.PlaceholderText = "1,2,3,4";
            textBox1.Size = new Size(185, 25);
            textBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left;
            numericUpDown1.Location = new Point(215, 33);
            numericUpDown1.Name = "legth_box";
            numericUpDown1.Size = new Size(185, 25);
            numericUpDown1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.Font = new Font("Cascadia Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 123);
            label3.Name = "label3";
            label3.Size = new Size(206, 27);
            label3.TabIndex = 3;
            label3.Text = "Введите элементы через , ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(206, 24);
            label2.TabIndex = 0;
            label2.Text = "Введите размер массива";
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(171, 241);
            button1.Name = "but_start";
            button1.Size = new Size(182, 32);
            button1.TabIndex = 2;
            button1.Text = "Сохранить";
            button1.Click += sendData;
            button1.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            start.Controls.Add(tableLayoutPanel1);
            start.Controls.Add(button1);
            start.Location = new Point(158, 56);
            start.Name = "start";
            start.Size = new Size(503, 273);
            start.TabIndex = 3;
            start.Visible = false;
            // 
            // delete
            // 
            delete.Controls.Add(tableLayoutPanel4);
            delete.Controls.Add(button3);
            delete.Location = new Point(146, 77);
            delete.Name = "delete";
            delete.Size = new Size(512, 290);
            delete.TabIndex = 5;
            delete.Visible = false;
            // 
            // add
            // 
            add.Controls.Add(tableLayoutPanel2);
            add.Controls.Add(button2);
            add.Location = new Point(161, 40);
            add.Name = "add";
            add.Size = new Size(512, 290);
            add.TabIndex = 4;
            add.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(numericUpDown2, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(numericUpDown3, 1, 1);
            tableLayoutPanel2.Location = new Point(38, 37);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(425, 183);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Left;
            numericUpDown2.Location = new Point(215, 33);
            numericUpDown2.Name = "add_value_box";
            numericUpDown2.Size = new Size(185, 25);
            numericUpDown2.TabIndex = 2;

            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.Font = new Font("Cascadia Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 123);
            label1.Name = "label1";
            label1.Size = new Size(206, 27);
            label1.TabIndex = 3;
            label1.Text = "Введите значение ячейки";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 33);
            label4.Name = "label4";
            label4.Size = new Size(206, 24);
            label4.TabIndex = 0;
            label4.Text = "Введите номер ячейки";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.Left;
            numericUpDown3.Location = new Point(215, 124);
            numericUpDown3.Name = "add_number_box";
            numericUpDown3.Size = new Size(185, 25);
            numericUpDown3.TabIndex = 4;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(171, 241);
            button2.Name = "but_add";
            button2.Size = new Size(182, 32);
            button2.TabIndex = 2;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(numericUpDown5, 1, 0);
            tableLayoutPanel4.Controls.Add(label7, 0, 0);
            tableLayoutPanel4.Location = new Point(38, 37);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(425, 183);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Anchor = AnchorStyles.Left;
            numericUpDown5.Location = new Point(215, 79);
            numericUpDown5.Name = "delete_number_box";
            numericUpDown5.Size = new Size(185, 25);
            numericUpDown5.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 79);
            label7.Name = "label7";
            label7.Size = new Size(206, 24);
            label7.TabIndex = 0;
            label7.Text = "Введите номер ячейки";
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(171, 241);
            button3.Name = "but_delete";
            button3.Size = new Size(182, 32);
            button3.TabIndex = 2;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(numericUpDown4, 1, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Anchor = AnchorStyles.Left;
            numericUpDown4.Location = new Point(103, 38);
            numericUpDown4.Name = "delete_value_box";
            numericUpDown4.Size = new Size(94, 23);
            numericUpDown4.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.Font = new Font("Cascadia Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 51);
            label5.Name = "label5";
            label5.Size = new Size(206, 27);
            label5.TabIndex = 3;
            label5.Text = "Введите значение ячейки";
            // 
            // add_data_form
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(add);
            Controls.Add(delete);
            Controls.Add(start);
            Controls.Add(title);
            Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(238, 238, 238);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "add_data_form";
            Text = "add_data_form";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            start.ResumeLayout(false);
            delete.ResumeLayout(false);
            add.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label title;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button button1;
        private Panel start;
        private Panel add;
        private TableLayoutPanel tableLayoutPanel2;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private Label label4;
        private Button button2;
        private Panel delete;
        private TableLayoutPanel tableLayoutPanel4;
        private NumericUpDown numericUpDown5;
        private Label label7;
        private Button button3;
        private NumericUpDown numericUpDown3;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private NumericUpDown numericUpDown4;
        private Label label5;
    }
}