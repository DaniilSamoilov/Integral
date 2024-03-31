using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Integral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FunctionList.Items.AddRange(FunctionsForIntegration.FunctionDictionary.Keys.ToArray());
            FunctionList.SelectedItem = null;
            MethodsList.Items.AddRange(IntegralMethods.MethodsDictionary.Keys.ToArray());
            MethodsList.SelectedItem= null;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double leftborder = Convert.ToDouble(LeftBorder.Text);
            double rightborder = Convert.ToDouble(RightBorder.Text);
            int Splits = Convert.ToInt32(NumberOfSplits.Text);
            string SelectedFunction = FunctionList.Text;
            string SelectedMethod = MethodsList.Text;
            if (FunctionsForIntegration.FunctionDictionary.ContainsKey(SelectedFunction)&&
                IntegralMethods.MethodsDictionary.ContainsKey(SelectedMethod))
            {
                Stopwatch stopwatch= new Stopwatch();
                stopwatch.Start();
                double result = IntegralMethods.MethodsDictionary[SelectedMethod](FunctionsForIntegration.FunctionDictionary[SelectedFunction], leftborder, rightborder, Splits);
                stopwatch.Stop();
                IntegralResult.Text = result.ToString();
                RequiredTime.Text = stopwatch.Elapsed.ToString();
                double result2 = IntegralMethods.MethodsDictionary[SelectedMethod](FunctionsForIntegration.FunctionDictionary[SelectedFunction], leftborder, rightborder, Splits/2);
                double Accuracy = IntegralMethods.Runge(result, result2, IntegralMethods.RungePower[SelectedMethod]);
                deviation.Text = Accuracy.ToString();
            }
        }
    }
}
