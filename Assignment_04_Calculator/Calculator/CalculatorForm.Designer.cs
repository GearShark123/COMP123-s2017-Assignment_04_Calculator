namespace Calculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.EqualButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.RemainderButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.XFactorialButton = new System.Windows.Forms.Button();
            this.QuadraticButton = new System.Windows.Forms.Button();
            this.SquareRootButton = new System.Windows.Forms.Button();
            this.Pow2Button = new System.Windows.Forms.Button();
            this.OneOverXButton = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.NegateButton = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.X1Label = new System.Windows.Forms.Label();
            this.ALabel = new System.Windows.Forms.Label();
            this.X1TextBox = new System.Windows.Forms.TextBox();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.BLabel = new System.Windows.Forms.Label();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.CLabel = new System.Windows.Forms.Label();
            this.X2TextBox = new System.Windows.Forms.TextBox();
            this.X2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTextBox.Location = new System.Drawing.Point(11, 47);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.ReadOnly = true;
            this.DisplayTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DisplayTextBox.Size = new System.Drawing.Size(324, 32);
            this.DisplayTextBox.TabIndex = 0;
            this.DisplayTextBox.Text = "0";
            this.DisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EqualButton
            // 
            this.EqualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualButton.Location = new System.Drawing.Point(245, 400);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(90, 39);
            this.EqualButton.TabIndex = 1;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionButton.Location = new System.Drawing.Point(245, 355);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(90, 39);
            this.AdditionButton.TabIndex = 2;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractionButton.Location = new System.Drawing.Point(245, 310);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(90, 39);
            this.SubtractionButton.TabIndex = 3;
            this.SubtractionButton.Text = "-";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.Location = new System.Drawing.Point(245, 265);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(90, 39);
            this.MultiplyButton.TabIndex = 4;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.Location = new System.Drawing.Point(245, 220);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(90, 39);
            this.DivideButton.TabIndex = 5;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // RemainderButton
            // 
            this.RemainderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainderButton.Location = new System.Drawing.Point(245, 175);
            this.RemainderButton.Name = "RemainderButton";
            this.RemainderButton.Size = new System.Drawing.Size(90, 39);
            this.RemainderButton.TabIndex = 6;
            this.RemainderButton.Text = "%";
            this.RemainderButton.UseVisualStyleBackColor = true;
            this.RemainderButton.Click += new System.EventHandler(this.RemainderButton_Click);
            // 
            // CButton
            // 
            this.CButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CButton.Location = new System.Drawing.Point(245, 130);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(90, 39);
            this.CButton.TabIndex = 7;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(11, 130);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(228, 39);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // XFactorialButton
            // 
            this.XFactorialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XFactorialButton.Location = new System.Drawing.Point(11, 175);
            this.XFactorialButton.Name = "XFactorialButton";
            this.XFactorialButton.Size = new System.Drawing.Size(72, 39);
            this.XFactorialButton.TabIndex = 9;
            this.XFactorialButton.Text = "X!";
            this.XFactorialButton.UseVisualStyleBackColor = true;
            this.XFactorialButton.Click += new System.EventHandler(this.XFactorialButton_Click);
            // 
            // QuadraticButton
            // 
            this.QuadraticButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuadraticButton.Location = new System.Drawing.Point(89, 175);
            this.QuadraticButton.Name = "QuadraticButton";
            this.QuadraticButton.Size = new System.Drawing.Size(150, 39);
            this.QuadraticButton.TabIndex = 10;
            this.QuadraticButton.Text = "aX^2+bX+c";
            this.QuadraticButton.UseVisualStyleBackColor = true;
            this.QuadraticButton.Click += new System.EventHandler(this.QuadraticButton_Click);
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareRootButton.Location = new System.Drawing.Point(11, 220);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(72, 39);
            this.SquareRootButton.TabIndex = 12;
            this.SquareRootButton.Text = "√";
            this.SquareRootButton.UseVisualStyleBackColor = true;
            this.SquareRootButton.Click += new System.EventHandler(this.SquareRootButton_Click);
            // 
            // Pow2Button
            // 
            this.Pow2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pow2Button.Location = new System.Drawing.Point(89, 220);
            this.Pow2Button.Name = "Pow2Button";
            this.Pow2Button.Size = new System.Drawing.Size(72, 39);
            this.Pow2Button.TabIndex = 13;
            this.Pow2Button.Text = "X^2";
            this.Pow2Button.UseVisualStyleBackColor = true;
            this.Pow2Button.Click += new System.EventHandler(this.Pow2Button_Click);
            // 
            // OneOverXButton
            // 
            this.OneOverXButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneOverXButton.Location = new System.Drawing.Point(166, 220);
            this.OneOverXButton.Name = "OneOverXButton";
            this.OneOverXButton.Size = new System.Drawing.Size(72, 39);
            this.OneOverXButton.TabIndex = 14;
            this.OneOverXButton.Text = "1/X";
            this.OneOverXButton.UseVisualStyleBackColor = true;
            this.OneOverXButton.Click += new System.EventHandler(this.OneOverXButton_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(11, 265);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(72, 39);
            this.button15.TabIndex = 15;
            this.button15.Text = "7";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Value);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(89, 265);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(72, 39);
            this.button16.TabIndex = 16;
            this.button16.Text = "8";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Value);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(167, 265);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(72, 39);
            this.button17.TabIndex = 17;
            this.button17.Text = "9";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Value);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(11, 310);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 39);
            this.button11.TabIndex = 18;
            this.button11.Text = "4";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Value);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(89, 310);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(72, 39);
            this.button18.TabIndex = 19;
            this.button18.Text = "5";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Value);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(167, 310);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(72, 39);
            this.button19.TabIndex = 20;
            this.button19.Text = "6";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.Value);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(11, 355);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(72, 39);
            this.button20.TabIndex = 21;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Value);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(89, 355);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(72, 39);
            this.button21.TabIndex = 22;
            this.button21.Text = "2";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.Value);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(167, 355);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(72, 39);
            this.button22.TabIndex = 23;
            this.button22.Text = "3";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.Value);
            // 
            // NegateButton
            // 
            this.NegateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegateButton.Location = new System.Drawing.Point(11, 400);
            this.NegateButton.Name = "NegateButton";
            this.NegateButton.Size = new System.Drawing.Size(72, 39);
            this.NegateButton.TabIndex = 24;
            this.NegateButton.Text = "±";
            this.NegateButton.UseVisualStyleBackColor = true;
            this.NegateButton.Click += new System.EventHandler(this.NegateButton_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(89, 400);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(72, 39);
            this.button24.TabIndex = 25;
            this.button24.Text = "0";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.Value);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(167, 400);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(72, 39);
            this.button25.TabIndex = 26;
            this.button25.Text = ".";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.Value);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(245, 85);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(90, 39);
            this.CalculateButton.TabIndex = 27;
            this.CalculateButton.Text = "Calc";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Visible = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // X1Label
            // 
            this.X1Label.AutoSize = true;
            this.X1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1Label.Location = new System.Drawing.Point(12, 91);
            this.X1Label.Name = "X1Label";
            this.X1Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.X1Label.Size = new System.Drawing.Size(58, 26);
            this.X1Label.TabIndex = 29;
            this.X1Label.Text = "X1 =";
            this.X1Label.Visible = false;
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALabel.Location = new System.Drawing.Point(11, 18);
            this.ALabel.Name = "ALabel";
            this.ALabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ALabel.Size = new System.Drawing.Size(43, 26);
            this.ALabel.TabIndex = 32;
            this.ALabel.Text = "a =";
            this.ALabel.Visible = false;
            // 
            // X1TextBox
            // 
            this.X1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1TextBox.Location = new System.Drawing.Point(76, 85);
            this.X1TextBox.Name = "X1TextBox";
            this.X1TextBox.ReadOnly = true;
            this.X1TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.X1TextBox.Size = new System.Drawing.Size(34, 32);
            this.X1TextBox.TabIndex = 33;
            this.X1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.X1TextBox.Visible = false;
            // 
            // ATextBox
            // 
            this.ATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATextBox.Location = new System.Drawing.Point(60, 9);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ATextBox.Size = new System.Drawing.Size(34, 32);
            this.ATextBox.TabIndex = 34;
            this.ATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ATextBox.Visible = false;
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLabel.Location = new System.Drawing.Point(111, 18);
            this.BLabel.Name = "BLabel";
            this.BLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BLabel.Size = new System.Drawing.Size(43, 26);
            this.BLabel.TabIndex = 35;
            this.BLabel.Text = "b =";
            this.BLabel.Visible = false;
            // 
            // BTextBox
            // 
            this.BTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTextBox.Location = new System.Drawing.Point(160, 9);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTextBox.Size = new System.Drawing.Size(34, 32);
            this.BTextBox.TabIndex = 36;
            this.BTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTextBox.Visible = false;
            // 
            // CTextBox
            // 
            this.CTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTextBox.Location = new System.Drawing.Point(254, 9);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CTextBox.Size = new System.Drawing.Size(34, 32);
            this.CTextBox.TabIndex = 39;
            this.CTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CTextBox.Visible = false;
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLabel.Location = new System.Drawing.Point(206, 18);
            this.CLabel.Name = "CLabel";
            this.CLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CLabel.Size = new System.Drawing.Size(42, 26);
            this.CLabel.TabIndex = 38;
            this.CLabel.Text = "c =";
            this.CLabel.Visible = false;
            // 
            // X2TextBox
            // 
            this.X2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2TextBox.Location = new System.Drawing.Point(191, 85);
            this.X2TextBox.Name = "X2TextBox";
            this.X2TextBox.ReadOnly = true;
            this.X2TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.X2TextBox.Size = new System.Drawing.Size(34, 32);
            this.X2TextBox.TabIndex = 41;
            this.X2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.X2TextBox.Visible = false;
            // 
            // X2Label
            // 
            this.X2Label.AutoSize = true;
            this.X2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2Label.Location = new System.Drawing.Point(127, 91);
            this.X2Label.Name = "X2Label";
            this.X2Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.X2Label.Size = new System.Drawing.Size(58, 26);
            this.X2Label.TabIndex = 40;
            this.X2Label.Text = "X2 =";
            this.X2Label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 452);
            this.Controls.Add(this.X2TextBox);
            this.Controls.Add(this.X2Label);
            this.Controls.Add(this.CTextBox);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.X1TextBox);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.X1Label);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.NegateButton);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.OneOverXButton);
            this.Controls.Add(this.Pow2Button);
            this.Controls.Add(this.SquareRootButton);
            this.Controls.Add(this.QuadraticButton);
            this.Controls.Add(this.XFactorialButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.RemainderButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractionButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.DisplayTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button RemainderButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button XFactorialButton;
        private System.Windows.Forms.Button QuadraticButton;
        private System.Windows.Forms.Button SquareRootButton;
        private System.Windows.Forms.Button Pow2Button;
        private System.Windows.Forms.Button OneOverXButton;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button NegateButton;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label X1Label;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.TextBox X1TextBox;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.TextBox CTextBox;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.TextBox X2TextBox;
        private System.Windows.Forms.Label X2Label;
    }
}

