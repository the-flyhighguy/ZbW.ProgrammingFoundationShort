namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe1_Bmi;

partial class BmiForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblGewicht = new Label();
    TxtGewicht = new TextBox();
    LblGewichtEinheit = new Label();
    LblGroesse = new Label();
    TxtGroesse = new TextBox();
    LblGroesseEinheit = new Label();
    CmdBerechnen = new Button();
    LblErgebnis = new Label();
    SuspendLayout();
    // 
    // LblGewicht
    // 
    LblGewicht.AutoSize = true;
    LblGewicht.Location = new Point(17, 30);
    LblGewicht.Margin = new Padding(4, 0, 4, 0);
    LblGewicht.Name = "LblGewicht";
    LblGewicht.Size = new Size(78, 25);
    LblGewicht.TabIndex = 0;
    LblGewicht.Text = "Gewicht:";
    // 
    // TxtGewicht
    // 
    TxtGewicht.Location = new Point(171, 25);
    TxtGewicht.Margin = new Padding(4, 5, 4, 5);
    TxtGewicht.Name = "TxtGewicht";
    TxtGewicht.Size = new Size(141, 31);
    TxtGewicht.TabIndex = 1;
    TxtGewicht.TextChanged += TxtGewicht_TextChanged;
    // 
    // LblGewichtEinheit
    // 
    LblGewichtEinheit.AutoSize = true;
    LblGewichtEinheit.Location = new Point(326, 30);
    LblGewichtEinheit.Margin = new Padding(4, 0, 4, 0);
    LblGewichtEinheit.Name = "LblGewichtEinheit";
    LblGewichtEinheit.Size = new Size(32, 25);
    LblGewichtEinheit.TabIndex = 2;
    LblGewichtEinheit.Text = "kg";
    // 
    // LblGroesse
    // 
    LblGroesse.AutoSize = true;
    LblGroesse.Location = new Point(17, 88);
    LblGroesse.Margin = new Padding(4, 0, 4, 0);
    LblGroesse.Name = "LblGroesse";
    LblGroesse.Size = new Size(70, 25);
    LblGroesse.TabIndex = 3;
    LblGroesse.Text = "Grösse:";
    // 
    // TxtGroesse
    // 
    TxtGroesse.Location = new Point(171, 83);
    TxtGroesse.Margin = new Padding(4, 5, 4, 5);
    TxtGroesse.Name = "TxtGroesse";
    TxtGroesse.Size = new Size(141, 31);
    TxtGroesse.TabIndex = 4;
    // 
    // LblGroesseEinheit
    // 
    LblGroesseEinheit.AutoSize = true;
    LblGroesseEinheit.Location = new Point(326, 88);
    LblGroesseEinheit.Margin = new Padding(4, 0, 4, 0);
    LblGroesseEinheit.Name = "LblGroesseEinheit";
    LblGroesseEinheit.Size = new Size(113, 25);
    LblGroesseEinheit.TabIndex = 5;
    LblGroesseEinheit.Text = "m (z. B. 1.78)";
    // 
    // CmdBerechnen
    // 
    CmdBerechnen.Location = new Point(171, 142);
    CmdBerechnen.Margin = new Padding(4, 5, 4, 5);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(186, 47);
    CmdBerechnen.TabIndex = 6;
    CmdBerechnen.Text = "BMI berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;
    // 
    // LblErgebnis
    // 
    LblErgebnis.AutoSize = true;
    LblErgebnis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblErgebnis.Location = new Point(17, 208);
    LblErgebnis.Margin = new Padding(4, 0, 4, 0);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new Size(0, 28);
    LblErgebnis.TabIndex = 7;
    // 
    // BmiForm
    // 
    AutoScaleDimensions = new SizeF(10F, 25F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(571, 267);
    Controls.Add(LblGewicht);
    Controls.Add(TxtGewicht);
    Controls.Add(LblGewichtEinheit);
    Controls.Add(LblGroesse);
    Controls.Add(TxtGroesse);
    Controls.Add(LblGroesseEinheit);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblErgebnis);
    Margin = new Padding(4, 5, 4, 5);
    Name = "BmiForm";
    Text = "BMI-Rechner – Aufgabe 1";
    Load += BmiForm_Load;
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblGewicht;
  private TextBox TxtGewicht;
  private Label LblGewichtEinheit;
  private Label LblGroesse;
  private TextBox TxtGroesse;
  private Label LblGroesseEinheit;
  private Button CmdBerechnen;
  private Label LblErgebnis;
}
