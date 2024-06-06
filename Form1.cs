using System;
using System.Windows.Forms;

namespace Lab_8._3
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int trials;
        int[] counts;   //Реальные значения
        double[] probabilities;

        const double CriticalChiSquaredValue = 9.488;  // При вероятности ошибки = 0.05
        const int NumOfEvents = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            Initialize();



            if (probabilities[4] < 0)
            {
                MessageBox.Show("Incorrect input!\nSum of pi must be < 1");
                return;
            }
            inp_p5.Value = (decimal)probabilities[4];

            MakeTrials();
            DrawBarchart();



            MakeCalculations();
        }

        private void MakeCalculations()
        {
            double av = 0, var = 0, empav = 0, empvar = 0;
            double[] x = new double[5] { 10, 20, 40, 20, 10 };
            double[] emprob = new double[NumOfEvents];
            int[] expectedCounts = new int[NumOfEvents];
            for (int i = 0; i < NumOfEvents; i++)
                expectedCounts[i] = (int)(probabilities[i] * trials);

            double chiSquared = 0;
            for (int i = 0; i < NumOfEvents; i++)
                chiSquared += (double) (counts[i] - expectedCounts[i]) * (counts[i] - expectedCounts[i]) / expectedCounts[i];

            if (chiSquared <= CriticalChiSquaredValue)
            {
                label_Result.Text = Math.Round(chiSquared, 4) + " < " + CriticalChiSquaredValue;
                label_IsCorrect.Text = "Correct";
                label_IsCorrect.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label_Result.Text = Math.Round(chiSquared, 4) + " > " + CriticalChiSquaredValue;
                label_IsCorrect.Text = "Incorrect";
                label_IsCorrect.ForeColor = System.Drawing.Color.Red;
            }

            //Вычисление эмпирических вероятностей
            for (int i = 0; i < 5; i++)
            {
                emprob[i] = (double)(counts[i]) / (double)NumOfEvents;
            }

            //Вычисление эмпирического среднего
            for (int i = 0; i < 5; i++)
            {
                empav += probabilities[i] * emprob[i];
            }

            //Вычисление мат ожидания
            double Ex = 0;
            for (int i = 0; i < 5; i++)
            {
                Ex += probabilities[i] * x[i];
            }

            //Вычисление дисперсии
            for (int i = 0; i < 5; i++)
            {
                var += probabilities[i] * (x[i] - Ex) * (x[i] - Ex);
            }

            //Вычисление эмпирической дисперсии
            for (int i = 0; i < 5; i++)
            {
                empvar = emprob[i] * x[i] * x[i] - empav * empav;
            }

            //Вычисление абсолютной погрешноси
            double absE = Math.Abs((empav - Ex));
            double absD = Math.Abs((empvar - var));

            //Вычисление относительной погрешности RelativeE RelativeD
            double relE = absE / Math.Abs(Ex);
            double relD = absD / Math.Abs(var);


            lbAv.Text = empav.ToString();
            lbVar.Text = empvar.ToString();
            lbErAv.Text = relE.ToString() + "%";
            lbErVar.Text = relD.ToString() + "%";
        }

        private void Initialize()
        {
            trials = (int)input_NumOfTrials.Value;
            counts = new int[NumOfEvents];
            Array.Clear(counts, 0, NumOfEvents);

            probabilities = new double[NumOfEvents]
            {
                (double)inp_p1.Value,
                (double)inp_p2.Value,
                (double)inp_p3.Value,
                (double)inp_p4.Value,
                1
            };
            //Вычисление последней вероятности
            for (int i = 0; i < NumOfEvents - 1; i++) probabilities[4] -= probabilities[i];   

            chart1.Series[0].Points.Clear();
        }

        private void MakeTrials()
        {
            for (int i = 0; i < trials; i++)
            {
                var p = random.NextDouble();
                //Фиксация произошедшего события
                counts[GetEvent(p)]++;
            }
        }

        private int GetEvent(double p)
        {
            int i = 0;
            while (p >= 0)
            {
                p -= probabilities[i];
                i++;
            }

            return i - 1;
        }

        private void DrawBarchart()
        {
            for (int i = 0; i < NumOfEvents; i++)
            {
                var value = (float)counts[i] / trials;
                chart1.Series[0].Points.AddXY(i + 1, value);
            }
        }
    }
}
