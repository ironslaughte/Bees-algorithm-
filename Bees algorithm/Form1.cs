using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bees_algorithm
{
    public partial class Form1 : Form
    {
        private Hive hive;
        private string strFitnessFunc;
        private int scoutsNum, eliteBeeNum, workersBeeNum, numElitePlaces, numGoodPlaces, numIterationAlg;
        private double minX, maxX;
        private double[] neighborhood;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!ParseParams()) return;
            try
            {
                LaunchHiveAlg();
                var answer = hive.GetBest();
                PrintAnswer(answer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Функция введена неправильно");
            }

        }

        private void PrintAnswer((double bestFitness, double[] bestPlace) answer)
        {
            label10.Visible = true;
            label10.Text = "Fitness = " + answer.bestFitness.ToString() + "\nx= " + answer.bestPlace[0].ToString() + "\ny= " + answer.bestPlace[1].ToString();
        }

        private void LaunchHiveAlg()
        {
                hive = new Hive(scoutsNum, eliteBeeNum, workersBeeNum, numElitePlaces, numGoodPlaces, neighborhood, minX, maxX, numIterationAlg, strFitnessFunc);
                hive.StartHiveAlg();
        }

        private bool ParseParams()
        {
            strFitnessFunc = textBoxFitnessFunc.Text;
            ParseIntParams();
            ParseDoubleParams();
            if (scoutsNum <= 0 || eliteBeeNum <= 0 || workersBeeNum <= 0 || numElitePlaces <= 0 || numGoodPlaces <= 0 || numIterationAlg <= 0)
            {
                MessageBox.Show("Значения параметров не могут быть отрицательными или равны нулю, попробуйте еще раз");
                return false;
            }
            else if (minX >= maxX)
            {
                MessageBox.Show("Минимальный диапазон не может превышать или быть равен максимальному");
                return false;
            }
            else if (neighborhood[0] < 0 || neighborhood[1] < 0)
            {
                MessageBox.Show("Окрестность не может быть меньше нуля");
                return false;
            }
            return true;
        }

        private void ParseDoubleParams()
        {
            minX = Double.Parse(textBoxMinBound.Text);
            maxX = Double.Parse(textBoxMaxBound.Text);
            neighborhood = new double[2];
            neighborhood[0] = Double.Parse(textBoxMinBoundNeighborhood.Text);
            neighborhood[1] = Double.Parse(textBoxMaxBoundNeighborhood.Text);
        }

        private void ParseIntParams()
        {
            scoutsNum = Int32.Parse(textBoxNumScouts.Text);
            eliteBeeNum = Int32.Parse(textBoxNumElite.Text);
            workersBeeNum = Int32.Parse(textBoxNumWorkers.Text);
            numElitePlaces = Int32.Parse(textBoxNumElitePlace.Text);
            numGoodPlaces = Int32.Parse(textBoxNumGoodPlace.Text);
            numIterationAlg = Int32.Parse(textBoxNumIter.Text);
        }
    }
}
