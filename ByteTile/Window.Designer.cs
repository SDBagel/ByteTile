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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Button_Invert = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Button_GenerateCode = new System.Windows.Forms.Button();
            this.Panel_Editor = new System.Windows.Forms.Panel();
            this.UpDown_GridX = new System.Windows.Forms.NumericUpDown();
            this.UpDown_GridY = new System.Windows.Forms.NumericUpDown();
            this.Button_GenerateGrid = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Window_ControlBar = new System.Windows.Forms.Panel();
            this.Button_GridOptions = new System.Windows.Forms.Button();
            this.Window_Title = new System.Windows.Forms.Label();
            this.Panel_GridOptions = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Window_Minimize = new System.Windows.Forms.PictureBox();
            this.Window_Close = new System.Windows.Forms.PictureBox();
            this.Window_Icon = new System.Windows.Forms.PictureBox();
            this.Icon_Loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_GridX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_GridY)).BeginInit();
            this.Window_ControlBar.SuspendLayout();
            this.Panel_GridOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Loading)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Reset
            // 
            this.Button_Reset.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Reset.Location = new System.Drawing.Point(8, 135);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(130, 24);
            this.Button_Reset.TabIndex = 0;
            this.Button_Reset.Text = "Reset Grid";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.ResetGrid_Click);
            // 
            // Button_Invert
            // 
            this.Button_Invert.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Invert.Location = new System.Drawing.Point(8, 105);
            this.Button_Invert.Name = "Button_Invert";
            this.Button_Invert.Size = new System.Drawing.Size(130, 24);
            this.Button_Invert.TabIndex = 1;
            this.Button_Invert.Text = "Invert Grid";
            this.Button_Invert.UseVisualStyleBackColor = true;
            this.Button_Invert.Click += new System.EventHandler(this.InvertGrid_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(428, 108);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(362, 368);
            this.Output.TabIndex = 2;
            this.Output.Text = "";
            // 
            // Button_GenerateCode
            // 
            this.Button_GenerateCode.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_GenerateCode.Location = new System.Drawing.Point(428, 68);
            this.Button_GenerateCode.Name = "Button_GenerateCode";
            this.Button_GenerateCode.Size = new System.Drawing.Size(139, 34);
            this.Button_GenerateCode.TabIndex = 3;
            this.Button_GenerateCode.Text = "Generate Code";
            this.Button_GenerateCode.UseVisualStyleBackColor = true;
            this.Button_GenerateCode.Click += new System.EventHandler(this.GenerateCode_Click);
            // 
            // Panel_Editor
            // 
            this.Panel_Editor.Location = new System.Drawing.Point(6, 68);
            this.Panel_Editor.Name = "Panel_Editor";
            this.Panel_Editor.Size = new System.Drawing.Size(416, 408);
            this.Panel_Editor.TabIndex = 4;
            // 
            // UpDown_GridX
            // 
            this.UpDown_GridX.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.UpDown_GridX.Location = new System.Drawing.Point(8, 30);
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
            this.UpDown_GridY.Location = new System.Drawing.Point(95, 30);
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
            this.Button_GenerateGrid.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_GenerateGrid.Location = new System.Drawing.Point(5, 56);
            this.Button_GenerateGrid.Name = "Button_GenerateGrid";
            this.Button_GenerateGrid.Size = new System.Drawing.Size(130, 24);
            this.Button_GenerateGrid.TabIndex = 2;
            this.Button_GenerateGrid.Text = "Generate Grid";
            this.Button_GenerateGrid.UseVisualStyleBackColor = true;
            this.Button_GenerateGrid.Click += new System.EventHandler(this.GenerateGrid_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(60, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(18, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "by";
            // 
            // Window_ControlBar
            // 
            this.Window_ControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.Window_ControlBar.Controls.Add(this.Button_GridOptions);
            this.Window_ControlBar.Controls.Add(this.Window_Minimize);
            this.Window_ControlBar.Controls.Add(this.Window_Close);
            this.Window_ControlBar.Controls.Add(this.Window_Title);
            this.Window_ControlBar.Controls.Add(this.Window_Icon);
            this.Window_ControlBar.Location = new System.Drawing.Point(0, 0);
            this.Window_ControlBar.Name = "Window_ControlBar";
            this.Window_ControlBar.Size = new System.Drawing.Size(800, 62);
            this.Window_ControlBar.TabIndex = 5;
            this.Window_ControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_ControlBar_MouseDown);
            this.Window_ControlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Window_ControlBar_MouseMove);
            this.Window_ControlBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Window_ControlBar_MouseUp);
            // 
            // Button_GridOptions
            // 
            this.Button_GridOptions.BackColor = System.Drawing.SystemColors.Control;
            this.Button_GridOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_GridOptions.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_GridOptions.Location = new System.Drawing.Point(4, 34);
            this.Button_GridOptions.Name = "Button_GridOptions";
            this.Button_GridOptions.Size = new System.Drawing.Size(95, 23);
            this.Button_GridOptions.TabIndex = 4;
            this.Button_GridOptions.Text = "Grid Options";
            this.Button_GridOptions.UseVisualStyleBackColor = false;
            this.Button_GridOptions.Click += new System.EventHandler(this.Button_GridOptions_Click);
            // 
            // Window_Title
            // 
            this.Window_Title.AutoSize = true;
            this.Window_Title.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Window_Title.ForeColor = System.Drawing.Color.Silver;
            this.Window_Title.Location = new System.Drawing.Point(35, 8);
            this.Window_Title.Name = "Window_Title";
            this.Window_Title.Size = new System.Drawing.Size(124, 18);
            this.Window_Title.TabIndex = 1;
            this.Window_Title.Text = "ByteTile Generator";
            // 
            // Panel_GridOptions
            // 
            this.Panel_GridOptions.BackColor = System.Drawing.Color.Silver;
            this.Panel_GridOptions.Controls.Add(this.label2);
            this.Panel_GridOptions.Controls.Add(this.UpDown_GridX);
            this.Panel_GridOptions.Controls.Add(this.Label1);
            this.Panel_GridOptions.Controls.Add(this.Button_GenerateGrid);
            this.Panel_GridOptions.Controls.Add(this.UpDown_GridY);
            this.Panel_GridOptions.Controls.Add(this.Button_Invert);
            this.Panel_GridOptions.Controls.Add(this.Button_Reset);
            this.Panel_GridOptions.Location = new System.Drawing.Point(4, 60);
            this.Panel_GridOptions.Name = "Panel_GridOptions";
            this.Panel_GridOptions.Size = new System.Drawing.Size(155, 175);
            this.Panel_GridOptions.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grid Size:";
            // 
            // Window_Minimize
            // 
            this.Window_Minimize.BackgroundImage = global::ByteTile.Properties.Resources.minimize;
            this.Window_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Window_Minimize.InitialImage = null;
            this.Window_Minimize.Location = new System.Drawing.Point(743, 4);
            this.Window_Minimize.Name = "Window_Minimize";
            this.Window_Minimize.Size = new System.Drawing.Size(25, 25);
            this.Window_Minimize.TabIndex = 3;
            this.Window_Minimize.TabStop = false;
            this.Window_Minimize.Click += new System.EventHandler(this.Window_Minimize_Click);
            this.Window_Minimize.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Window_Minimize.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Window_Close
            // 
            this.Window_Close.BackgroundImage = global::ByteTile.Properties.Resources.close;
            this.Window_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Window_Close.Location = new System.Drawing.Point(772, 4);
            this.Window_Close.Name = "Window_Close";
            this.Window_Close.Size = new System.Drawing.Size(25, 25);
            this.Window_Close.TabIndex = 2;
            this.Window_Close.TabStop = false;
            this.Window_Close.Click += new System.EventHandler(this.Window_Close_Click);
            this.Window_Close.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Window_Close.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Window_Icon
            // 
            this.Window_Icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Window_Icon.BackgroundImage")));
            this.Window_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Window_Icon.Location = new System.Drawing.Point(4, 4);
            this.Window_Icon.Name = "Window_Icon";
            this.Window_Icon.Size = new System.Drawing.Size(25, 25);
            this.Window_Icon.TabIndex = 0;
            this.Window_Icon.TabStop = false;
            // 
            // Icon_Loading
            // 
            this.Icon_Loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Icon_Loading.Image = global::ByteTile.Properties.Resources.loading;
            this.Icon_Loading.Location = new System.Drawing.Point(140, 180);
            this.Icon_Loading.Name = "Icon_Loading";
            this.Icon_Loading.Size = new System.Drawing.Size(163, 180);
            this.Icon_Loading.TabIndex = 0;
            this.Icon_Loading.TabStop = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Icon_Loading);
            this.Controls.Add(this.Panel_GridOptions);
            this.Controls.Add(this.Window_ControlBar);
            this.Controls.Add(this.Panel_Editor);
            this.Controls.Add(this.Button_GenerateCode);
            this.Controls.Add(this.Output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window";
            this.Text = " ByteTile Generator";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_GridX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_GridY)).EndInit();
            this.Window_ControlBar.ResumeLayout(false);
            this.Window_ControlBar.PerformLayout();
            this.Panel_GridOptions.ResumeLayout(false);
            this.Panel_GridOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Loading)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel Window_ControlBar;
        private System.Windows.Forms.PictureBox Window_Minimize;
        private System.Windows.Forms.PictureBox Window_Close;
        private System.Windows.Forms.Label Window_Title;
        private System.Windows.Forms.PictureBox Window_Icon;
        private System.Windows.Forms.Button Button_GridOptions;
        private System.Windows.Forms.Panel Panel_GridOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Icon_Loading;
    }
}

