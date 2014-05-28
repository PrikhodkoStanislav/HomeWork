namespace Zadacha2_Clock
{
    using System.Windows.Forms;

    partial class Forma
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
            this.hours = new System.Windows.Forms.TextBox();
            this.minutes = new System.Windows.Forms.TextBox();
            this.seconds = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.hours, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.minutes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.seconds, 2, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 46);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(240, 50);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(240, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // hours
            // 
            this.hours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hours.Location = new System.Drawing.Point(3, 3);
            this.hours.MaximumSize = new System.Drawing.Size(74, 44);
            this.hours.MinimumSize = new System.Drawing.Size(74, 44);
            this.hours.Multiline = true;
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(74, 44);
            this.hours.TabIndex = 0;
            this.hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.time_KeyPress);
            // 
            // minutes
            // 
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minutes.Location = new System.Drawing.Point(83, 3);
            this.minutes.MaximumSize = new System.Drawing.Size(74, 44);
            this.minutes.MinimumSize = new System.Drawing.Size(74, 44);
            this.minutes.Multiline = true;
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(74, 44);
            this.minutes.TabIndex = 1;
            this.minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.time_KeyPress);
            // 
            // seconds
            // 
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seconds.Location = new System.Drawing.Point(163, 3);
            this.seconds.MaximumSize = new System.Drawing.Size(74, 44);
            this.seconds.MinimumSize = new System.Drawing.Size(74, 44);
            this.seconds.Multiline = true;
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(74, 44);
            this.seconds.TabIndex = 2;
            this.seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.time_KeyPress);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(107, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Forma";
            this.Text = "Clock";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox hours;
        private System.Windows.Forms.TextBox minutes;
        private System.Windows.Forms.TextBox seconds;
        private Button button1;
    }
}

