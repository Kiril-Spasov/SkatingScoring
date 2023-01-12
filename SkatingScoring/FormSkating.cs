using System;
using System.IO;
using System.Windows.Forms;

namespace SkatingScoring
{
    public partial class FormSkating : Form
    {
        public FormSkating()
        {
            InitializeComponent();
        }

        private void BtnCalculateScore_Click(object sender, EventArgs e)
        {
            string skaterName;
            double[] scores = new double[12];

            string path = Application.StartupPath + @"\skating.txt";
            StreamReader streamReader = new StreamReader(path);

            int pairsCount = Convert.ToInt32(streamReader.ReadLine());

            TxtResult.Text += "Final results: " + Environment.NewLine;

            for (int i = 1; i <= pairsCount; i++)
            {
                skaterName = streamReader.ReadLine();

                for (int j = 0; j <= 11; j++)
                {
                    scores[j] = Convert.ToDouble(streamReader.ReadLine());
                }

                TxtResult.Text += skaterName + ": " + CalculateAverage(scores).ToString("n2") + Environment.NewLine;
            }
        }

        private double CalculateAverage(double[] scores)
        {
            double totalOf10Scores = 0;
            double average;

            Sort(scores);

            for (int i = 1; i < scores.Length - 1; i++)
            {
                totalOf10Scores += scores[i];
            }

            return average = totalOf10Scores / 10;

        }

        private void Sort(double[] numbers)
        {
            int minLocation;
            double temp;

            for (int i = 0; i < numbers.Length; i++)
            {
                minLocation = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[minLocation] > numbers[j])
                    {
                        minLocation = j;
                        
                    }
                }
                temp = numbers[minLocation];
                numbers[minLocation] = numbers[i];
                numbers[i] = temp;
            }
        }
    }
}
