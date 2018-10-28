namespace ByteTile
{
    partial class Window
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
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Button_Invert = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Button_GenerateCode = new System.Windows.Forms.Button();
            this.Panel_Editor = new System.Windows.Forms.Panel();
            this.UpDown_GridX = new System.Windows.Forms.NumericUpDown();
            this.UpDown_GridY = new System.Windows.Forms.NumericUpDown();
            this.Button_GenerateGrid = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_GridX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_GridY)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Reset
            // 
            this.Button_Reset.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Reset.Location = new System.Drawing.Point(20, 400);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(90, 34);
            this.Button_Reset.TabIndex = 0;
            this.Button_Reset.Text = "Reset Grid";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.ResetGrid_Click);
            // 
            // Button_Invert
            // 
            this.Button_Invert.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Invert.Location = new System.Drawing.Point(136, 400);
            this.Button_Invert.Name = "Button_Invert";
            this.Button_Invert.Size = new System.Drawing.Size(90, 34);
            this.Button_Invert.TabIndex = 1;
            this.Button_Invert.Text = "Invert Grid";
            this.Button_Invert.UseVisualStyleBackColor = true;
            this.Button_Invert.Click += new System.EventHandler(this.InvertGrid_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(428, 60);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(362, 374);
            this.Output.TabIndex = 2;
            this.Output.Text = "";
            // 
            // Button_GenerateCode
            // 
            this.Button_GenerateCode.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_GenerateCode.Location = new System.Drawing.Point(428, 20);
            this.Button_GenerateCode.Name = "Button_GenerateCode";
            this.Button_GenerateCode.Size = new System.Drawing.Size(139, 34);
            this.Button_GenerateCode.TabIndex = 3;
            this.Button_GenerateCode.Text = "Generate Code";
            this.Button_GenerateCode.UseVisualStyleBackColor = true;
            this.Button_GenerateCode.Click += new System.EventHandler(this.GenerateCode_Click);
            // 
            // Panel_Editor
            // 
            this.Panel_Editor.Location = new System.Drawing.Point(20, 20);
            this.Panel_Editor.Name = "Panel_Editor";
            this.Panel_Editor.Size = new System.Drawing.Size(400, 365);
            this.Panel_Editor.TabIndex = 4;
            // 
            // UpDown_GridX
            // 
            this.UpDown_GridX.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.UpDown_GridX.Location = new System.Drawing.Point(247, 391);
            this.UpDown_GridX.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.UpDown_GridX.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.UpDown_GridX.Name = "UpDown_GridX";
            this.UpDown_GridX.Size = new System.Drawing.Size(40, 20);
            this.UpDown_GridX.TabIndex = 0;
            this.UpDown_GridX.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // UpDown_GridY
            // 
            this.UpDown_GridY.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.UpDown_GridY.Location = new System.Drawing.Point(330, 391);
            this.UpDown_GridY.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.UpDown_GridY.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.UpDown_GridY.Name = "UpDown_GridY";
            this.UpDown_GridY.Size = new System.Drawing.Size(40, 20);
            this.UpDown_GridY.TabIndex = 1;
            this.UpDown_GridY.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Button_GenerateGrid
            // 
            this.Button_GenerateGrid.Location = new System.Drawing.Point(247, 417);
            this.Button_GenerateGrid.Name = "Button_GenerateGrid";
            this.Button_GenerateGrid.Size = new System.Drawing.Size(123, 23);
            this.Button_GenerateGrid.TabIndex = 2;
            this.Button_GenerateGrid.Text = "Generate Grid";
            this.Button_GenerateGrid.UseVisualStyleBackColor = true;
            this.Button_GenerateGrid.Click += new System.EventHandler(this.GenerateGrid_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label1.Location = new System.Drawing.Point(297, 394);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(18, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "by";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_GenerateGrid);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.UpDown_GridY);
            this.Controls.Add(this.Panel_Editor);
            this.Controls.Add(this.Button_GenerateCode);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.UpDown_GridX);
            this.Controls.Add(this.Button_Invert);
            this.Controls.Add(this.Button_Reset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Window";
            this.Text = " ByteTile Generator";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_GridX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_GridY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Button Button_Invert;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button Button_GenerateCode;
        private System.Windows.Forms.Panel Panel_Editor;
        private System.Windows.Forms.NumericUpDown UpDown_GridX;
        private System.Windows.Forms.NumericUpDown UpDown_GridY;
        private System.Windows.Forms.Button Button_GenerateGrid;
        private System.Windows.Forms.Label Label1;
    }
}

