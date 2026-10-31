namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner;

partial class NotenrechnerForm
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
    LblPunkte = new Label();
    TxtPunkte = new TextBox();
    CmdBerechnen = new Button();
    LblNote = new Label();
    LblBewertung = new Label();
    SuspendLayout();
    // 
    // LblPunkte
    // 
    LblPunkte.AutoSize = true;
    LblPunkte.Location = new Point(29, 55);
    LblPunkte.Margin = new Padding(7, 0, 7, 0);
    LblPunkte.Name = "LblPunkte";
    LblPunkte.Size = new Size(222, 41);
    LblPunkte.TabIndex = 0;
    LblPunkte.Text = "Punkte (0–100):";
    // 
    // TxtPunkte
    // 
    TxtPunkte.Location = new Point(340, 46);
    TxtPunkte.Margin = new Padding(7, 8, 7, 8);
    TxtPunkte.Name = "TxtPunkte";
    TxtPunkte.Size = new Size(189, 47);
    TxtPunkte.TabIndex = 1;
    TxtPunkte.TextChanged += TxtPunkte_TextChanged;
    // 
    // CmdBerechnen
    // 
    CmdBerechnen.Location = new Point(340, 137);
    CmdBerechnen.Margin = new Padding(7, 8, 7, 8);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(316, 77);
    CmdBerechnen.TabIndex = 2;
    CmdBerechnen.Text = "Note berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;
    // 
    // LblNote
    // 
    LblNote.AutoSize = true;
    LblNote.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
    LblNote.Location = new Point(29, 246);
    LblNote.Margin = new Padding(7, 0, 7, 0);
    LblNote.Name = "LblNote";
    LblNote.Size = new Size(0, 54);
    LblNote.TabIndex = 3;
    // 
    // LblBewertung
    // 
    LblBewertung.AutoSize = true;
    LblBewertung.Location = new Point(29, 323);
    LblBewertung.Margin = new Padding(7, 0, 7, 0);
    LblBewertung.Name = "LblBewertung";
    LblBewertung.Size = new Size(0, 41);
    LblBewertung.TabIndex = 4;
    // 
    // NotenrechnerForm
    // 
    AutoScaleDimensions = new SizeF(17F, 41F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(777, 410);
    Controls.Add(LblPunkte);
    Controls.Add(TxtPunkte);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblNote);
    Controls.Add(LblBewertung);
    Margin = new Padding(7, 8, 7, 8);
    Name = "NotenrechnerForm";
    Text = "Notenrechner – Auftrag 1";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblPunkte;
  private TextBox TxtPunkte;
  private Button CmdBerechnen;
  private Label LblNote;
  private Label LblBewertung;
}
