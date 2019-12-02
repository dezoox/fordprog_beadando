namespace KifejezesKiertekelo
{
    partial class MainForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox_expression = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_steps = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_basicExpression = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_restart = new System.Windows.Forms.Button();
            this.button_openFile = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(22, 69);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(623, 411);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SizeChanged += new System.EventHandler(this.dataGridView_SizeChanged);
            // 
            // textBox_expression
            // 
            this.textBox_expression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_expression.Location = new System.Drawing.Point(22, 31);
            this.textBox_expression.Name = "textBox_expression";
            this.textBox_expression.Size = new System.Drawing.Size(255, 20);
            this.textBox_expression.TabIndex = 1;
            this.textBox_expression.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Előállított kifejezés:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eredmény:";
            // 
            // textBox_result
            // 
            this.textBox_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_result.Location = new System.Drawing.Point(466, 500);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(179, 20);
            this.textBox_result.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lépések";
            // 
            // richTextBox_steps
            // 
            this.richTextBox_steps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_steps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_steps.Location = new System.Drawing.Point(674, 70);
            this.richTextBox_steps.Name = "richTextBox_steps";
            this.richTextBox_steps.Size = new System.Drawing.Size(265, 410);
            this.richTextBox_steps.TabIndex = 7;
            this.richTextBox_steps.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alap kifejezés:";
            // 
            // textBox_basicExpression
            // 
            this.textBox_basicExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_basicExpression.Location = new System.Drawing.Point(451, 31);
            this.textBox_basicExpression.Name = "textBox_basicExpression";
            this.textBox_basicExpression.Size = new System.Drawing.Size(141, 20);
            this.textBox_basicExpression.TabIndex = 9;
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Location = new System.Drawing.Point(674, 486);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(145, 23);
            this.button_start.TabIndex = 10;
            this.button_start.Text = "Kiértékel";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_restart
            // 
            this.button_restart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_restart.Location = new System.Drawing.Point(825, 486);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(114, 23);
            this.button_restart.TabIndex = 11;
            this.button_restart.Text = "Újraindít";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // button_openFile
            // 
            this.button_openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_openFile.Location = new System.Drawing.Point(22, 493);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(95, 23);
            this.button_openFile.TabIndex = 12;
            this.button_openFile.Text = "Fájl megnyitás";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // button_export
            // 
            this.button_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_export.Location = new System.Drawing.Point(280, 497);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(117, 23);
            this.button_export.TabIndex = 13;
            this.button_export.Text = "Táblázat exportálása";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 556);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_openFile);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_basicExpression);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox_steps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_expression);
            this.Controls.Add(this.dataGridView);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.Text = "Kiertekelo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox_expression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_steps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_basicExpression;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.Button button_export;
    }
}

