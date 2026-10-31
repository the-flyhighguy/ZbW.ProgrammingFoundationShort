namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner.Bearbeitung
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
      TxtPunkte = new TextBox();
      TxtNote = new TextBox();
      CmdCalcNote = new Button();
      LblPunkte = new Label();
      LblNote = new Label();
      SuspendLayout();
      // 
      // TxtPunkte
      // 
      TxtPunkte.Location = new Point(52, 70);
      TxtPunkte.Name = "TxtPunkte";
      TxtPunkte.Size = new Size(250, 47);
      TxtPunkte.TabIndex = 0;
      TxtPunkte.Text = "Punkte";
      TxtPunkte.TextChanged += textBox1_TextChanged;
      // 
      // TxtNote
      // 
      TxtNote.Location = new Point(52, 274);
      TxtNote.Name = "TxtNote";
      TxtNote.Size = new Size(250, 47);
      TxtNote.TabIndex = 1;
      // 
      // CmdCalcNote
      // 
      CmdCalcNote.Location = new Point(52, 150);
      CmdCalcNote.Name = "CmdCalcNote";
      CmdCalcNote.Size = new Size(250, 58);
      CmdCalcNote.TabIndex = 2;
      CmdCalcNote.Text = "Zu meiner Note";
      CmdCalcNote.UseVisualStyleBackColor = true;
      // 
      // LblPunkte
      // 
      LblPunkte.AutoSize = true;
      LblPunkte.Location = new Point(52, 26);
      LblPunkte.Name = "LblPunkte";
      LblPunkte.Size = new Size(446, 41);
      LblPunkte.TabIndex = 3;
      LblPunkte.Text = "Bitte gib hier deine Punktzhl ein:";
      LblPunkte.Click += label1_Click;
      // 
      // LblNote
      // 
      LblNote.AutoSize = true;
      LblNote.Location = new Point(52, 230);
      LblNote.Name = "LblNote";
      LblNote.Size = new Size(176, 41);
      LblNote.TabIndex = 4;
      LblNote.Text = "Deine Note:";
      LblNote.Click += label2_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(17F, 41F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1374, 906);
      Controls.Add(LblNote);
      Controls.Add(LblPunkte);
      Controls.Add(CmdCalcNote);
      Controls.Add(TxtNote);
      Controls.Add(TxtPunkte);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox TxtPunkte;
    private TextBox TxtNote;
    private Button CmdCalcNote;
    private Label LblPunkte;
    private Label LblNote;
  }
}