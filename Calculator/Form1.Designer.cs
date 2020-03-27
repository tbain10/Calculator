////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////
///name     date        description
///baint    1-22-19     calculator program created
///baint    1-24-19     layout for calc created
///baint    1-29-19     operators created
///baint    2-1-19      decimal functionality created

namespace Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.decimalBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.positiveNegativeBtn = new System.Windows.Forms.Button();
            this.additionBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.subtractBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.numberBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.clearEntryBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.equalsBtn, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.decimalBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.zeroBtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.positiveNegativeBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.additionBtn, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.threeBtn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.twoBtn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.oneBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.subtractBtn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.sixBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.fourBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.multiplyBtn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.nineBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.eightBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sevenBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.divideBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.backBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.clearBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.display, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearEntryBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 694);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // equalsBtn
            // 
            this.equalsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsBtn.Location = new System.Drawing.Point(711, 565);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(230, 126);
            this.equalsBtn.TabIndex = 20;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = true;
            this.equalsBtn.Click += new System.EventHandler(this.equalsBtn_Click);
            // 
            // decimalBtn
            // 
            this.decimalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalBtn.Location = new System.Drawing.Point(475, 565);
            this.decimalBtn.Name = "decimalBtn";
            this.decimalBtn.Size = new System.Drawing.Size(230, 126);
            this.decimalBtn.TabIndex = 19;
            this.decimalBtn.Text = ".";
            this.decimalBtn.UseVisualStyleBackColor = true;
            this.decimalBtn.Click += new System.EventHandler(this.decimalBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.Location = new System.Drawing.Point(239, 565);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(230, 126);
            this.zeroBtn.TabIndex = 18;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // positiveNegativeBtn
            // 
            this.positiveNegativeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positiveNegativeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveNegativeBtn.Location = new System.Drawing.Point(3, 565);
            this.positiveNegativeBtn.Name = "positiveNegativeBtn";
            this.positiveNegativeBtn.Size = new System.Drawing.Size(230, 126);
            this.positiveNegativeBtn.TabIndex = 17;
            this.positiveNegativeBtn.Text = "+/-";
            this.positiveNegativeBtn.UseVisualStyleBackColor = true;
            this.positiveNegativeBtn.Click += new System.EventHandler(this.positiveNegativeBtn_Click);
            // 
            // additionBtn
            // 
            this.additionBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionBtn.Location = new System.Drawing.Point(711, 437);
            this.additionBtn.Name = "additionBtn";
            this.additionBtn.Size = new System.Drawing.Size(230, 122);
            this.additionBtn.TabIndex = 16;
            this.additionBtn.Text = "+";
            this.additionBtn.UseVisualStyleBackColor = true;
            this.additionBtn.Click += new System.EventHandler(this.operatorBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.Location = new System.Drawing.Point(475, 437);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(230, 122);
            this.threeBtn.TabIndex = 15;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.Location = new System.Drawing.Point(239, 437);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(230, 122);
            this.twoBtn.TabIndex = 14;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.Location = new System.Drawing.Point(3, 437);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(230, 122);
            this.oneBtn.TabIndex = 13;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // subtractBtn
            // 
            this.subtractBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractBtn.Location = new System.Drawing.Point(711, 309);
            this.subtractBtn.Name = "subtractBtn";
            this.subtractBtn.Size = new System.Drawing.Size(230, 122);
            this.subtractBtn.TabIndex = 12;
            this.subtractBtn.Text = "-";
            this.subtractBtn.UseVisualStyleBackColor = true;
            this.subtractBtn.Click += new System.EventHandler(this.operatorBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.Location = new System.Drawing.Point(475, 309);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(230, 122);
            this.sixBtn.TabIndex = 11;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // numberBtn
            // 
            this.numberBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBtn.Location = new System.Drawing.Point(239, 309);
            this.numberBtn.Name = "numberBtn";
            this.numberBtn.Size = new System.Drawing.Size(230, 122);
            this.numberBtn.TabIndex = 10;
            this.numberBtn.Text = "5";
            this.numberBtn.UseVisualStyleBackColor = true;
            this.numberBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.Location = new System.Drawing.Point(3, 309);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(230, 122);
            this.fourBtn.TabIndex = 9;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.Location = new System.Drawing.Point(711, 181);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(230, 122);
            this.multiplyBtn.TabIndex = 8;
            this.multiplyBtn.Text = "*";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.operatorBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.Location = new System.Drawing.Point(475, 181);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(230, 122);
            this.nineBtn.TabIndex = 7;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.Location = new System.Drawing.Point(239, 181);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(230, 122);
            this.eightBtn.TabIndex = 6;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.Location = new System.Drawing.Point(3, 181);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(230, 122);
            this.sevenBtn.TabIndex = 5;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Location = new System.Drawing.Point(711, 53);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(230, 122);
            this.divideBtn.TabIndex = 4;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.operatorBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(475, 53);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(230, 122);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "<<";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(239, 53);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(230, 122);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // display
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.display, 4);
            this.display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display.Enabled = false;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(3, 3);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(938, 44);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            // 
            // clearEntryBtn
            // 
            this.clearEntryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearEntryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntryBtn.Location = new System.Drawing.Point(3, 53);
            this.clearEntryBtn.Name = "clearEntryBtn";
            this.clearEntryBtn.Size = new System.Drawing.Size(230, 122);
            this.clearEntryBtn.TabIndex = 1;
            this.clearEntryBtn.Text = "CE";
            this.clearEntryBtn.UseVisualStyleBackColor = true;
            this.clearEntryBtn.Click += new System.EventHandler(this.clearEntryBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 694);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1095, 750);
            this.MinimumSize = new System.Drawing.Size(424, 541);
            this.Name = "Form1";
            this.Text = "TINFO 200 - Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button equalsBtn;
        private System.Windows.Forms.Button decimalBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button positiveNegativeBtn;
        private System.Windows.Forms.Button additionBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button subtractBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button numberBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button clearEntryBtn;
    }
}

