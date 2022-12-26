namespace Bees_algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMinBound = new System.Windows.Forms.TextBox();
            this.textBoxMaxBound = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumScouts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFitnessFunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumElitePlace = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.textBoxNumElite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumWorkers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumGoodPlace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNumIter = new System.Windows.Forms.TextBox();
            this.textBoxMaxBoundNeighborhood = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMinBoundNeighborhood = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диапазон значений функции";
            // 
            // textBoxMinBound
            // 
            this.textBoxMinBound.Location = new System.Drawing.Point(623, 134);
            this.textBoxMinBound.Name = "textBoxMinBound";
            this.textBoxMinBound.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinBound.TabIndex = 1;
            this.textBoxMinBound.Text = "-100";
            // 
            // textBoxMaxBound
            // 
            this.textBoxMaxBound.Location = new System.Drawing.Point(741, 135);
            this.textBoxMaxBound.Name = "textBoxMaxBound";
            this.textBoxMaxBound.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxBound.TabIndex = 2;
            this.textBoxMaxBound.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество пчёл разведчиков";
            // 
            // textBoxNumScouts
            // 
            this.textBoxNumScouts.Location = new System.Drawing.Point(353, 45);
            this.textBoxNumScouts.Name = "textBoxNumScouts";
            this.textBoxNumScouts.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumScouts.TabIndex = 4;
            this.textBoxNumScouts.Text = "300";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Функция";
            // 
            // textBoxFitnessFunc
            // 
            this.textBoxFitnessFunc.Location = new System.Drawing.Point(71, 12);
            this.textBoxFitnessFunc.Name = "textBoxFitnessFunc";
            this.textBoxFitnessFunc.Size = new System.Drawing.Size(382, 20);
            this.textBoxFitnessFunc.TabIndex = 6;
            this.textBoxFitnessFunc.Text = "x^2 + 3*y^2 + 2*x*y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество лучших мест";
            // 
            // textBoxNumElitePlace
            // 
            this.textBoxNumElitePlace.Location = new System.Drawing.Point(742, 52);
            this.textBoxNumElitePlace.Name = "textBoxNumElitePlace";
            this.textBoxNumElitePlace.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumElitePlace.TabIndex = 8;
            this.textBoxNumElitePlace.Text = "5";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(412, 177);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Запустить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBoxNumElite
            // 
            this.textBoxNumElite.Location = new System.Drawing.Point(353, 71);
            this.textBoxNumElite.Name = "textBoxNumElite";
            this.textBoxNumElite.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumElite.TabIndex = 11;
            this.textBoxNumElite.Text = "30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Количество пчел, отправляемых на лучшие участки";
            // 
            // textBoxNumWorkers
            // 
            this.textBoxNumWorkers.Location = new System.Drawing.Point(353, 97);
            this.textBoxNumWorkers.Name = "textBoxNumWorkers";
            this.textBoxNumWorkers.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumWorkers.TabIndex = 13;
            this.textBoxNumWorkers.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество пчел, отправляемых на хорошие участки";
            // 
            // textBoxNumGoodPlace
            // 
            this.textBoxNumGoodPlace.Location = new System.Drawing.Point(742, 78);
            this.textBoxNumGoodPlace.Name = "textBoxNumGoodPlace";
            this.textBoxNumGoodPlace.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumGoodPlace.TabIndex = 15;
            this.textBoxNumGoodPlace.Text = "15";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Количество хороших мест";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Количество итераций";
            // 
            // textBoxNumIter
            // 
            this.textBoxNumIter.Location = new System.Drawing.Point(742, 104);
            this.textBoxNumIter.Name = "textBoxNumIter";
            this.textBoxNumIter.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumIter.TabIndex = 18;
            this.textBoxNumIter.Text = "1000";
            // 
            // textBoxMaxBoundNeighborhood
            // 
            this.textBoxMaxBoundNeighborhood.Location = new System.Drawing.Point(353, 135);
            this.textBoxMaxBoundNeighborhood.Name = "textBoxMaxBoundNeighborhood";
            this.textBoxMaxBoundNeighborhood.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxBoundNeighborhood.TabIndex = 20;
            this.textBoxMaxBoundNeighborhood.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Пределы окрестности участков по х и у ";
            // 
            // textBoxMinBoundNeighborhood
            // 
            this.textBoxMinBoundNeighborhood.Location = new System.Drawing.Point(247, 135);
            this.textBoxMinBoundNeighborhood.Name = "textBoxMinBoundNeighborhood";
            this.textBoxMinBoundNeighborhood.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinBoundNeighborhood.TabIndex = 21;
            this.textBoxMinBoundNeighborhood.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 292);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxMinBoundNeighborhood);
            this.Controls.Add(this.textBoxMaxBoundNeighborhood);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNumIter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNumGoodPlace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNumWorkers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNumElite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textBoxNumElitePlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFitnessFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumScouts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMaxBound);
            this.Controls.Add(this.textBoxMinBound);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMinBound;
        private System.Windows.Forms.TextBox textBoxMaxBound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumScouts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFitnessFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumElitePlace;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBoxNumElite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumWorkers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumGoodPlace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNumIter;
        private System.Windows.Forms.TextBox textBoxMaxBoundNeighborhood;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMinBoundNeighborhood;
        private System.Windows.Forms.Label label10;
    }
}

