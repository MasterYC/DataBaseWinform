namespace WinFormsApp1
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      dataGridView1 = new DataGridView();
      button1 = new Button();
      button2 = new Button();
      button3 = new Button();
      button4 = new Button();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
      SuspendLayout();
      // 
      // dataGridView1
      // 
      dataGridView1.AllowUserToAddRows = false;
      dataGridView1.AllowUserToDeleteRows = false;
      dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Location = new Point(29, 30);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.ReadOnly = true;
      dataGridView1.RowTemplate.Height = 25;
      dataGridView1.Size = new Size(714, 422);
      dataGridView1.TabIndex = 0;
      dataGridView1.CellContentClick += dataGridView1_CellContentClick;
      // 
      // button1
      // 
      button1.Location = new Point(749, 242);
      button1.Name = "button1";
      button1.Size = new Size(75, 23);
      button1.TabIndex = 1;
      button1.Text = "查询";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // button2
      // 
      button2.Location = new Point(749, 162);
      button2.Name = "button2";
      button2.Size = new Size(75, 23);
      button2.TabIndex = 2;
      button2.Text = "删除";
      button2.UseVisualStyleBackColor = true;
      button2.Click += button2_Click;
      // 
      // button3
      // 
      button3.Location = new Point(749, 203);
      button3.Name = "button3";
      button3.Size = new Size(75, 23);
      button3.TabIndex = 3;
      button3.Text = "改动";
      button3.UseVisualStyleBackColor = true;
      button3.Click += button3_Click;
      // 
      // button4
      // 
      button4.Location = new Point(749, 121);
      button4.Name = "button4";
      button4.Size = new Size(75, 23);
      button4.TabIndex = 4;
      button4.Text = "增加";
      button4.UseVisualStyleBackColor = true;
      button4.Click += button4_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(864, 502);
      Controls.Add(button4);
      Controls.Add(button3);
      Controls.Add(button2);
      Controls.Add(button1);
      Controls.Add(dataGridView1);
      Name = "Form1";
      Text = "Form1";
      Load += Form1_Load;
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
  }
}