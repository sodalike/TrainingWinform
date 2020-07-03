namespace prognostic_and_health_management_PHM_
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Bt_Normal = new System.Windows.Forms.Button();
            this.Bt_Diagnosis = new System.Windows.Forms.Button();
            this.Bt_Abnomal = new System.Windows.Forms.Button();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.Bt_Close = new System.Windows.Forms.Button();
            this.Bt_Training = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RMS(Root mean square)",
            "Max",
            "MIn"});
            this.comboBox1.Location = new System.Drawing.Point(394, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(319, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Feature";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(44, 113);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(471, 235);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Bt_Normal
            // 
            this.Bt_Normal.BackColor = System.Drawing.Color.Blue;
            this.Bt_Normal.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Normal.ForeColor = System.Drawing.Color.White;
            this.Bt_Normal.Location = new System.Drawing.Point(287, 426);
            this.Bt_Normal.Name = "Bt_Normal";
            this.Bt_Normal.Size = new System.Drawing.Size(228, 69);
            this.Bt_Normal.TabIndex = 3;
            this.Bt_Normal.Text = "Normal";
            this.Bt_Normal.UseVisualStyleBackColor = false;
            // 
            // Bt_Diagnosis
            // 
            this.Bt_Diagnosis.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Bt_Diagnosis.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Diagnosis.ForeColor = System.Drawing.Color.White;
            this.Bt_Diagnosis.Location = new System.Drawing.Point(359, 384);
            this.Bt_Diagnosis.Name = "Bt_Diagnosis";
            this.Bt_Diagnosis.Size = new System.Drawing.Size(156, 36);
            this.Bt_Diagnosis.TabIndex = 5;
            this.Bt_Diagnosis.Text = "Diagnosis";
            this.Bt_Diagnosis.UseVisualStyleBackColor = false;
            // 
            // Bt_Abnomal
            // 
            this.Bt_Abnomal.BackColor = System.Drawing.Color.Red;
            this.Bt_Abnomal.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Abnomal.ForeColor = System.Drawing.Color.White;
            this.Bt_Abnomal.Location = new System.Drawing.Point(44, 426);
            this.Bt_Abnomal.Name = "Bt_Abnomal";
            this.Bt_Abnomal.Size = new System.Drawing.Size(228, 69);
            this.Bt_Abnomal.TabIndex = 6;
            this.Bt_Abnomal.Text = "Abnormal";
            this.Bt_Abnomal.UseVisualStyleBackColor = false;
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(44, 49);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(156, 36);
            this.Bt_Update.TabIndex = 7;
            this.Bt_Update.Text = "Update";
            this.Bt_Update.UseVisualStyleBackColor = true;
            // 
            // Bt_Close
            // 
            this.Bt_Close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bt_Close.ForeColor = System.Drawing.Color.White;
            this.Bt_Close.Location = new System.Drawing.Point(522, 509);
            this.Bt_Close.Name = "Bt_Close";
            this.Bt_Close.Size = new System.Drawing.Size(28, 24);
            this.Bt_Close.TabIndex = 8;
            this.Bt_Close.Text = "X";
            this.Bt_Close.UseVisualStyleBackColor = false;
            this.Bt_Close.Click += new System.EventHandler(this.Bt_Close_Click);
            // 
            // Bt_Training
            // 
            this.Bt_Training.BackColor = System.Drawing.Color.Fuchsia;
            this.Bt_Training.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Training.ForeColor = System.Drawing.Color.White;
            this.Bt_Training.Location = new System.Drawing.Point(55, 384);
            this.Bt_Training.Name = "Bt_Training";
            this.Bt_Training.Size = new System.Drawing.Size(156, 36);
            this.Bt_Training.TabIndex = 9;
            this.Bt_Training.Text = "Training";
            this.Bt_Training.UseVisualStyleBackColor = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 545);
            this.Controls.Add(this.Bt_Training);
            this.Controls.Add(this.Bt_Close);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.Bt_Abnomal);
            this.Controls.Add(this.Bt_Diagnosis);
            this.Controls.Add(this.Bt_Normal);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "mainForm";
            this.Text = "PHM Model";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Bt_Normal;
        private System.Windows.Forms.Button Bt_Diagnosis;
        private System.Windows.Forms.Button Bt_Abnomal;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.Button Bt_Close;
        private System.Windows.Forms.Button Bt_Training;
    }
}

