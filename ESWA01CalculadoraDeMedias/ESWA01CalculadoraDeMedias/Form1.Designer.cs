namespace ESWA01CalculadoraDeMedias
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
            this.components = new System.ComponentModel.Container();
            this.status = new System.Windows.Forms.Label();
            this.label_NP1 = new System.Windows.Forms.Label();
            this.txt_NP1 = new System.Windows.Forms.TextBox();
            this.label_NP2 = new System.Windows.Forms.Label();
            this.txt_NP2 = new System.Windows.Forms.TextBox();
            this.label_PIM = new System.Windows.Forms.Label();
            this.txt_PIM = new System.Windows.Forms.TextBox();
            this.label_Sem = new System.Windows.Forms.Label();
            this.label_Calc_Sem = new System.Windows.Forms.Label();
            this.btn_Erase_Sem = new System.Windows.Forms.Button();
            this.btn_Calc_Sem = new System.Windows.Forms.Button();
            this.grpExam = new System.Windows.Forms.GroupBox();
            this.btn_Calc_Final = new System.Windows.Forms.Button();
            this.btn_Erase_Exam = new System.Windows.Forms.Button();
            this.label_Calc_Final = new System.Windows.Forms.Label();
            this.label_Nota_Exam = new System.Windows.Forms.Label();
            this.txt_Exam = new System.Windows.Forms.TextBox();
            this.label_Exame = new System.Windows.Forms.Label();
            this.timer_waiting = new System.Windows.Forms.Timer(this.components);
            this.grpExam.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(338, 9);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(122, 31);
            this.status.TabIndex = 0;
            this.status.Text = "STATUS";
            // 
            // label_NP1
            // 
            this.label_NP1.AutoSize = true;
            this.label_NP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NP1.Location = new System.Drawing.Point(97, 98);
            this.label_NP1.Name = "label_NP1";
            this.label_NP1.Size = new System.Drawing.Size(65, 25);
            this.label_NP1.TabIndex = 1;
            this.label_NP1.Text = "NP1: ";
            // 
            // txt_NP1
            // 
            this.txt_NP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NP1.Location = new System.Drawing.Point(168, 95);
            this.txt_NP1.Name = "txt_NP1";
            this.txt_NP1.Size = new System.Drawing.Size(404, 31);
            this.txt_NP1.TabIndex = 2;
            this.txt_NP1.Text = "0,0";
            this.txt_NP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NP1.TextChanged += new System.EventHandler(this.txt_NP1_TextChanged_1);
            // 
            // label_NP2
            // 
            this.label_NP2.AutoSize = true;
            this.label_NP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NP2.Location = new System.Drawing.Point(97, 148);
            this.label_NP2.Name = "label_NP2";
            this.label_NP2.Size = new System.Drawing.Size(65, 25);
            this.label_NP2.TabIndex = 3;
            this.label_NP2.Text = "NP2: ";
            // 
            // txt_NP2
            // 
            this.txt_NP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NP2.Location = new System.Drawing.Point(168, 145);
            this.txt_NP2.Name = "txt_NP2";
            this.txt_NP2.Size = new System.Drawing.Size(404, 31);
            this.txt_NP2.TabIndex = 4;
            this.txt_NP2.Text = "0,0";
            this.txt_NP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NP2.TextChanged += new System.EventHandler(this.txt_NP2_TextChanged_1);
            // 
            // label_PIM
            // 
            this.label_PIM.AutoSize = true;
            this.label_PIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PIM.Location = new System.Drawing.Point(97, 204);
            this.label_PIM.Name = "label_PIM";
            this.label_PIM.Size = new System.Drawing.Size(61, 25);
            this.label_PIM.TabIndex = 5;
            this.label_PIM.Text = "PIM: ";
            // 
            // txt_PIM
            // 
            this.txt_PIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PIM.Location = new System.Drawing.Point(168, 201);
            this.txt_PIM.Name = "txt_PIM";
            this.txt_PIM.Size = new System.Drawing.Size(404, 31);
            this.txt_PIM.TabIndex = 6;
            this.txt_PIM.Text = "0,0";
            this.txt_PIM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_PIM.TextChanged += new System.EventHandler(this.txt_PIM_TextChanged_1);
            // 
            // label_Sem
            // 
            this.label_Sem.AutoSize = true;
            this.label_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sem.Location = new System.Drawing.Point(56, 271);
            this.label_Sem.Name = "label_Sem";
            this.label_Sem.Size = new System.Drawing.Size(102, 24);
            this.label_Sem.TabIndex = 7;
            this.label_Sem.Text = "Semestral";
            // 
            // label_Calc_Sem
            // 
            this.label_Calc_Sem.AutoSize = true;
            this.label_Calc_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Calc_Sem.Location = new System.Drawing.Point(534, 271);
            this.label_Calc_Sem.Name = "label_Calc_Sem";
            this.label_Calc_Sem.Size = new System.Drawing.Size(38, 24);
            this.label_Calc_Sem.TabIndex = 8;
            this.label_Calc_Sem.Text = "0,0";
            // 
            // btn_Erase_Sem
            // 
            this.btn_Erase_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Erase_Sem.Location = new System.Drawing.Point(212, 319);
            this.btn_Erase_Sem.Name = "btn_Erase_Sem";
            this.btn_Erase_Sem.Size = new System.Drawing.Size(106, 33);
            this.btn_Erase_Sem.TabIndex = 9;
            this.btn_Erase_Sem.Text = "Limpar";
            this.btn_Erase_Sem.UseVisualStyleBackColor = true;
            this.btn_Erase_Sem.Click += new System.EventHandler(this.btn_Erase_Sem_Click_1);
            // 
            // btn_Calc_Sem
            // 
            this.btn_Calc_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calc_Sem.Location = new System.Drawing.Point(403, 319);
            this.btn_Calc_Sem.Name = "btn_Calc_Sem";
            this.btn_Calc_Sem.Size = new System.Drawing.Size(118, 33);
            this.btn_Calc_Sem.TabIndex = 10;
            this.btn_Calc_Sem.Text = "Semestral";
            this.btn_Calc_Sem.UseVisualStyleBackColor = true;
            this.btn_Calc_Sem.Click += new System.EventHandler(this.btn_Calc_Sem_Click_1);
            // 
            // grpExam
            // 
            this.grpExam.Controls.Add(this.btn_Calc_Final);
            this.grpExam.Controls.Add(this.btn_Erase_Exam);
            this.grpExam.Controls.Add(this.label_Calc_Final);
            this.grpExam.Controls.Add(this.label_Nota_Exam);
            this.grpExam.Controls.Add(this.txt_Exam);
            this.grpExam.Controls.Add(this.label_Exame);
            this.grpExam.Location = new System.Drawing.Point(60, 386);
            this.grpExam.Name = "grpExam";
            this.grpExam.Size = new System.Drawing.Size(523, 136);
            this.grpExam.TabIndex = 11;
            this.grpExam.TabStop = false;
            // 
            // btn_Calc_Final
            // 
            this.btn_Calc_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calc_Final.Location = new System.Drawing.Point(343, 96);
            this.btn_Calc_Final.Name = "btn_Calc_Final";
            this.btn_Calc_Final.Size = new System.Drawing.Size(118, 34);
            this.btn_Calc_Final.TabIndex = 5;
            this.btn_Calc_Final.Text = "Final";
            this.btn_Calc_Final.UseVisualStyleBackColor = true;
            this.btn_Calc_Final.Click += new System.EventHandler(this.btn_Calc_Final_Click_1);
            // 
            // btn_Erase_Exam
            // 
            this.btn_Erase_Exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Erase_Exam.Location = new System.Drawing.Point(152, 96);
            this.btn_Erase_Exam.Name = "btn_Erase_Exam";
            this.btn_Erase_Exam.Size = new System.Drawing.Size(106, 34);
            this.btn_Erase_Exam.TabIndex = 4;
            this.btn_Erase_Exam.Text = "Limpar";
            this.btn_Erase_Exam.UseVisualStyleBackColor = true;
            this.btn_Erase_Exam.Click += new System.EventHandler(this.btn_Erase_Exam_Click_1);
            // 
            // label_Calc_Final
            // 
            this.label_Calc_Final.AutoSize = true;
            this.label_Calc_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Calc_Final.Location = new System.Drawing.Point(474, 68);
            this.label_Calc_Final.Name = "label_Calc_Final";
            this.label_Calc_Final.Size = new System.Drawing.Size(38, 24);
            this.label_Calc_Final.TabIndex = 3;
            this.label_Calc_Final.Text = "0,0";
            // 
            // label_Nota_Exam
            // 
            this.label_Nota_Exam.AutoSize = true;
            this.label_Nota_Exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nota_Exam.Location = new System.Drawing.Point(42, 68);
            this.label_Nota_Exam.Name = "label_Nota_Exam";
            this.label_Nota_Exam.Size = new System.Drawing.Size(56, 24);
            this.label_Nota_Exam.TabIndex = 2;
            this.label_Nota_Exam.Text = "Final";
            // 
            // txt_Exam
            // 
            this.txt_Exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Exam.Location = new System.Drawing.Point(108, 13);
            this.txt_Exam.Name = "txt_Exam";
            this.txt_Exam.Size = new System.Drawing.Size(404, 31);
            this.txt_Exam.TabIndex = 1;
            this.txt_Exam.Text = "0,0";
            this.txt_Exam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Exam.TextChanged += new System.EventHandler(this.txt_Exam_TextChanged_1);
            // 
            // label_Exame
            // 
            this.label_Exame.AutoSize = true;
            this.label_Exame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exame.Location = new System.Drawing.Point(12, 16);
            this.label_Exame.Name = "label_Exame";
            this.label_Exame.Size = new System.Drawing.Size(90, 25);
            this.label_Exame.TabIndex = 0;
            this.label_Exame.Text = "Exame: ";
            // 
            // timer_waiting
            // 
            this.timer_waiting.Interval = 500;
            this.timer_waiting.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 550);
            this.Controls.Add(this.grpExam);
            this.Controls.Add(this.btn_Calc_Sem);
            this.Controls.Add(this.btn_Erase_Sem);
            this.Controls.Add(this.label_Calc_Sem);
            this.Controls.Add(this.label_Sem);
            this.Controls.Add(this.txt_PIM);
            this.Controls.Add(this.label_PIM);
            this.Controls.Add(this.txt_NP2);
            this.Controls.Add(this.label_NP2);
            this.Controls.Add(this.txt_NP1);
            this.Controls.Add(this.label_NP1);
            this.Controls.Add(this.status);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpExam.ResumeLayout(false);
            this.grpExam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label_NP1;
        private System.Windows.Forms.TextBox txt_NP1;
        private System.Windows.Forms.Label label_NP2;
        private System.Windows.Forms.TextBox txt_NP2;
        private System.Windows.Forms.Label label_PIM;
        private System.Windows.Forms.TextBox txt_PIM;
        private System.Windows.Forms.Label label_Sem;
        private System.Windows.Forms.Label label_Calc_Sem;
        private System.Windows.Forms.Button btn_Erase_Sem;
        private System.Windows.Forms.Button btn_Calc_Sem;
        private System.Windows.Forms.GroupBox grpExam;
        private System.Windows.Forms.TextBox txt_Exam;
        private System.Windows.Forms.Label label_Exame;
        private System.Windows.Forms.Button btn_Calc_Final;
        private System.Windows.Forms.Button btn_Erase_Exam;
        private System.Windows.Forms.Label label_Calc_Final;
        private System.Windows.Forms.Label label_Nota_Exam;
        private System.Windows.Forms.Timer timer_waiting;
    }
}

