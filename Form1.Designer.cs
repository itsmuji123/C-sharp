namespace C__Assignment_01
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            checked_List = new CheckedListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 99);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 167);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 242);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 5;
            label3.Text = "Subjects:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(182, 362);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(137, 29);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Pre-requisite";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(182, 409);
            button1.Name = "button1";
            button1.Size = new Size(141, 54);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(644, 315);
            label4.Name = "label4";
            label4.Size = new Size(17, 25);
            label4.TabIndex = 9;
            label4.Text = " ";
            label4.Click += label4_Click;
            // 
            // checked_List
            // 
            checked_List.CheckOnClick = true;
            checked_List.FormattingEnabled = true;
            checked_List.Location = new Point(311, 224);
            checked_List.Name = "checked_List";
            checked_List.Size = new Size(223, 116);
            checked_List.TabIndex = 10;
            checked_List.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1041, 519);
            Controls.Add(checked_List);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private CheckBox checkBox1;
        private Button button1;
        private Label label4;
        private CheckedListBox checked_List;
    }
}