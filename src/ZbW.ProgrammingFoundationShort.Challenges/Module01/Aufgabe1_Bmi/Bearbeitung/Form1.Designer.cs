namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe1_Bmi.Bearbeitung
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      TxtGewicht = new TextBox();
      TxtGrösse = new TextBox();
      TxtBmiResult = new TextBox();
      CmdCalculate = new Button();
      LblGewicht = new Label();
      LblGrösse = new Label();
      LblResultBmi = new Label();
      SuspendLayout();
      // 
      // TxtGewicht
      // 
      TxtGewicht.Location = new Point(107, 65);
      TxtGewicht.Name = "TxtGewicht";
      TxtGewicht.Size = new Size(150, 31);
      TxtGewicht.TabIndex = 0;
      TxtGewicht.TextChanged += textBox1_TextChanged;
      // 
      // TxtGrösse
      // 
      TxtGrösse.Location = new Point(310, 65);
      TxtGrösse.Name = "TxtGrösse";
      TxtGrösse.Size = new Size(150, 31);
      TxtGrösse.TabIndex = 1;
      // 
      // TxtBmiResult
      // 
      TxtBmiResult.Location = new Point(107, 224);
      TxtBmiResult.Name = "TxtBmiResult";
      TxtBmiResult.Size = new Size(196, 31);
      TxtBmiResult.TabIndex = 2;
      // 
      // CmdCalculate
      // 
      CmdCalculate.Location = new Point(107, 147);
      CmdCalculate.Name = "CmdCalculate";
      CmdCalculate.Size = new Size(123, 34);
      CmdCalculate.TabIndex = 3;
      CmdCalculate.Text = "Get me BMI";
      CmdCalculate.UseVisualStyleBackColor = true;
      CmdCalculate.Click += CmdCalculate_Click;
      // 
      // LblGewicht
      // 
      LblGewicht.AutoSize = true;
      LblGewicht.Location = new Point(107, 36);
      LblGewicht.Name = "LblGewicht";
      LblGewicht.Size = new Size(74, 25);
      LblGewicht.TabIndex = 4;
      LblGewicht.Text = "Gewicht";
      // 
      // LblGrösse
      // 
      LblGrösse.AutoSize = true;
      LblGrösse.Location = new Point(312, 37);
      LblGrösse.Name = "LblGrösse";
      LblGrösse.Size = new Size(118, 25);
      LblGrösse.TabIndex = 5;
      LblGrösse.Text = "Körpergrösse";
      LblGrösse.Click += label2_Click;
      // 
      // LblResultBmi
      // 
      LblResultBmi.AutoSize = true;
      LblResultBmi.Location = new Point(108, 198);
      LblResultBmi.Name = "LblResultBmi";
      LblResultBmi.Size = new Size(167, 25);
      LblResultBmi.TabIndex = 6;
      LblResultBmi.Text = "Ihr berechneter BMI";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(LblResultBmi);
      Controls.Add(LblGrösse);
      Controls.Add(LblGewicht);
      Controls.Add(CmdCalculate);
      Controls.Add(TxtBmiResult);
      Controls.Add(TxtGrösse);
      Controls.Add(TxtGewicht);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox TxtGewicht;
    private TextBox TxtGrösse;
    private TextBox TxtBmiResult;
    private Button CmdCalculate;
    private Label LblGewicht;
    private Label LblGrösse;
    private Label LblResultBmi;
  }
}