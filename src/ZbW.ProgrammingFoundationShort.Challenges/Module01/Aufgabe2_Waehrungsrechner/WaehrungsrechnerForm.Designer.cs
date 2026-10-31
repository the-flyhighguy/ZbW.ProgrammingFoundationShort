namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe2_Waehrungsrechner;

partial class WaehrungsrechnerForm
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
    LblBetrag = new Label();
    TxtBetrag = new TextBox();
    CmdChfToEur = new Button();
    CmdEurToChf = new Button();
    LblErgebnis = new Label();
    LblKurs = new Label();
    SuspendLayout();
    // 
    // LblBetrag
    // 
    LblBetrag.AutoSize = true;
    LblBetrag.Location = new Point(17, 30);
    LblBetrag.Margin = new Padding(4, 0, 4, 0);
    LblBetrag.Name = "LblBetrag";
    LblBetrag.Size = new Size(67, 25);
    LblBetrag.TabIndex = 0;
    LblBetrag.Text = "Betrag:";
    // 
    // TxtBetrag
    // 
    TxtBetrag.Location = new Point(114, 25);
    TxtBetrag.Margin = new Padding(4, 5, 4, 5);
    TxtBetrag.Name = "TxtBetrag";
    TxtBetrag.Size = new Size(170, 31);
    TxtBetrag.TabIndex = 1;
    TxtBetrag.Text = "2";
    // 
    // CmdChfToEur
    // 
    CmdChfToEur.Location = new Point(17, 92);
    CmdChfToEur.Margin = new Padding(4, 5, 4, 5);
    CmdChfToEur.Name = "CmdChfToEur";
    CmdChfToEur.Size = new Size(186, 47);
    CmdChfToEur.TabIndex = 2;
    CmdChfToEur.Text = "CHF → EUR";
    CmdChfToEur.Click += CmdChfToEur_Click;
    // 
    // CmdEurToChf
    // 
    CmdEurToChf.Location = new Point(221, 92);
    CmdEurToChf.Margin = new Padding(4, 5, 4, 5);
    CmdEurToChf.Name = "CmdEurToChf";
    CmdEurToChf.Size = new Size(186, 47);
    CmdEurToChf.TabIndex = 3;
    CmdEurToChf.Text = "EUR → CHF";
    CmdEurToChf.Click += CmdEurToChf_Click;
    // 
    // LblErgebnis
    // 
    LblErgebnis.AutoSize = true;
    LblErgebnis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblErgebnis.Location = new Point(17, 167);
    LblErgebnis.Margin = new Padding(4, 0, 4, 0);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new Size(0, 28);
    LblErgebnis.TabIndex = 4;
    // 
    // LblKurs
    // 
    LblKurs.AutoSize = true;
    LblKurs.ForeColor = SystemColors.GrayText;
    LblKurs.Location = new Point(17, 217);
    LblKurs.Margin = new Padding(4, 0, 4, 0);
    LblKurs.Name = "LblKurs";
    LblKurs.Size = new Size(196, 25);
    LblKurs.TabIndex = 5;
    LblKurs.Text = "Kurs: 1 EUR = 1.05 CHF";
    // 
    // WaehrungsrechnerForm
    // 
    AutoScaleDimensions = new SizeF(10F, 25F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(514, 267);
    Controls.Add(LblBetrag);
    Controls.Add(TxtBetrag);
    Controls.Add(CmdChfToEur);
    Controls.Add(CmdEurToChf);
    Controls.Add(LblErgebnis);
    Controls.Add(LblKurs);
    Margin = new Padding(4, 5, 4, 5);
    Name = "WaehrungsrechnerForm";
    Text = "Währungsrechner – Aufgabe 2";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblBetrag;
  private TextBox TxtBetrag;
  private Button CmdChfToEur;
  private Button CmdEurToChf;
  private Label LblErgebnis;
  private Label LblKurs;
}
