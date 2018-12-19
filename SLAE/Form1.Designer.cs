namespace SLAE
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.dataGridViewVector = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.buttonMinusSize = new System.Windows.Forms.Button();
            this.buttonPlusSize = new System.Windows.Forms.Button();
            this.labelSizeSLAE = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelVectorB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerator = new System.Windows.Forms.Button();
            this.checkBoxEquality = new System.Windows.Forms.CheckBox();
            this.labelTimeGauss = new System.Windows.Forms.Label();
            this.labelTimeCramer = new System.Windows.Forms.Label();
            this.labelTimeLU = new System.Windows.Forms.Label();
            this.labelTimeSimpleIteration = new System.Windows.Forms.Label();
            this.labelTimeGaussZeidel = new System.Windows.Forms.Label();
            this.labelTimes = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Enabled = false;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCalculate.Location = new System.Drawing.Point(631, 30);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(117, 41);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Решить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToResizeColumns = false;
            this.dataGridViewMatrix.AllowUserToResizeRows = false;
            this.dataGridViewMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.ColumnHeadersVisible = false;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(92, 97);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.ReadOnly = true;
            this.dataGridViewMatrix.RowHeadersVisible = false;
            this.dataGridViewMatrix.RowHeadersWidth = 40;
            this.dataGridViewMatrix.RowTemplate.Height = 24;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(300, 255);
            this.dataGridViewMatrix.TabIndex = 1;
            // 
            // dataGridViewVector
            // 
            this.dataGridViewVector.AllowUserToResizeColumns = false;
            this.dataGridViewVector.AllowUserToResizeRows = false;
            this.dataGridViewVector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVector.ColumnHeadersVisible = false;
            this.dataGridViewVector.Location = new System.Drawing.Point(467, 97);
            this.dataGridViewVector.Name = "dataGridViewVector";
            this.dataGridViewVector.ReadOnly = true;
            this.dataGridViewVector.RowHeadersVisible = false;
            this.dataGridViewVector.RowTemplate.Height = 24;
            this.dataGridViewVector.Size = new System.Drawing.Size(77, 255);
            this.dataGridViewVector.TabIndex = 2;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.ColumnHeadersVisible = false;
            this.dataGridViewResult.Location = new System.Drawing.Point(647, 97);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.Size = new System.Drawing.Size(84, 255);
            this.dataGridViewResult.TabIndex = 3;
            // 
            // buttonMinusSize
            // 
            this.buttonMinusSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMinusSize.Location = new System.Drawing.Point(118, 358);
            this.buttonMinusSize.Name = "buttonMinusSize";
            this.buttonMinusSize.Size = new System.Drawing.Size(50, 50);
            this.buttonMinusSize.TabIndex = 4;
            this.buttonMinusSize.Text = "-";
            this.buttonMinusSize.UseVisualStyleBackColor = true;
            this.buttonMinusSize.Click += new System.EventHandler(this.buttonMinusSize_Click);
            // 
            // buttonPlusSize
            // 
            this.buttonPlusSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonPlusSize.Location = new System.Drawing.Point(174, 358);
            this.buttonPlusSize.Name = "buttonPlusSize";
            this.buttonPlusSize.Size = new System.Drawing.Size(50, 50);
            this.buttonPlusSize.TabIndex = 5;
            this.buttonPlusSize.Text = "+";
            this.buttonPlusSize.UseVisualStyleBackColor = true;
            this.buttonPlusSize.Click += new System.EventHandler(this.buttonPlusSize_Click);
            // 
            // labelSizeSLAE
            // 
            this.labelSizeSLAE.AutoSize = true;
            this.labelSizeSLAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSizeSLAE.Location = new System.Drawing.Point(230, 369);
            this.labelSizeSLAE.Name = "labelSizeSLAE";
            this.labelSizeSLAE.Size = new System.Drawing.Size(191, 29);
            this.labelSizeSLAE.TabIndex = 6;
            this.labelSizeSLAE.Text = "Размер СЛАУ - ";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelA.Location = new System.Drawing.Point(38, 216);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(48, 29);
            this.labelA.TabIndex = 7;
            this.labelA.Text = "A =";
            // 
            // labelVectorB
            // 
            this.labelVectorB.AutoSize = true;
            this.labelVectorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVectorB.Location = new System.Drawing.Point(414, 216);
            this.labelVectorB.Name = "labelVectorB";
            this.labelVectorB.Size = new System.Drawing.Size(47, 29);
            this.labelVectorB.TabIndex = 8;
            this.labelVectorB.Text = "b =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(597, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "x =";
            // 
            // buttonGenerator
            // 
            this.buttonGenerator.Location = new System.Drawing.Point(92, 12);
            this.buttonGenerator.Name = "buttonGenerator";
            this.buttonGenerator.Size = new System.Drawing.Size(211, 59);
            this.buttonGenerator.TabIndex = 10;
            this.buttonGenerator.Text = "Сгенерировать матрицу коэффициентов и вектор свободных членов";
            this.buttonGenerator.UseVisualStyleBackColor = true;
            this.buttonGenerator.Click += new System.EventHandler(this.buttonGenerator_Click);
            // 
            // checkBoxEquality
            // 
            this.checkBoxEquality.AutoSize = true;
            this.checkBoxEquality.Enabled = false;
            this.checkBoxEquality.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.checkBoxEquality.Location = new System.Drawing.Point(747, 97);
            this.checkBoxEquality.Name = "checkBoxEquality";
            this.checkBoxEquality.Size = new System.Drawing.Size(291, 33);
            this.checkBoxEquality.TabIndex = 11;
            this.checkBoxEquality.Text = "Совпадение решения";
            this.checkBoxEquality.UseVisualStyleBackColor = true;
            // 
            // labelTimeGauss
            // 
            this.labelTimeGauss.AutoSize = true;
            this.labelTimeGauss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimeGauss.Location = new System.Drawing.Point(747, 207);
            this.labelTimeGauss.Name = "labelTimeGauss";
            this.labelTimeGauss.Size = new System.Drawing.Size(182, 29);
            this.labelTimeGauss.TabIndex = 12;
            this.labelTimeGauss.Text = "Метод Гаусса -";
            // 
            // labelTimeCramer
            // 
            this.labelTimeCramer.AutoSize = true;
            this.labelTimeCramer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimeCramer.Location = new System.Drawing.Point(747, 236);
            this.labelTimeCramer.Name = "labelTimeCramer";
            this.labelTimeCramer.Size = new System.Drawing.Size(215, 29);
            this.labelTimeCramer.TabIndex = 13;
            this.labelTimeCramer.Text = "Метод Крамера - ";
            // 
            // labelTimeLU
            // 
            this.labelTimeLU.AutoSize = true;
            this.labelTimeLU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimeLU.Location = new System.Drawing.Point(747, 265);
            this.labelTimeLU.Name = "labelTimeLU";
            this.labelTimeLU.Size = new System.Drawing.Size(296, 29);
            this.labelTimeLU.TabIndex = 14;
            this.labelTimeLU.Text = "Метод LU-разложения - ";
            // 
            // labelTimeSimpleIteration
            // 
            this.labelTimeSimpleIteration.AutoSize = true;
            this.labelTimeSimpleIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimeSimpleIteration.Location = new System.Drawing.Point(747, 294);
            this.labelTimeSimpleIteration.Name = "labelTimeSimpleIteration";
            this.labelTimeSimpleIteration.Size = new System.Drawing.Size(328, 29);
            this.labelTimeSimpleIteration.TabIndex = 15;
            this.labelTimeSimpleIteration.Text = "Метод простой итерации - ";
            // 
            // labelTimeGaussZeidel
            // 
            this.labelTimeGaussZeidel.AutoSize = true;
            this.labelTimeGaussZeidel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimeGaussZeidel.Location = new System.Drawing.Point(747, 323);
            this.labelTimeGaussZeidel.Name = "labelTimeGaussZeidel";
            this.labelTimeGaussZeidel.Size = new System.Drawing.Size(297, 29);
            this.labelTimeGaussZeidel.TabIndex = 16;
            this.labelTimeGaussZeidel.Text = "Метод Гаусса-Зейделя - ";
            // 
            // labelTimes
            // 
            this.labelTimes.AutoSize = true;
            this.labelTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimes.Location = new System.Drawing.Point(747, 178);
            this.labelTimes.Name = "labelTimes";
            this.labelTimes.Size = new System.Drawing.Size(238, 29);
            this.labelTimes.TabIndex = 17;
            this.labelTimes.Text = "Время (в секундах):";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonClear.Location = new System.Drawing.Point(323, 16);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(155, 42);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelTimes);
            this.Controls.Add(this.labelTimeGaussZeidel);
            this.Controls.Add(this.labelTimeSimpleIteration);
            this.Controls.Add(this.labelTimeLU);
            this.Controls.Add(this.labelTimeCramer);
            this.Controls.Add(this.labelTimeGauss);
            this.Controls.Add(this.checkBoxEquality);
            this.Controls.Add(this.buttonGenerator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVectorB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelSizeSLAE);
            this.Controls.Add(this.buttonPlusSize);
            this.Controls.Add(this.buttonMinusSize);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.dataGridViewVector);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Form1";
            this.Text = "SLAE Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.DataGridView dataGridViewVector;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonMinusSize;
        private System.Windows.Forms.Button buttonPlusSize;
        private System.Windows.Forms.Label labelSizeSLAE;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelVectorB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerator;
        private System.Windows.Forms.CheckBox checkBoxEquality;
        private System.Windows.Forms.Label labelTimeGauss;
        private System.Windows.Forms.Label labelTimeCramer;
        private System.Windows.Forms.Label labelTimeLU;
        private System.Windows.Forms.Label labelTimeSimpleIteration;
        private System.Windows.Forms.Label labelTimeGaussZeidel;
        private System.Windows.Forms.Label labelTimes;
        private System.Windows.Forms.Button buttonClear;
    }
}

