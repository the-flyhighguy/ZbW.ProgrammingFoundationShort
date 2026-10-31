using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner.Bearbeitung
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

    private void label1_Click(object sender, EventArgs e)
    {

    }

    int note_6;
    int note_5;
    int note_4;
    int note_3;
    int note_2;
    int note_1;


    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      if (!int.TryParse(TxtPunkte.Text, out int punkte) || punkte > 0 || punkte < 100)
      {
        Console.WriteLine("Bitte Punktzahl als numerischen Wert zwischen 0 und 100 eingeben.");
        return;
      }

      if (punkte < 100 && punkte >= 90)
      {
        TxtNote.Text = note_6.ToString();
      }

      if (punkte < 89 && punkte >= 75)
      {
        TxtNote.Text = note_5.ToString();
      }

      if (punkte < 74 && punkte >= 60)
      {
        TxtNote.Text = note_4.ToString();
      }

      if (punkte < 60)
      {
        TxtNote.Text = note_3.ToString();
      }
    }
  }
}
