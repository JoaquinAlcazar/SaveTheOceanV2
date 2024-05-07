namespace SaveTheOceanV2
{
    partial class Form3
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
            dataGridViewAnimal = new DataGridView();
            dataGridViewRescue = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRescue).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAnimal
            // 
            dataGridViewAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnimal.Location = new Point(62, 262);
            dataGridViewAnimal.Name = "dataGridViewAnimal";
            dataGridViewAnimal.Size = new Size(462, 59);
            dataGridViewAnimal.TabIndex = 1;
            dataGridViewAnimal.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewRescue
            // 
            dataGridViewRescue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRescue.Location = new Point(62, 119);
            dataGridViewRescue.Name = "dataGridViewRescue";
            dataGridViewRescue.Size = new Size(447, 60);
            dataGridViewRescue.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(62, 95);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 3;
            label1.Text = "Datos del rescate";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(62, 238);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 4;
            label2.Text = "Datos del animal";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(131, 368);
            button1.Name = "button1";
            button1.Size = new Size(101, 39);
            button1.TabIndex = 5;
            button1.Text = "Tratar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(337, 368);
            button2.Name = "button2";
            button2.Size = new Size(105, 39);
            button2.TabIndex = 6;
            button2.Text = "Trasladar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(496, 412);
            button3.Name = "button3";
            button3.Size = new Size(80, 26);
            button3.TabIndex = 7;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(145, 45);
            label3.Name = "label3";
            label3.Size = new Size(297, 30);
            label3.TabIndex = 8;
            label3.Text = "Hora de salvar a este animal!!";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 450);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewRescue);
            Controls.Add(dataGridViewAnimal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRescue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewAnimal;
        private DataGridView dataGridViewRescue;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}