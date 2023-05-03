namespace LIVE_DEMO
{
    partial class MAIN_FORM
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.BTN_EXE = new System.Windows.Forms.Button();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.openFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.TREE = new System.Windows.Forms.TreeView();
            this.TB_Trans_X = new System.Windows.Forms.TrackBar();
            this.T_X = new System.Windows.Forms.Label();
            this.TB_Trans_Y = new System.Windows.Forms.TrackBar();
            this.T_Y = new System.Windows.Forms.Label();
            this.T_Z = new System.Windows.Forms.Label();
            this.TB_Trans_Z = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_TIME = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Trans_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Trans_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Trans_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_TIME)).BeginInit();
            this.SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCT_CANVAS.Location = new System.Drawing.Point(121, 334);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(4);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(839, 483);
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            // 
            // BTN_EXE
            // 
            this.BTN_EXE.BackColor = System.Drawing.Color.Maroon;
            this.BTN_EXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXE.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXE.ForeColor = System.Drawing.Color.Silver;
            this.BTN_EXE.Location = new System.Drawing.Point(1471, 276);
            this.BTN_EXE.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_EXE.Name = "BTN_EXE";
            this.BTN_EXE.Size = new System.Drawing.Size(381, 98);
            this.BTN_EXE.TabIndex = 1;
            this.BTN_EXE.Text = "PLAY |>";
            this.BTN_EXE.UseVisualStyleBackColor = false;
            this.BTN_EXE.Click += new System.EventHandler(this.BTN_EXE_Click);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 60;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // openFile
            // 
            this.openFile.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile.Location = new System.Drawing.Point(1471, 15);
            this.openFile.Margin = new System.Windows.Forms.Padding(4);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(381, 43);
            this.openFile.TabIndex = 18;
            this.openFile.Text = "LOAD OBJ";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos OBJ|*.obj";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(1567, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 76);
            this.button1.TabIndex = 19;
            this.button1.Text = "START/STOP RECORDING";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TREE
            // 
            this.TREE.BackColor = System.Drawing.Color.CadetBlue;
            this.TREE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TREE.Location = new System.Drawing.Point(1471, 66);
            this.TREE.Margin = new System.Windows.Forms.Padding(4);
            this.TREE.Name = "TREE";
            this.TREE.Size = new System.Drawing.Size(381, 202);
            this.TREE.TabIndex = 20;
            this.TREE.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TREE_AfterSelect);
            // 
            // TB_Trans_X
            // 
            this.TB_Trans_X.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.TB_Trans_X.Location = new System.Drawing.Point(-4, 181);
            this.TB_Trans_X.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Trans_X.Minimum = -10;
            this.TB_Trans_X.Name = "TB_Trans_X";
            this.TB_Trans_X.Size = new System.Drawing.Size(1383, 56);
            this.TB_Trans_X.TabIndex = 21;
            this.TB_Trans_X.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // T_X
            // 
            this.T_X.AutoSize = true;
            this.T_X.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_X.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.T_X.Location = new System.Drawing.Point(13, 226);
            this.T_X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.T_X.Name = "T_X";
            this.T_X.Size = new System.Drawing.Size(252, 30);
            this.T_X.TabIndex = 22;
            this.T_X.Text = "X Transformation";
            // 
            // TB_Trans_Y
            // 
            this.TB_Trans_Y.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.TB_Trans_Y.Location = new System.Drawing.Point(-4, 101);
            this.TB_Trans_Y.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Trans_Y.Minimum = -10;
            this.TB_Trans_Y.Name = "TB_Trans_Y";
            this.TB_Trans_Y.Size = new System.Drawing.Size(1382, 56);
            this.TB_Trans_Y.TabIndex = 23;
            this.TB_Trans_Y.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // T_Y
            // 
            this.T_Y.AutoSize = true;
            this.T_Y.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Y.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.T_Y.Location = new System.Drawing.Point(13, 147);
            this.T_Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.T_Y.Name = "T_Y";
            this.T_Y.Size = new System.Drawing.Size(252, 30);
            this.T_Y.TabIndex = 24;
            this.T_Y.Text = "Y Transformation";
            // 
            // T_Z
            // 
            this.T_Z.AutoSize = true;
            this.T_Z.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Z.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.T_Z.Location = new System.Drawing.Point(11, 67);
            this.T_Z.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.T_Z.Name = "T_Z";
            this.T_Z.Size = new System.Drawing.Size(250, 30);
            this.T_Z.TabIndex = 26;
            this.T_Z.Text = "Z Transformation";
            this.T_Z.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_Trans_Z
            // 
            this.TB_Trans_Z.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.TB_Trans_Z.Location = new System.Drawing.Point(-4, 15);
            this.TB_Trans_Z.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Trans_Z.Minimum = -10;
            this.TB_Trans_Z.Name = "TB_Trans_Z";
            this.TB_Trans_Z.Size = new System.Drawing.Size(1383, 56);
            this.TB_Trans_Z.TabIndex = 25;
            this.TB_Trans_Z.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(11, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "Time";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TB_TIME
            // 
            this.TB_TIME.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.TB_TIME.Location = new System.Drawing.Point(-4, 260);
            this.TB_TIME.Margin = new System.Windows.Forms.Padding(4);
            this.TB_TIME.Maximum = 100;
            this.TB_TIME.Name = "TB_TIME";
            this.TB_TIME.Size = new System.Drawing.Size(1383, 56);
            this.TB_TIME.TabIndex = 30;
            this.TB_TIME.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1504, 613);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1471, 701);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(381, 50);
            this.button2.TabIndex = 34;
            this.button2.Text = "Escalation";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(1471, 645);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(381, 50);
            this.button3.TabIndex = 35;
            this.button3.Text = "Translation";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(1471, 587);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(381, 52);
            this.button4.TabIndex = 36;
            this.button4.Text = "Rotation";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MAIN_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1869, 1055);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_TIME);
            this.Controls.Add(this.T_Z);
            this.Controls.Add(this.TB_Trans_Z);
            this.Controls.Add(this.T_Y);
            this.Controls.Add(this.TB_Trans_Y);
            this.Controls.Add(this.T_X);
            this.Controls.Add(this.TB_Trans_X);
            this.Controls.Add(this.TREE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.BTN_EXE);
            this.Controls.Add(this.PCT_CANVAS);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MAIN_FORM";
            this.Text = "DEMO";
            this.Load += new System.EventHandler(this.MAIN_FORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Trans_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Trans_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Trans_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_TIME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Button BTN_EXE;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView TREE;
        private System.Windows.Forms.TrackBar TB_Trans_X;
        private System.Windows.Forms.Label T_X;
        private System.Windows.Forms.TrackBar TB_Trans_Y;
        private System.Windows.Forms.Label T_Y;
        private System.Windows.Forms.Label T_Z;
        private System.Windows.Forms.TrackBar TB_Trans_Z;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TB_TIME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

