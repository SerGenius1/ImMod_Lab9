namespace Lab_8._3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.input_NumOfTrials = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inp_p1 = new System.Windows.Forms.NumericUpDown();
            this.inp_p2 = new System.Windows.Forms.NumericUpDown();
            this.inp_p3 = new System.Windows.Forms.NumericUpDown();
            this.inp_p4 = new System.Windows.Forms.NumericUpDown();
            this.bt_Start = new System.Windows.Forms.Button();
            this.inp_p5 = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_IsCorrect = new System.Windows.Forms.Label();
            this.lbVar = new System.Windows.Forms.Label();
            this.lbAv = new System.Windows.Forms.Label();
            this.lbErVar = new System.Windows.Forms.Label();
            this.lbErAv = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_NumOfTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 487);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of trials";
            // 
            // input_NumOfTrials
            // 
            this.input_NumOfTrials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_NumOfTrials.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.input_NumOfTrials.Location = new System.Drawing.Point(240, 485);
            this.input_NumOfTrials.Margin = new System.Windows.Forms.Padding(4);
            this.input_NumOfTrials.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.input_NumOfTrials.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.input_NumOfTrials.Name = "input_NumOfTrials";
            this.input_NumOfTrials.Size = new System.Drawing.Size(160, 34);
            this.input_NumOfTrials.TabIndex = 1;
            this.input_NumOfTrials.ThousandsSeparator = true;
            this.input_NumOfTrials.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Probability 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Probability 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Probability 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Probability 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(44, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Probability 5";
            // 
            // inp_p1
            // 
            this.inp_p1.DecimalPlaces = 2;
            this.inp_p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inp_p1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inp_p1.Location = new System.Drawing.Point(240, 92);
            this.inp_p1.Margin = new System.Windows.Forms.Padding(4);
            this.inp_p1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inp_p1.Name = "inp_p1";
            this.inp_p1.Size = new System.Drawing.Size(160, 34);
            this.inp_p1.TabIndex = 1;
            this.inp_p1.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            // 
            // inp_p2
            // 
            this.inp_p2.DecimalPlaces = 2;
            this.inp_p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inp_p2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inp_p2.Location = new System.Drawing.Point(240, 158);
            this.inp_p2.Margin = new System.Windows.Forms.Padding(4);
            this.inp_p2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inp_p2.Name = "inp_p2";
            this.inp_p2.Size = new System.Drawing.Size(160, 34);
            this.inp_p2.TabIndex = 1;
            this.inp_p2.Value = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            // 
            // inp_p3
            // 
            this.inp_p3.DecimalPlaces = 2;
            this.inp_p3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inp_p3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inp_p3.Location = new System.Drawing.Point(240, 224);
            this.inp_p3.Margin = new System.Windows.Forms.Padding(4);
            this.inp_p3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inp_p3.Name = "inp_p3";
            this.inp_p3.Size = new System.Drawing.Size(160, 34);
            this.inp_p3.TabIndex = 1;
            this.inp_p3.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // inp_p4
            // 
            this.inp_p4.DecimalPlaces = 2;
            this.inp_p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inp_p4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inp_p4.Location = new System.Drawing.Point(240, 292);
            this.inp_p4.Margin = new System.Windows.Forms.Padding(4);
            this.inp_p4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inp_p4.Name = "inp_p4";
            this.inp_p4.Size = new System.Drawing.Size(160, 34);
            this.inp_p4.TabIndex = 1;
            this.inp_p4.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // bt_Start
            // 
            this.bt_Start.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Start.Location = new System.Drawing.Point(128, 622);
            this.bt_Start.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(192, 52);
            this.bt_Start.TabIndex = 2;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = false;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // inp_p5
            // 
            this.inp_p5.DecimalPlaces = 2;
            this.inp_p5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inp_p5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inp_p5.Location = new System.Drawing.Point(240, 364);
            this.inp_p5.Margin = new System.Windows.Forms.Padding(4);
            this.inp_p5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inp_p5.Name = "inp_p5";
            this.inp_p5.ReadOnly = true;
            this.inp_p5.Size = new System.Drawing.Size(160, 34);
            this.inp_p5.TabIndex = 1;
            this.inp_p5.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // chart1
            // 
            chartArea2.AxisY.Maximum = 1D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(484, 92);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(731, 428);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(431, 633);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chi-Squared: ";
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Result.Location = new System.Drawing.Point(624, 633);
            this.label_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(0, 29);
            this.label_Result.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(431, 695);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Result";
            // 
            // label_IsCorrect
            // 
            this.label_IsCorrect.AutoSize = true;
            this.label_IsCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_IsCorrect.Location = new System.Drawing.Point(624, 695);
            this.label_IsCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_IsCorrect.Name = "label_IsCorrect";
            this.label_IsCorrect.Size = new System.Drawing.Size(0, 29);
            this.label_IsCorrect.TabIndex = 0;
            // 
            // lbVar
            // 
            this.lbVar.AutoSize = true;
            this.lbVar.Location = new System.Drawing.Point(645, 602);
            this.lbVar.Name = "lbVar";
            this.lbVar.Size = new System.Drawing.Size(46, 17);
            this.lbVar.TabIndex = 4;
            this.lbVar.Text = "label9";
            // 
            // lbAv
            // 
            this.lbAv.AutoSize = true;
            this.lbAv.Location = new System.Drawing.Point(637, 545);
            this.lbAv.Name = "lbAv";
            this.lbAv.Size = new System.Drawing.Size(54, 17);
            this.lbAv.TabIndex = 5;
            this.lbAv.Text = "label10";
            // 
            // lbErVar
            // 
            this.lbErVar.AutoSize = true;
            this.lbErVar.Location = new System.Drawing.Point(758, 602);
            this.lbErVar.Name = "lbErVar";
            this.lbErVar.Size = new System.Drawing.Size(54, 17);
            this.lbErVar.TabIndex = 6;
            this.lbErVar.Text = "label11";
            // 
            // lbErAv
            // 
            this.lbErAv.AutoSize = true;
            this.lbErAv.Location = new System.Drawing.Point(758, 545);
            this.lbErAv.Name = "lbErAv";
            this.lbErAv.Size = new System.Drawing.Size(54, 17);
            this.lbErAv.TabIndex = 7;
            this.lbErAv.Text = "label12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(531, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Average";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(531, 595);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Var";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 788);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbErAv);
            this.Controls.Add(this.lbErVar);
            this.Controls.Add(this.lbAv);
            this.Controls.Add(this.lbVar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.inp_p5);
            this.Controls.Add(this.inp_p4);
            this.Controls.Add(this.inp_p3);
            this.Controls.Add(this.inp_p2);
            this.Controls.Add(this.inp_p1);
            this.Controls.Add(this.input_NumOfTrials);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_IsCorrect);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.input_NumOfTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown input_NumOfTrials;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown inp_p1;
        private System.Windows.Forms.NumericUpDown inp_p2;
        private System.Windows.Forms.NumericUpDown inp_p3;
        private System.Windows.Forms.NumericUpDown inp_p4;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.NumericUpDown inp_p5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_IsCorrect;
        private System.Windows.Forms.Label lbVar;
        private System.Windows.Forms.Label lbAv;
        private System.Windows.Forms.Label lbErVar;
        private System.Windows.Forms.Label lbErAv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

