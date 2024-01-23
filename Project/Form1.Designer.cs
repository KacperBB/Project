namespace Project
{

    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.textBoxWindSpeed = new System.Windows.Forms.TextBox();
            this.textBoxDewPoint = new System.Windows.Forms.TextBox();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.textBoxQNH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WindDirection = new System.Windows.Forms.TabPage();
            this.humiditychart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WindSpeed = new System.Windows.Forms.TabPage();
            this.windspeedchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DewPoint = new System.Windows.Forms.TabPage();
            this.dewpointchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Temperature = new System.Windows.Forms.TabPage();
            this.temperaturechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.QNH = new System.Windows.Forms.TabPage();
            this.qnhchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.onbutton = new System.Windows.Forms.Button();
            this.offbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comListener = new System.Windows.Forms.ComboBox();
            this.Humidity = new System.Windows.Forms.Label();
            this.textBoxHumidity = new System.Windows.Forms.TextBox();
            this.altitude = new System.Windows.Forms.Label();
            this.textBoxAltitude = new System.Windows.Forms.TextBox();
            this.component11 = new Project.Component1(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.WindDirection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humiditychart)).BeginInit();
            this.WindSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windspeedchart)).BeginInit();
            this.DewPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dewpointchart)).BeginInit();
            this.Temperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturechart)).BeginInit();
            this.QNH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qnhchart)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // textBoxWindSpeed
            // 
            this.textBoxWindSpeed.Location = new System.Drawing.Point(44, 103);
            this.textBoxWindSpeed.Name = "textBoxWindSpeed";
            this.textBoxWindSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxWindSpeed.TabIndex = 1;
            this.textBoxWindSpeed.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxDewPoint
            // 
            this.textBoxDewPoint.Location = new System.Drawing.Point(44, 151);
            this.textBoxDewPoint.Name = "textBoxDewPoint";
            this.textBoxDewPoint.Size = new System.Drawing.Size(100, 20);
            this.textBoxDewPoint.TabIndex = 2;
            this.textBoxDewPoint.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Location = new System.Drawing.Point(44, 205);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemperature.TabIndex = 3;
            this.textBoxTemperature.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxQNH
            // 
            this.textBoxQNH.Location = new System.Drawing.Point(44, 256);
            this.textBoxQNH.Name = "textBoxQNH";
            this.textBoxQNH.Size = new System.Drawing.Size(100, 20);
            this.textBoxQNH.TabIndex = 8;
            this.textBoxQNH.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wind Speed";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "DewPoint";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Temperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "QNH";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(570, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.Text = "label6";
            this.statusLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WindDirection);
            this.tabControl1.Controls.Add(this.WindSpeed);
            this.tabControl1.Controls.Add(this.DewPoint);
            this.tabControl1.Controls.Add(this.Temperature);
            this.tabControl1.Controls.Add(this.QNH);
            this.tabControl1.Location = new System.Drawing.Point(202, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 420);
            this.tabControl1.TabIndex = 18;
            // 
            // WindDirection
            // 
            this.WindDirection.Controls.Add(this.humiditychart);
            this.WindDirection.Location = new System.Drawing.Point(4, 22);
            this.WindDirection.Name = "WindDirection";
            this.WindDirection.Padding = new System.Windows.Forms.Padding(3);
            this.WindDirection.Size = new System.Drawing.Size(509, 394);
            this.WindDirection.TabIndex = 0;
            this.WindDirection.Text = "Wind Direction Chart";
            this.WindDirection.UseVisualStyleBackColor = true;
            // 
            // humiditychart
            // 
            chartArea1.Name = "ChartArea1";
            this.humiditychart.ChartAreas.Add(chartArea1);
            this.humiditychart.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.humiditychart.Location = new System.Drawing.Point(0, 0);
            this.humiditychart.Name = "humiditychart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsValueShownAsLabel = true;
            series1.Label = "c";
            series1.Name = "Series1";
            this.humiditychart.Series.Add(series1);
            this.humiditychart.Size = new System.Drawing.Size(513, 394);
            this.humiditychart.TabIndex = 19;
            this.humiditychart.Text = "chart1";
            this.humiditychart.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // WindSpeed
            // 
            this.WindSpeed.Controls.Add(this.windspeedchart);
            this.WindSpeed.Location = new System.Drawing.Point(4, 22);
            this.WindSpeed.Name = "WindSpeed";
            this.WindSpeed.Padding = new System.Windows.Forms.Padding(3);
            this.WindSpeed.Size = new System.Drawing.Size(509, 394);
            this.WindSpeed.TabIndex = 1;
            this.WindSpeed.Text = "Wind Speed Chart";
            this.WindSpeed.UseVisualStyleBackColor = true;
            // 
            // windspeedchart
            // 
            chartArea2.Name = "ChartArea1";
            this.windspeedchart.ChartAreas.Add(chartArea2);
            this.windspeedchart.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.windspeedchart.Location = new System.Drawing.Point(0, 0);
            this.windspeedchart.Name = "windspeedchart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsValueShownAsLabel = true;
            series2.Label = "c";
            series2.Name = "Series1";
            this.windspeedchart.Series.Add(series2);
            this.windspeedchart.Size = new System.Drawing.Size(509, 394);
            this.windspeedchart.TabIndex = 18;
            this.windspeedchart.Text = "chart2";
            this.windspeedchart.Click += new System.EventHandler(this.chart2_Click);
            // 
            // DewPoint
            // 
            this.DewPoint.Controls.Add(this.dewpointchart);
            this.DewPoint.Location = new System.Drawing.Point(4, 22);
            this.DewPoint.Name = "DewPoint";
            this.DewPoint.Size = new System.Drawing.Size(509, 394);
            this.DewPoint.TabIndex = 2;
            this.DewPoint.Text = "Dew Point Chart";
            this.DewPoint.UseVisualStyleBackColor = true;
            // 
            // dewpointchart
            // 
            chartArea3.Name = "ChartArea1";
            this.dewpointchart.ChartAreas.Add(chartArea3);
            this.dewpointchart.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dewpointchart.Location = new System.Drawing.Point(0, 4);
            this.dewpointchart.Name = "dewpointchart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsValueShownAsLabel = true;
            series3.Label = "c";
            series3.Name = "Series1";
            this.dewpointchart.Series.Add(series3);
            this.dewpointchart.Size = new System.Drawing.Size(509, 394);
            this.dewpointchart.TabIndex = 19;
            this.dewpointchart.Text = "chart3";
            this.dewpointchart.Click += new System.EventHandler(this.chart3_Click);
            // 
            // Temperature
            // 
            this.Temperature.Controls.Add(this.temperaturechart);
            this.Temperature.Location = new System.Drawing.Point(4, 22);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(509, 394);
            this.Temperature.TabIndex = 3;
            this.Temperature.Text = "Temperature Chart";
            this.Temperature.UseVisualStyleBackColor = true;
            // 
            // temperaturechart
            // 
            chartArea4.Name = "ChartArea1";
            this.temperaturechart.ChartAreas.Add(chartArea4);
            this.temperaturechart.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.temperaturechart.Location = new System.Drawing.Point(8, 8);
            this.temperaturechart.Name = "temperaturechart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsValueShownAsLabel = true;
            series4.Label = "c";
            series4.Name = "Series1";
            this.temperaturechart.Series.Add(series4);
            this.temperaturechart.Size = new System.Drawing.Size(509, 394);
            this.temperaturechart.TabIndex = 19;
            this.temperaturechart.Text = "chart4";
            this.temperaturechart.Click += new System.EventHandler(this.chart4_Click);
            // 
            // QNH
            // 
            this.QNH.Controls.Add(this.qnhchart);
            this.QNH.Location = new System.Drawing.Point(4, 22);
            this.QNH.Name = "QNH";
            this.QNH.Size = new System.Drawing.Size(509, 394);
            this.QNH.TabIndex = 4;
            this.QNH.Text = "QNH Chart";
            this.QNH.UseVisualStyleBackColor = true;
            // 
            // qnhchart
            // 
            chartArea5.Name = "ChartArea1";
            this.qnhchart.ChartAreas.Add(chartArea5);
            this.qnhchart.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.qnhchart.Location = new System.Drawing.Point(8, 8);
            this.qnhchart.Name = "qnhchart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsValueShownAsLabel = true;
            series5.Label = "c";
            series5.Name = "Series1";
            this.qnhchart.Series.Add(series5);
            this.qnhchart.Size = new System.Drawing.Size(509, 394);
            this.qnhchart.TabIndex = 19;
            this.qnhchart.Text = "qnhchart";
            this.qnhchart.Click += new System.EventHandler(this.chart5_Click);
            // 
            // onbutton
            // 
            this.onbutton.Location = new System.Drawing.Point(41, 387);
            this.onbutton.Name = "onbutton";
            this.onbutton.Size = new System.Drawing.Size(52, 23);
            this.onbutton.TabIndex = 19;
            this.onbutton.Text = "ON";
            this.onbutton.UseVisualStyleBackColor = true;
            this.onbutton.Click += new System.EventHandler(this.onbutton_Click);
            // 
            // offbutton
            // 
            this.offbutton.Location = new System.Drawing.Point(99, 387);
            this.offbutton.Name = "offbutton";
            this.offbutton.Size = new System.Drawing.Size(54, 23);
            this.offbutton.TabIndex = 20;
            this.offbutton.Text = "OFF";
            this.offbutton.UseVisualStyleBackColor = true;
            this.offbutton.Click += new System.EventHandler(this.offbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(545, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "OFF option is for debbuging purposes: it\'s main focus is to generate random DATA " +
    "to check viability of the program";
            // 
            // comListener
            // 
            this.comListener.FormattingEnabled = true;
            this.comListener.Location = new System.Drawing.Point(42, 426);
            this.comListener.Name = "comListener";
            this.comListener.Size = new System.Drawing.Size(111, 21);
            this.comListener.TabIndex = 22;
            this.comListener.SelectedIndexChanged += new System.EventHandler(this.comListener_SelectedIndexChanged);
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.Location = new System.Drawing.Point(40, 294);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(47, 13);
            this.Humidity.TabIndex = 24;
            this.Humidity.Text = "Humidity";
            this.Humidity.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxHumidity
            // 
            this.textBoxHumidity.Location = new System.Drawing.Point(44, 310);
            this.textBoxHumidity.Name = "textBoxHumidity";
            this.textBoxHumidity.Size = new System.Drawing.Size(100, 20);
            this.textBoxHumidity.TabIndex = 23;
            // 
            // altitude
            // 
            this.altitude.AutoSize = true;
            this.altitude.Location = new System.Drawing.Point(40, 40);
            this.altitude.Name = "altitude";
            this.altitude.Size = new System.Drawing.Size(42, 13);
            this.altitude.TabIndex = 10;
            this.altitude.Text = "Altitude";
            this.altitude.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxAltitude
            // 
            this.textBoxAltitude.Location = new System.Drawing.Point(43, 56);
            this.textBoxAltitude.Name = "textBoxAltitude";
            this.textBoxAltitude.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltitude.TabIndex = 0;
            this.textBoxAltitude.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 494);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.textBoxHumidity);
            this.Controls.Add(this.comListener);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.offbutton);
            this.Controls.Add(this.onbutton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.altitude);
            this.Controls.Add(this.textBoxQNH);
            this.Controls.Add(this.textBoxTemperature);
            this.Controls.Add(this.textBoxDewPoint);
            this.Controls.Add(this.textBoxWindSpeed);
            this.Controls.Add(this.textBoxAltitude);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.WindDirection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.humiditychart)).EndInit();
            this.WindSpeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.windspeedchart)).EndInit();
            this.DewPoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dewpointchart)).EndInit();
            this.Temperature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.temperaturechart)).EndInit();
            this.QNH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qnhchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.TextBox textBoxDewPoint;
        private System.Windows.Forms.TextBox textBoxWindSpeed;
        private System.Windows.Forms.TextBox textBoxQNH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label statusLabel;
        private Component1 component11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WindDirection;
        private System.Windows.Forms.DataVisualization.Charting.Chart humiditychart;
        private System.Windows.Forms.TabPage WindSpeed;
        private System.Windows.Forms.DataVisualization.Charting.Chart windspeedchart;
        private System.Windows.Forms.TabPage DewPoint;
        private System.Windows.Forms.DataVisualization.Charting.Chart dewpointchart;
        private System.Windows.Forms.TabPage Temperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperaturechart;
        private System.Windows.Forms.TabPage QNH;
        private System.Windows.Forms.DataVisualization.Charting.Chart qnhchart;
        private System.Windows.Forms.Button offbutton;
        private System.Windows.Forms.Button onbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comListener;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.TextBox textBoxHumidity;
        private System.Windows.Forms.Label altitude;
        private System.Windows.Forms.TextBox textBoxAltitude;
    }
}

