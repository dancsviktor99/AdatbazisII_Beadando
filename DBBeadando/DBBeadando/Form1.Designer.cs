using System;

namespace DBBeadando
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
            this.dgv_Jatekok = new System.Windows.Forms.DataGridView();
            this.textBox_asztalkod = new System.Windows.Forms.TextBox();
            this.textBox_gametable = new System.Windows.Forms.TextBox();
            this.textBox_krupie = new System.Windows.Forms.TextBox();
            this.comboBox_gametype = new System.Windows.Forms.ComboBox();
            this.textBox_gyarto = new System.Windows.Forms.TextBox();
            this.textBox_limit = new System.Windows.Forms.TextBox();
            this.dateTimePicker_kelt = new System.Windows.Forms.DateTimePicker();
            this.asztalkod = new System.Windows.Forms.Label();
            this.gametable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Jatektype = new System.Windows.Forms.Label();
            this.gyarto = new System.Windows.Forms.Label();
            this.asztallimit = new System.Windows.Forms.Label();
            this.gamedate = new System.Windows.Forms.Label();
            this.krupie = new System.Windows.Forms.Label();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Jatekok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Jatekok
            // 
            this.dgv_Jatekok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Jatekok.Location = new System.Drawing.Point(13, 13);
            this.dgv_Jatekok.Name = "dgv_Jatekok";
            this.dgv_Jatekok.RowHeadersWidth = 51;
            this.dgv_Jatekok.RowTemplate.Height = 24;
            this.dgv_Jatekok.Size = new System.Drawing.Size(828, 214);
            this.dgv_Jatekok.TabIndex = 0;
            this.dgv_Jatekok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Jatekok_CellContentClick);
            // 
            // textBox_asztalkod
            // 
            this.textBox_asztalkod.Location = new System.Drawing.Point(12, 275);
            this.textBox_asztalkod.Name = "textBox_asztalkod";
            this.textBox_asztalkod.Size = new System.Drawing.Size(226, 22);
            this.textBox_asztalkod.TabIndex = 1;
            // 
            // textBox_gametable
            // 
            this.textBox_gametable.Location = new System.Drawing.Point(12, 334);
            this.textBox_gametable.Name = "textBox_gametable";
            this.textBox_gametable.Size = new System.Drawing.Size(226, 22);
            this.textBox_gametable.TabIndex = 2;
            // 
            // textBox_krupie
            // 
            this.textBox_krupie.Location = new System.Drawing.Point(13, 392);
            this.textBox_krupie.Name = "textBox_krupie";
            this.textBox_krupie.Size = new System.Drawing.Size(226, 22);
            this.textBox_krupie.TabIndex = 3;
            // 
            // comboBox_gametype
            // 
            this.comboBox_gametype.FormattingEnabled = true;
            this.comboBox_gametype.Location = new System.Drawing.Point(13, 447);
            this.comboBox_gametype.Name = "comboBox_gametype";
            this.comboBox_gametype.Size = new System.Drawing.Size(226, 24);
            this.comboBox_gametype.TabIndex = 4;
            // 
            // textBox_gyarto
            // 
            this.textBox_gyarto.Location = new System.Drawing.Point(522, 291);
            this.textBox_gyarto.Name = "textBox_gyarto";
            this.textBox_gyarto.Size = new System.Drawing.Size(234, 22);
            this.textBox_gyarto.TabIndex = 5;
            // 
            // textBox_limit
            // 
            this.textBox_limit.Location = new System.Drawing.Point(522, 363);
            this.textBox_limit.Name = "textBox_limit";
            this.textBox_limit.Size = new System.Drawing.Size(234, 22);
            this.textBox_limit.TabIndex = 6;
            // 
            // dateTimePicker_kelt
            // 
            this.dateTimePicker_kelt.Location = new System.Drawing.Point(522, 442);
            this.dateTimePicker_kelt.Name = "dateTimePicker_kelt";
            this.dateTimePicker_kelt.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker_kelt.TabIndex = 7;
            // 
            // asztalkod
            // 
            this.asztalkod.AutoSize = true;
            this.asztalkod.Location = new System.Drawing.Point(10, 255);
            this.asztalkod.Name = "asztalkod";
            this.asztalkod.Size = new System.Drawing.Size(69, 17);
            this.asztalkod.TabIndex = 8;
            this.asztalkod.Text = "Asztalkód";
            this.asztalkod.Click += new System.EventHandler(this.label1_Click);
            // 
            // gametable
            // 
            this.gametable.AutoSize = true;
            this.gametable.Location = new System.Drawing.Point(13, 309);
            this.gametable.Name = "gametable";
            this.gametable.Size = new System.Drawing.Size(114, 17);
            this.gametable.TabIndex = 9;
            this.gametable.Text = "Játékasztal neve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 10;
            // 
            // Jatektype
            // 
            this.Jatektype.AutoSize = true;
            this.Jatektype.Location = new System.Drawing.Point(13, 421);
            this.Jatektype.Name = "Jatektype";
            this.Jatektype.Size = new System.Drawing.Size(84, 17);
            this.Jatektype.TabIndex = 11;
            this.Jatektype.Text = "Játék típusa";
            // 
            // gyarto
            // 
            this.gyarto.AutoSize = true;
            this.gyarto.Location = new System.Drawing.Point(522, 255);
            this.gyarto.Name = "gyarto";
            this.gyarto.Size = new System.Drawing.Size(51, 17);
            this.gyarto.TabIndex = 12;
            this.gyarto.Text = "Gyártó";
            // 
            // asztallimit
            // 
            this.asztallimit.AutoSize = true;
            this.asztallimit.Location = new System.Drawing.Point(522, 343);
            this.asztallimit.Name = "asztallimit";
            this.asztallimit.Size = new System.Drawing.Size(70, 17);
            this.asztallimit.TabIndex = 13;
            this.asztallimit.Text = "Asztallimit";
            // 
            // gamedate
            // 
            this.gamedate.AutoSize = true;
            this.gamedate.Location = new System.Drawing.Point(519, 412);
            this.gamedate.Name = "gamedate";
            this.gamedate.Size = new System.Drawing.Size(180, 17);
            this.gamedate.TabIndex = 14;
            this.gamedate.Text = "Játék Keletkezésének ideje";
            this.gamedate.Click += new System.EventHandler(this.gamedate_Click);
            // 
            // krupie
            // 
            this.krupie.AutoSize = true;
            this.krupie.Location = new System.Drawing.Point(12, 363);
            this.krupie.Name = "krupie";
            this.krupie.Size = new System.Drawing.Size(49, 17);
            this.krupie.TabIndex = 15;
            this.krupie.Text = "Krupié";
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(291, 291);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(182, 53);
            this.button_insert.TabIndex = 16;
            this.button_insert.Text = "Hozzáadás";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(291, 377);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(182, 52);
            this.button_delete.TabIndex = 17;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 520);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.krupie);
            this.Controls.Add(this.gamedate);
            this.Controls.Add(this.asztallimit);
            this.Controls.Add(this.gyarto);
            this.Controls.Add(this.Jatektype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gametable);
            this.Controls.Add(this.asztalkod);
            this.Controls.Add(this.dateTimePicker_kelt);
            this.Controls.Add(this.textBox_limit);
            this.Controls.Add(this.textBox_gyarto);
            this.Controls.Add(this.comboBox_gametype);
            this.Controls.Add(this.textBox_krupie);
            this.Controls.Add(this.textBox_gametable);
            this.Controls.Add(this.textBox_asztalkod);
            this.Controls.Add(this.dgv_Jatekok);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Jatekok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void gamedate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Jatekok;
        private System.Windows.Forms.TextBox textBox_asztalkod;
        private System.Windows.Forms.TextBox textBox_gametable;
        private System.Windows.Forms.TextBox textBox_krupie;
        private System.Windows.Forms.ComboBox comboBox_gametype;
        private System.Windows.Forms.TextBox textBox_gyarto;
        private System.Windows.Forms.TextBox textBox_limit;
        private System.Windows.Forms.DateTimePicker dateTimePicker_kelt;
        private System.Windows.Forms.Label asztalkod;
        private System.Windows.Forms.Label gametable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Jatektype;
        private System.Windows.Forms.Label gyarto;
        private System.Windows.Forms.Label asztallimit;
        private System.Windows.Forms.Label gamedate;
        private System.Windows.Forms.Label krupie;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
    }
}

