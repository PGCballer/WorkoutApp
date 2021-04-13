
namespace PersonalTrainerApp
{
    partial class Form5
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
            this.firstappt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nxtappt = new System.Windows.Forms.DateTimePicker();
            this.nextappt = new System.Windows.Forms.Label();
            this.workoutplan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.workoutcombobx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // firstappt
            // 
            this.firstappt.AutoSize = true;
            this.firstappt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstappt.Location = new System.Drawing.Point(123, 340);
            this.firstappt.Name = "firstappt";
            this.firstappt.Size = new System.Drawing.Size(125, 29);
            this.firstappt.TabIndex = 0;
            this.firstappt.Text = "First Appt";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(256, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(511, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nxtappt
            // 
            this.nxtappt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxtappt.Location = new System.Drawing.Point(256, 380);
            this.nxtappt.Name = "nxtappt";
            this.nxtappt.Size = new System.Drawing.Size(511, 35);
            this.nxtappt.TabIndex = 2;
            this.nxtappt.ValueChanged += new System.EventHandler(this.nxtappt_ValueChanged);
            // 
            // nextappt
            // 
            this.nextappt.AutoSize = true;
            this.nextappt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextappt.Location = new System.Drawing.Point(122, 384);
            this.nextappt.Name = "nextappt";
            this.nextappt.Size = new System.Drawing.Size(126, 29);
            this.nextappt.TabIndex = 3;
            this.nextappt.Text = "Next Appt";
            // 
            // workoutplan
            // 
            this.workoutplan.AutoSize = true;
            this.workoutplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutplan.Location = new System.Drawing.Point(80, 437);
            this.workoutplan.Name = "workoutplan";
            this.workoutplan.Size = new System.Drawing.Size(168, 29);
            this.workoutplan.TabIndex = 4;
            this.workoutplan.Text = "Workout Plan";
            this.workoutplan.Click += new System.EventHandler(this.workoutplan_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(375, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // workoutcombobx
            // 
            this.workoutcombobx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutcombobx.FormattingEnabled = true;
            this.workoutcombobx.Location = new System.Drawing.Point(273, 432);
            this.workoutcombobx.Name = "workoutcombobx";
            this.workoutcombobx.Size = new System.Drawing.Size(295, 37);
            this.workoutcombobx.TabIndex = 6;
            this.workoutcombobx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 696);
            this.Controls.Add(this.workoutcombobx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.workoutplan);
            this.Controls.Add(this.nextappt);
            this.Controls.Add(this.nxtappt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.firstappt);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstappt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker nxtappt;
        private System.Windows.Forms.Label nextappt;
        private System.Windows.Forms.Label workoutplan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox workoutcombobx;
    }
}