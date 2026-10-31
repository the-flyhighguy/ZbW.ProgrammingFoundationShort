using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe1_Bmi.Bearbeitung
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void CmdCalculate_Click(object sender, EventArgs e)
    {
      if (!double.TryParse(TxtGewicht.Text ?? "", out double weight))
      {
        Console.WriteLine("Ungültige Zahl.");
        return;
      }

      if (!double.TryParse(TxtGrösse.Text ?? "", out double height))
      {
        Console.WriteLine("Ungültige Zahl.");
        return;
      }
      double tempResult = weight / (height * height);
      TxtBmiResult.Text = Convert.ToString(tempResult);
    }
  }
}
