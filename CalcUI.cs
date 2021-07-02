using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
	/// <summary>
	/// Summary description for CalcUI.
	/// </summary>
	public class CalcUI : System.Windows.Forms.Form
	{
        public void ResizeForm (int x, int y)
        {
            this.Size = new Size(x, y);
            this.Refresh();
        }

        public void ResizeButton (Button b, int x, int y)
        {
           // this.b.Size = new Size(x, y);
           // this.KeyPowered.Size = new System.Drawing.Size(60, 60);
        }
       
      
        //AboutForm myF3;
        MenuForm mForm;

		private System.Windows.Forms.Button KeyExit;
		private System.Windows.Forms.Button KeyDate;
		private System.Windows.Forms.TextBox OutputDisplay;
		private System.Windows.Forms.Button KeyClear;
		private System.Windows.Forms.Button KeyMinus;
		private System.Windows.Forms.Button KeyPlus;
		private System.Windows.Forms.Button KeyEqual;
		private System.Windows.Forms.Button KeyMultiply;
		private System.Windows.Forms.Button KeyDivide;
		private System.Windows.Forms.Button KeyPoint;
		private System.Windows.Forms.Button KeySign;
		private System.Windows.Forms.Button KeyZero;
		private System.Windows.Forms.Button KeyNine;
		private System.Windows.Forms.Button KeyEight;
		private System.Windows.Forms.Button KeySeven;
		private System.Windows.Forms.Button KeySix;
		private System.Windows.Forms.Button KeyFive;
		private System.Windows.Forms.Button KeyFour;
		private System.Windows.Forms.Button KeyThree;
		private System.Windows.Forms.Button KeyTwo;
		private System.Windows.Forms.Button KeyOne;

		// Output Display Constants.
		private const string oneOut = "1";
		private const string twoOut = "2";
		private const string threeOut = "3";
		private const string fourOut = "4";
		private const string fiveOut = "5";
		private const string sixOut = "6";
		private const string sevenOut = "7";
		private const string eightOut = "8";
		private const string nineOut = "9";
		private const string zeroOut = "0";
        private Button KeyOppositeValue;
        private Button button3;
        private Button KeySquaredNum;
        private Button button5;
        private Button KeyPowered;
        private Button button7;
        private Button KeySqrt;
        private CheckBox menuCheckBox;
        private Panel panel1;
        private Panel extraPanel;
        private Button KeyCubeRoot;
        private Button KeyFactorial;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        private void DisableControls()
        {
            KeyOppositeValue.Enabled = false;
            KeySquaredNum.Enabled = false;
            KeyPowered.Enabled = false;
            KeySqrt.Enabled = false;
            KeyDivide.Enabled = false;
            KeyMultiply.Enabled = false;
            KeyMinus.Enabled = false;
            KeyPlus.Enabled = false;
            KeyEqual.Enabled = false;
            KeyDate.Enabled = false;
            KeySign.Enabled = false;
            KeyFactorial.Enabled = false;
            KeyCubeRoot.Enabled = false;
            KeyZero.Enabled = false;
            KeyOne.Enabled = false;
            KeyTwo.Enabled = false;
            KeyThree.Enabled = false;
            KeyFour.Enabled = false;
            KeyFive.Enabled = false;
            KeySix.Enabled = false;
            KeySeven.Enabled = false;
            KeyEight.Enabled = false;
            KeyNine.Enabled = false;
            KeySign.Enabled = false;
            KeyPoint.Enabled = false;

        }

        private void EnableControls()
        {
            KeyOppositeValue.Enabled = true;
            KeySquaredNum.Enabled = true;
            KeyPowered.Enabled = true;
            KeySqrt.Enabled = true;
            KeyDivide.Enabled = true;
            KeyMultiply.Enabled = true;
            KeyMinus.Enabled = true;
            KeyPlus.Enabled = true;
            KeyEqual.Enabled = true;
            KeyDate.Enabled = true;
            KeySign.Enabled = true;
            KeyFactorial.Enabled = true;
            KeyCubeRoot.Enabled = true;
            KeyZero.Enabled = true;
            KeyOne.Enabled = true;
            KeyTwo.Enabled = true;
            KeyThree.Enabled = true;
            KeyFour.Enabled = true;
            KeyFive.Enabled = true;
            KeySix.Enabled = true;
            KeySeven.Enabled = true;
            KeyEight.Enabled = true;
            KeyNine.Enabled = true;
            KeySign.Enabled = true;
            KeyPoint.Enabled = true;
        }

        public CalcUI()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent(); 
            this.Size = new Size(372, 440);

            mForm = new MenuForm();
            //zeroDevider = new ZeroDevider();
            //zeroDevider.StartPosition = FormStartPosition.Manual;
            //zeroDevider.Location = new Point(this.Location.X, this.Location.Y);
            //zeroDevider.Show();

            //
            // Get version information from the Calculator Module.
            //

            //VersionInfo.Text = CalcEngine.GetVersion();
            //OutputDisplay.Text = "0";
		}

        public void ChangeSize(int w, int h)
        {
            this.Size = new Size(w, h);
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcUI));
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.KeyOppositeValue = new System.Windows.Forms.Button();
            this.KeySquaredNum = new System.Windows.Forms.Button();
            this.KeyPowered = new System.Windows.Forms.Button();
            this.KeySqrt = new System.Windows.Forms.Button();
            this.menuCheckBox = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.extraPanel = new System.Windows.Forms.Panel();
            this.KeyCubeRoot = new System.Windows.Forms.Button();
            this.KeyFactorial = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.extraPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KeyDate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyDate.Location = new System.Drawing.Point(250, 64);
            this.KeyDate.Margin = new System.Windows.Forms.Padding(1);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(98, 60);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.KeyDate.UseVisualStyleBackColor = false;
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeyOne.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyOne.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyOne.Location = new System.Drawing.Point(2, 188);
            this.KeyOne.Margin = new System.Windows.Forms.Padding(1);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(60, 60);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.UseVisualStyleBackColor = false;
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // KeySix
            // 
            this.KeySix.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeySix.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeySix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeySix.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeySix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeySix.Location = new System.Drawing.Point(126, 126);
            this.KeySix.Margin = new System.Windows.Forms.Padding(1);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(60, 60);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.UseVisualStyleBackColor = false;
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeyFive.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyFive.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyFive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyFive.Location = new System.Drawing.Point(64, 126);
            this.KeyFive.Margin = new System.Windows.Forms.Padding(1);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(60, 60);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.UseVisualStyleBackColor = false;
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.KeyEqual.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyEqual.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyEqual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyEqual.Location = new System.Drawing.Point(250, 188);
            this.KeyEqual.Margin = new System.Windows.Forms.Padding(1);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(98, 122);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.KeyEqual.UseVisualStyleBackColor = false;
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeyTwo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyTwo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTwo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyTwo.Location = new System.Drawing.Point(64, 188);
            this.KeyTwo.Margin = new System.Windows.Forms.Padding(1);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(60, 60);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.UseVisualStyleBackColor = false;
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeyZero.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyZero.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyZero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyZero.Location = new System.Drawing.Point(64, 250);
            this.KeyZero.Margin = new System.Windows.Forms.Padding(1);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(60, 60);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.UseVisualStyleBackColor = false;
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeyThree.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyThree.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyThree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyThree.Location = new System.Drawing.Point(126, 188);
            this.KeyThree.Margin = new System.Windows.Forms.Padding(1);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(60, 60);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.UseVisualStyleBackColor = false;
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KeyPlus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyPlus.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPlus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyPlus.Location = new System.Drawing.Point(188, 250);
            this.KeyPlus.Margin = new System.Windows.Forms.Padding(1);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(60, 60);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.KeyPlus.UseVisualStyleBackColor = false;
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeySign
            // 
            this.KeySign.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeySign.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeySign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeySign.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeySign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeySign.Location = new System.Drawing.Point(2, 250);
            this.KeySign.Margin = new System.Windows.Forms.Padding(1);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(60, 60);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.KeySign.UseVisualStyleBackColor = false;
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeySeven.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeySeven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.KeySeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeySeven.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeySeven.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeySeven.Location = new System.Drawing.Point(2, 64);
            this.KeySeven.Margin = new System.Windows.Forms.Padding(1);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(60, 60);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.UseVisualStyleBackColor = false;
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeyPoint.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyPoint.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPoint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyPoint.Location = new System.Drawing.Point(126, 250);
            this.KeyPoint.Margin = new System.Windows.Forms.Padding(1);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(60, 60);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ",";
            this.KeyPoint.UseVisualStyleBackColor = false;
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeyNine.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyNine.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyNine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyNine.Location = new System.Drawing.Point(126, 64);
            this.KeyNine.Margin = new System.Windows.Forms.Padding(1);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(60, 60);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.UseVisualStyleBackColor = false;
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OutputDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputDisplay.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputDisplay.Location = new System.Drawing.Point(11, 76);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(452, 36);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KeyMinus
            // 
            this.KeyMinus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KeyMinus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyMinus.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyMinus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyMinus.Location = new System.Drawing.Point(188, 188);
            this.KeyMinus.Margin = new System.Windows.Forms.Padding(1);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(60, 60);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.KeyMinus.UseVisualStyleBackColor = false;
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeyEight.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyEight.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyEight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyEight.Location = new System.Drawing.Point(64, 64);
            this.KeyEight.Margin = new System.Windows.Forms.Padding(1);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(60, 60);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.UseVisualStyleBackColor = false;
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KeyMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyMultiply.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyMultiply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyMultiply.Location = new System.Drawing.Point(188, 126);
            this.KeyMultiply.Margin = new System.Windows.Forms.Padding(1);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(60, 60);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "x";
            this.KeyMultiply.UseVisualStyleBackColor = false;
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeyFour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyFour.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyFour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyFour.Location = new System.Drawing.Point(2, 126);
            this.KeyFour.Margin = new System.Windows.Forms.Padding(1);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(60, 60);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.UseVisualStyleBackColor = false;
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KeyClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyClear.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyClear.Location = new System.Drawing.Point(250, 126);
            this.KeyClear.Margin = new System.Windows.Forms.Padding(1);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(98, 60);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.KeyClear.UseVisualStyleBackColor = false;
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KeyDivide.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyDivide.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyDivide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyDivide.Location = new System.Drawing.Point(188, 64);
            this.KeyDivide.Margin = new System.Windows.Forms.Padding(1);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(60, 60);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.KeyDivide.UseVisualStyleBackColor = false;
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // KeyOppositeValue
            // 
            this.KeyOppositeValue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KeyOppositeValue.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyOppositeValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyOppositeValue.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyOppositeValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyOppositeValue.Location = new System.Drawing.Point(2, 2);
            this.KeyOppositeValue.Margin = new System.Windows.Forms.Padding(1);
            this.KeyOppositeValue.Name = "KeyOppositeValue";
            this.KeyOppositeValue.Size = new System.Drawing.Size(60, 60);
            this.KeyOppositeValue.TabIndex = 15;
            this.KeyOppositeValue.TabStop = false;
            this.KeyOppositeValue.Text = "1/x";
            this.KeyOppositeValue.UseVisualStyleBackColor = false;
            this.KeyOppositeValue.Click += new System.EventHandler(this.KeyOppositeValue_Click);
            // 
            // KeySquaredNum
            // 
            this.KeySquaredNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KeySquaredNum.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeySquaredNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeySquaredNum.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeySquaredNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeySquaredNum.Location = new System.Drawing.Point(64, 2);
            this.KeySquaredNum.Margin = new System.Windows.Forms.Padding(1);
            this.KeySquaredNum.Name = "KeySquaredNum";
            this.KeySquaredNum.Size = new System.Drawing.Size(60, 60);
            this.KeySquaredNum.TabIndex = 15;
            this.KeySquaredNum.TabStop = false;
            this.KeySquaredNum.Text = "x²";
            this.KeySquaredNum.UseVisualStyleBackColor = false;
            this.KeySquaredNum.Click += new System.EventHandler(this.KeySquaredNum_Click);
            // 
            // KeyPowered
            // 
            this.KeyPowered.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KeyPowered.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyPowered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyPowered.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPowered.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyPowered.Location = new System.Drawing.Point(126, 2);
            this.KeyPowered.Margin = new System.Windows.Forms.Padding(1);
            this.KeyPowered.Name = "KeyPowered";
            this.KeyPowered.Size = new System.Drawing.Size(60, 60);
            this.KeyPowered.TabIndex = 15;
            this.KeyPowered.TabStop = false;
            this.KeyPowered.Text = "xʸ ";
            this.KeyPowered.UseVisualStyleBackColor = false;
            this.KeyPowered.Click += new System.EventHandler(this.KeyPowered_Click);
            // 
            // KeySqrt
            // 
            this.KeySqrt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KeySqrt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeySqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeySqrt.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeySqrt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeySqrt.Location = new System.Drawing.Point(188, 2);
            this.KeySqrt.Margin = new System.Windows.Forms.Padding(1);
            this.KeySqrt.Name = "KeySqrt";
            this.KeySqrt.Size = new System.Drawing.Size(160, 60);
            this.KeySqrt.TabIndex = 15;
            this.KeySqrt.TabStop = false;
            this.KeySqrt.Text = "√x";
            this.KeySqrt.UseVisualStyleBackColor = false;
            this.KeySqrt.Click += new System.EventHandler(this.KeySqrt_Click);
            // 
            // menuCheckBox
            // 
            this.menuCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.menuCheckBox.BackgroundImage = global::SimpleCalculator.Properties.Resources.outline_menu_black_18dp;
            this.menuCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.menuCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menuCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.menuCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuCheckBox.Location = new System.Drawing.Point(11, 10);
            this.menuCheckBox.Name = "menuCheckBox";
            this.menuCheckBox.Size = new System.Drawing.Size(40, 40);
            this.menuCheckBox.TabIndex = 23;
            this.menuCheckBox.UseVisualStyleBackColor = true;            
            this.menuCheckBox.Click += new System.EventHandler(this.menuCheckBox_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("RomanS_IV25", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button7.Location = new System.Drawing.Point(-54, -52);
            this.button7.Margin = new System.Windows.Forms.Padding(1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 22;
            this.button7.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("RomanS_IV25", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button5.Location = new System.Drawing.Point(-116, -52);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 22;
            this.button5.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("RomanS_IV25", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(-178, -52);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 22;
            this.button3.TabStop = false;
            // 
            // KeyExit
            // 
            this.KeyExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KeyExit.BackgroundImage")));
            this.KeyExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.KeyExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.KeyExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyExit.Font = new System.Drawing.Font("RomanS_IV25", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyExit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.KeyExit.Location = new System.Drawing.Point(423, 10);
            this.KeyExit.Margin = new System.Windows.Forms.Padding(1);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(40, 40);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.KeyOppositeValue);
            this.panel1.Controls.Add(this.KeySquaredNum);
            this.panel1.Controls.Add(this.KeySeven);
            this.panel1.Controls.Add(this.KeyEight);
            this.panel1.Controls.Add(this.KeyFour);
            this.panel1.Controls.Add(this.KeyFive);
            this.panel1.Controls.Add(this.KeyClear);
            this.panel1.Controls.Add(this.KeySqrt);
            this.panel1.Controls.Add(this.KeyPlus);
            this.panel1.Controls.Add(this.KeyDate);
            this.panel1.Controls.Add(this.KeyEqual);
            this.panel1.Controls.Add(this.KeyThree);
            this.panel1.Controls.Add(this.KeyMinus);
            this.panel1.Controls.Add(this.KeyTwo);
            this.panel1.Controls.Add(this.KeySix);
            this.panel1.Controls.Add(this.KeyMultiply);
            this.panel1.Controls.Add(this.KeyOne);
            this.panel1.Controls.Add(this.KeyDivide);
            this.panel1.Controls.Add(this.KeyNine);
            this.panel1.Controls.Add(this.KeyPoint);
            this.panel1.Controls.Add(this.KeySign);
            this.panel1.Controls.Add(this.KeyZero);
            this.panel1.Controls.Add(this.KeyPowered);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(352, 313);
            this.panel1.TabIndex = 25;
            // 
            // extraPanel
            // 
            this.extraPanel.Controls.Add(this.KeyCubeRoot);
            this.extraPanel.Controls.Add(this.KeyFactorial);
            this.extraPanel.Location = new System.Drawing.Point(363, 118);
            this.extraPanel.Name = "extraPanel";
            this.extraPanel.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.extraPanel.Size = new System.Drawing.Size(100, 313);
            this.extraPanel.TabIndex = 26;
            this.extraPanel.Visible = false;
            // 
            // KeyCubeRoot
            // 
            this.KeyCubeRoot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KeyCubeRoot.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyCubeRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyCubeRoot.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyCubeRoot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyCubeRoot.Location = new System.Drawing.Point(0, 154);
            this.KeyCubeRoot.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.KeyCubeRoot.Name = "KeyCubeRoot";
            this.KeyCubeRoot.Size = new System.Drawing.Size(96, 156);
            this.KeyCubeRoot.TabIndex = 17;
            this.KeyCubeRoot.TabStop = false;
            this.KeyCubeRoot.Text = "∛x";
            this.KeyCubeRoot.UseVisualStyleBackColor = false;
            this.KeyCubeRoot.Click += new System.EventHandler(this.keyCubeRoot_Click);
            // 
            // KeyFactorial
            // 
            this.KeyFactorial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KeyFactorial.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeyFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyFactorial.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyFactorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyFactorial.Location = new System.Drawing.Point(0, 2);
            this.KeyFactorial.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.KeyFactorial.Name = "KeyFactorial";
            this.KeyFactorial.Size = new System.Drawing.Size(96, 150);
            this.KeyFactorial.TabIndex = 16;
            this.KeyFactorial.TabStop = false;
            this.KeyFactorial.Text = " n!";
            this.KeyFactorial.UseVisualStyleBackColor = false;
            this.KeyFactorial.Click += new System.EventHandler(this.keyFactorial_Click);
            // 
            // CalcUI
            // 
            this.AcceptButton = this.KeyZero;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(472, 440);
            this.Controls.Add(this.extraPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuCheckBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.MaximizeBox = false;
            this.Name = "CalcUI";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.extraPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		protected void KeyPlus_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eAdd);
		}

		protected void KeyMinus_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eSubtract);
		}

		protected void KeyMultiply_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eMultiply);
		}

		protected void KeyDivide_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eDivide);
		}

        // user defined methods

        private void KeyOppositeValue_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcOpposite();
            if (OutputDisplay.Text == "деление на ноль")
            {                
                DisableControls();
            }            
        }

        private void KeySquaredNum_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSquaredNum();
        }


        private void KeyPowered_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePowered);
        }

        private void KeySqrt_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSqrt();
        }

        private void keyFactorial_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcFactorialN();
        }

        private void keyCubeRoot_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcCubeRoot();
        }

        //
        // Other non-numeric key click methods.
        //

        protected void KeySign_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcSign();
		}

		protected void KeyPoint_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcDecimal();
		}

		protected void KeyDate_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.GetDate();
			CalcEngine.CalcReset();
		}

		protected void KeyClear_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcReset();
			OutputDisplay.Text = "";
            EnableControls();
            
        }

		//
		// Perform the calculation.
		//

		protected void KeyEqual_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcEqual();
			CalcEngine.CalcReset();
		}

		//
		// Numeric key click methods.
		//

		protected void KeyNine_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (nineOut);
		}

		protected void KeyEight_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (eightOut);
		}

		protected void KeySeven_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sevenOut);
		}

		protected void KeySix_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sixOut);
		}

		protected void KeyFive_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (fiveOut);
		}

		protected void KeyFour_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (fourOut);
		}

		protected void KeyThree_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (threeOut);
		}

		protected void KeyTwo_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (twoOut);
		}

		protected void KeyOne_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (oneOut);
		}

		protected void KeyZero_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (zeroOut);
		}

		//
		// End the program.
		//

		protected void KeyExit_Click (object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CalcUI());
		}

        private void button1_Click(object sender, EventArgs e)
        {
            //MenuForm myF2 = new MenuForm(); 
            //myF2.StartPosition = FormStartPosition.Manual; 
            //myF2.Location = new Point(this.Location.X -  252, this.Location.Y); 
            //myF2.Show();
        }

        

        private void menuCheckBox_Click(object sender, EventArgs e)
        {
            mForm.StartPosition = FormStartPosition.Manual;
            mForm.Location = new Point(this.Location.X - 252, this.Location.Y);

            if (menuCheckBox.Checked)
            {               
                //menuCheckBox.FlatAppearance.BorderColor = Color.Gray;
                //menuCheckBox.FlatAppearance.BorderSize = 2;
                mForm.Show(this);
            }
            else
            {               
                menuCheckBox.FlatAppearance.BorderColor = Color.Silver;
                menuCheckBox.FlatAppearance.BorderSize = 1;
                FormCollection fc = Application.OpenForms;

                for (int i = 1; i < fc.Count; i++)
                {
                    fc[i].Hide();
                }         

            }
        }

        public void ExtraPanelViewer (int i)
        {
            if (i == 1) 
            {
                this.extraPanel.Show();
            } else
            {
                this.extraPanel.Hide();
            }
        }

       
    }
}
