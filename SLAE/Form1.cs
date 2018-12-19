using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLAE
{
    public partial class Form1 : Form
    {
        int size = 3;
        double[,] matrix;
        double[] b;

        double[] x;

        public Form1()
        {
            InitializeComponent();

            labelSizeSLAE.Text = "Размер СЛАУ - " + size.ToString();
            labelTimeGauss.Text             = "Метод Гаусса           - ";
            labelTimeCramer.Text            = "Метод Крамера          - ";
            labelTimeLU.Text                = "Метод LU-разложения    - ";
            labelTimeSimpleIteration.Text   = "Метод простой итерации - ";
            labelTimeGaussZeidel.Text       = "Метод Гаусса-Зейделя   - ";

            dataGridViewMatrix.ColumnCount = size;
            dataGridViewMatrix.RowCount = size;

            dataGridViewVector.RowCount = size;
            dataGridViewResult.RowCount = size;

            foreach (DataGridViewColumn column in dataGridViewMatrix.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridViewVector.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridViewResult.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch[] times = new Stopwatch[5];
            for (int i = 0; i < 5; i++)
            { 
                times[i] = new Stopwatch();
            }

            x = new double[size];

            GaussMethod gaussMethod = new GaussMethod();
            times[0].Start();
            double[] gaussSolution = gaussMethod.Solve(matrix, b);
            times[0].Stop();

            CramerMethod cramerMethod = new CramerMethod();
            times[1].Start();
            double[] cramerSolution = cramerMethod.Solve(matrix, b);
            times[1].Stop();

            LUDecomposition luDecomposition = new LUDecomposition();
            times[2].Start();
            double[] luSolution = luDecomposition.Solve(matrix, b);
            times[2].Stop();

            SimpleIterationMethod simpleIterationMethod = new SimpleIterationMethod();
            times[3].Start();
            double[] simpleIterationSolution = simpleIterationMethod.Solve(matrix, b);
            times[3].Stop();

            GaussSeidelMethod gaussSeidelMethod = new GaussSeidelMethod();
            times[4].Start();
            double[] gaussSeidelSolution = gaussSeidelMethod.Solve(matrix, b);
            times[4].Stop();


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"times[{i}] = {times[i].Elapsed.TotalSeconds}");
            }

            x = gaussSeidelSolution;
            for (int i = 0; i < size; i++)
            {
                dataGridViewResult.Rows[i].Cells[0].Value = x[i];
            }

            labelTimeGauss.Text             = "Метод Гаусса           - " + times[0].Elapsed.TotalSeconds;
            labelTimeCramer.Text            = "Метод Крамера          - " + times[1].Elapsed.TotalSeconds;
            labelTimeLU.Text                = "Метод LU-разложения    - " + times[2].Elapsed.TotalSeconds;
            labelTimeSimpleIteration.Text   = "Метод простой итерации - " + times[3].Elapsed.TotalSeconds;
            labelTimeGaussZeidel.Text       = "Метод Гаусса-Зейделя   - " + times[4].Elapsed.TotalSeconds;


            int numberMinTime = -1;
            int numberMaxTime = -1;

            double min = double.MaxValue;
            double max = double.MinValue;
            for (int i = 0; i < 5; i++)
            {
                if (times[i].Elapsed.TotalSeconds < min)
                {
                    min = times[i].Elapsed.TotalSeconds;
                    numberMinTime = i;
                }
                if (times[i].Elapsed.TotalSeconds > max)
                {
                    max = times[i].Elapsed.TotalSeconds;
                    numberMaxTime = i;
                }
            }

            labelTimeGauss.BackColor = Color.FromName("Control");
            labelTimeCramer.BackColor = Color.FromName("Control");
            labelTimeLU.BackColor = Color.FromName("Control");
            labelTimeSimpleIteration.BackColor = Color.FromName("Control");
            labelTimeGaussZeidel.BackColor = Color.FromName("Control");

            switch (numberMinTime)
            {
                case 0:
                    labelTimeGauss.BackColor = Color.Green;
                    break;
                case 1:
                    labelTimeCramer.BackColor = Color.Green;
                    break;
                case 2:
                    labelTimeLU.BackColor = Color.Green;
                    break;
                case 3:
                    labelTimeSimpleIteration.BackColor = Color.Green;
                    break;
                case 4:
                    labelTimeGaussZeidel.BackColor = Color.Green;
                    break;
            }

            switch (numberMaxTime)
            {
                case 0:
                    labelTimeGauss.BackColor = Color.Red;
                    break;
                case 1:
                    labelTimeCramer.BackColor = Color.Red;
                    break;
                case 2:
                    labelTimeLU.BackColor = Color.Red;
                    break;
                case 3:
                    labelTimeSimpleIteration.BackColor = Color.Red;
                    break;
                case 4:
                    labelTimeGaussZeidel.BackColor = Color.Red;
                    break;
            }

            bool isCorrect = true;
            const double EPS = 0.001;
            for (int i = 0; i < 5 && isCorrect; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Math.Abs(gaussSolution[j] - cramerSolution[j]) < EPS &&
                        Math.Abs(cramerSolution[j] - luSolution[j]) < EPS &&
                        Math.Abs(luSolution[j] - simpleIterationSolution[j]) < EPS &&
                        Math.Abs(simpleIterationSolution[j] - gaussSeidelSolution[j]) < EPS
                        )
                    {

                    }
                    else
                    {
                        isCorrect = false;
                        break;
                    }
                }
            }

            if (isCorrect)
            {
                checkBoxEquality.Checked = true;
                Console.WriteLine("Совпадение решения");
            }
            else
            {
                checkBoxEquality.Checked = true;
                Console.WriteLine("Несовпадение решения");
            }

        }

        private void buttonMinusSize_Click(object sender, EventArgs e)
        {
            if (size != 3)
            {
                buttonMinusSize.Enabled = true;

                size--;
                labelSizeSLAE.Text = "Размер СЛАУ - " + size.ToString();

                dataGridViewMatrix.Rows.RemoveAt(size - 1);
                dataGridViewMatrix.Columns.Remove("");

                dataGridViewVector.Rows.RemoveAt(size - 1);
                dataGridViewResult.Rows.RemoveAt(size - 1);

                buttonClear_Click(sender, e);

                if (size == 3)
                {
                    buttonMinusSize.Enabled = false;
                }
                if (size < 8)
                {
                    buttonPlusSize.Enabled = true;
                }
            }
        }

        private void buttonPlusSize_Click(object sender, EventArgs e)
        {
            if (size != 8)
            {
                buttonPlusSize.Enabled = true;

                size++;
                labelSizeSLAE.Text = "Размер СЛАУ - " + size.ToString();


                dataGridViewMatrix.Rows.Add();
                dataGridViewMatrix.Columns.Add("", "");

                dataGridViewVector.Rows.Add();
                dataGridViewResult.Rows.Add();

                buttonClear_Click(sender, e);

                if (size == 8)
                {
                    buttonPlusSize.Enabled = false;
                }
                if (size > 3)
                {
                    buttonMinusSize.Enabled = true;
                }
            }
        }

        private void buttonGenerator_Click(object sender, EventArgs e)
        {
            GeneratorMatrix generator = new GeneratorMatrix();
            matrix = generator.GenerateMatrix(size);
            b = generator.GenerateVector(size);

            for (int i = 0; i < dataGridViewMatrix.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewMatrix.ColumnCount; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j];
                }

                dataGridViewVector.Rows[i].Cells[0].Value = b[i];
            }

            buttonCalculate.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewMatrix.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewMatrix.ColumnCount; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = "";
                }

                dataGridViewVector.Rows[i].Cells[0].Value = "";
                dataGridViewResult.Rows[i].Cells[0].Value = "";
            }

            buttonCalculate.Enabled = false;
            checkBoxEquality.Checked = false;

            labelTimeGauss.Text = "Метод Гаусса           - ";
            labelTimeCramer.Text = "Метод Крамера          - ";
            labelTimeLU.Text = "Метод LU-разложения    - ";
            labelTimeSimpleIteration.Text = "Метод простой итерации - ";
            labelTimeGaussZeidel.Text = "Метод Гаусса-Зейделя   - ";

            labelTimeGauss.BackColor = Color.FromName("Control");
            labelTimeCramer.BackColor = Color.FromName("Control");
            labelTimeLU.BackColor = Color.FromName("Control");
            labelTimeSimpleIteration.BackColor = Color.FromName("Control");
            labelTimeGaussZeidel.BackColor = Color.FromName("Control");
        }
    }
}
