namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe2_Waehrungsrechner.Bearbeitung
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
      CmdConvert = new Button();
      TxtWährungIn = new TextBox();
      LblCurrencyIn = new Label();
      TxtBetragIn = new TextBox();
      LblAmmountIn = new Label();
      LblOut = new Label();
      SuspendLayout();
      // 
      // CmdConvert
      // 
      CmdConvert.Location = new Point(56, 133);
      CmdConvert.Name = "CmdConvert";
      CmdConvert.Size = new Size(112, 34);
      CmdConvert.TabIndex = 0;
      CmdConvert.Text = "Umrechnen";
      CmdConvert.UseVisualStyleBackColor = true;
      CmdConvert.Click += CmdConvert_Click;
      // 
      // TxtWährungIn
      // 
      TxtWährungIn.Location = new Point(56, 80);
      TxtWährungIn.Name = "TxtWährungIn";
      TxtWährungIn.Size = new Size(150, 31);
      TxtWährungIn.TabIndex = 1;
      TxtWährungIn.Text = "Euro / Chf";
      // 
      // LblCurrencyIn
      // 
      LblCurrencyIn.AutoSize = true;
      LblCurrencyIn.Location = new Point(56, 52);
      LblCurrencyIn.Name = "LblCurrencyIn";
      LblCurrencyIn.Size = new Size(84, 25);
      LblCurrencyIn.TabIndex = 2;
      LblCurrencyIn.Text = "Währung";
      // 
      // TxtBetragIn
      // 
      TxtBetragIn.Location = new Point(228, 80);
      TxtBetragIn.Name = "TxtBetragIn";
      TxtBetragIn.Size = new Size(311, 31);
      TxtBetragIn.TabIndex = 3;
      TxtBetragIn.Text = "Muss grösser als 0 sein";
      TxtBetragIn.TextChanged += textBox2_TextChanged;
      // 
      // LblAmmountIn
      // 
      LblAmmountIn.AutoSize = true;
      LblAmmountIn.Location = new Point(228, 52);
      LblAmmountIn.Name = "LblAmmountIn";
      LblAmmountIn.Size = new Size(63, 25);
      LblAmmountIn.TabIndex = 4;
      LblAmmountIn.Text = "Betrag";
      // 
      // LblOut
      // 
      LblOut.AutoSize = true;
      LblOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      LblOut.Location = new Point(62, 194);
      LblOut.Name = "LblOut";
      LblOut.Size = new Size(0, 25);
      LblOut.TabIndex = 5;
      LblOut.Visible = false;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(LblOut);
      Controls.Add(LblAmmountIn);
      Controls.Add(TxtBetragIn);
      Controls.Add(LblCurrencyIn);
      Controls.Add(TxtWährungIn);
      Controls.Add(CmdConvert);
      Name = "Form1";
      Text = "Währungsrechner";
      Load += Form1_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button CmdConvert;
    private TextBox TxtWährungIn;
    private Label LblCurrencyIn;
    private TextBox TxtBetragIn;
    private Label LblAmmountIn;
    private Label LblOut;
  }
}
