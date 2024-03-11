namespace kalkulator_pocztowy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Label();
            this.rozmiarListuBox = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.GroupBox();
            this.obliczListbtn = new System.Windows.Forms.Button();
            this.iloscListu = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.trescListuBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailList = new System.Windows.Forms.RadioButton();
            this.smsList = new System.Windows.Forms.RadioButton();
            this.odbiorListuCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.obliczPaczkabtn = new System.Windows.Forms.Button();
            this.iloscPaczek = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.trescPaczkiBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.emailPaczka = new System.Windows.Forms.RadioButton();
            this.smsPaczka = new System.Windows.Forms.RadioButton();
            this.odbiorPaczkiCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rozmiarPaczkiBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cenaValue = new System.Windows.Forms.Label();
            this.szczegolyPods = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkListlbl = new System.Windows.Forms.Label();
            this.listBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iloscListu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iloscPaczek)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Red;
            this.header.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.header.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.header.Location = new System.Drawing.Point(2, -1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(797, 36);
            this.header.TabIndex = 0;
            this.header.Text = "Kalkutor pocztowy VER.1";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rozmiarListuBox
            // 
            this.rozmiarListuBox.FormattingEnabled = true;
            this.rozmiarListuBox.Items.AddRange(new object[] {
            "A - 5 zł",
            "B - 10 zł",
            "C - 15 zł",
            "D - 20 zł"});
            this.rozmiarListuBox.Location = new System.Drawing.Point(21, 69);
            this.rozmiarListuBox.Name = "rozmiarListuBox";
            this.rozmiarListuBox.Size = new System.Drawing.Size(187, 21);
            this.rozmiarListuBox.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.Controls.Add(this.obliczListbtn);
            this.listBox.Controls.Add(this.iloscListu);
            this.listBox.Controls.Add(this.label3);
            this.listBox.Controls.Add(this.trescListuBox);
            this.listBox.Controls.Add(this.groupBox1);
            this.listBox.Controls.Add(this.odbiorListuCheck);
            this.listBox.Controls.Add(this.label2);
            this.listBox.Controls.Add(this.label1);
            this.listBox.Controls.Add(this.rozmiarListuBox);
            this.listBox.Location = new System.Drawing.Point(33, 61);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(229, 331);
            this.listBox.TabIndex = 2;
            this.listBox.TabStop = false;
            // 
            // obliczListbtn
            // 
            this.obliczListbtn.Location = new System.Drawing.Point(75, 295);
            this.obliczListbtn.Name = "obliczListbtn";
            this.obliczListbtn.Size = new System.Drawing.Size(75, 23);
            this.obliczListbtn.TabIndex = 9;
            this.obliczListbtn.Text = "OBLICZ";
            this.obliczListbtn.UseVisualStyleBackColor = true;
            this.obliczListbtn.Click += new System.EventHandler(this.obliczListbtn_Click);
            // 
            // iloscListu
            // 
            this.iloscListu.Location = new System.Drawing.Point(21, 255);
            this.iloscListu.Name = "iloscListu";
            this.iloscListu.Size = new System.Drawing.Size(120, 20);
            this.iloscListu.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ilość:";
            // 
            // trescListuBox
            // 
            this.trescListuBox.Location = new System.Drawing.Point(21, 204);
            this.trescListuBox.Name = "trescListuBox";
            this.trescListuBox.Size = new System.Drawing.Size(187, 20);
            this.trescListuBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emailList);
            this.groupBox1.Controls.Add(this.smsList);
            this.groupBox1.Location = new System.Drawing.Point(21, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // emailList
            // 
            this.emailList.AutoSize = true;
            this.emailList.Location = new System.Drawing.Point(104, 19);
            this.emailList.Name = "emailList";
            this.emailList.Size = new System.Drawing.Size(57, 17);
            this.emailList.TabIndex = 1;
            this.emailList.TabStop = true;
            this.emailList.Text = "EMAIL";
            this.emailList.UseVisualStyleBackColor = true;
            // 
            // smsList
            // 
            this.smsList.AutoSize = true;
            this.smsList.Location = new System.Drawing.Point(21, 19);
            this.smsList.Name = "smsList";
            this.smsList.Size = new System.Drawing.Size(48, 17);
            this.smsList.TabIndex = 0;
            this.smsList.TabStop = true;
            this.smsList.Text = "SMS";
            this.smsList.UseVisualStyleBackColor = true;
            // 
            // odbiorListuCheck
            // 
            this.odbiorListuCheck.AutoSize = true;
            this.odbiorListuCheck.Location = new System.Drawing.Point(21, 108);
            this.odbiorListuCheck.Name = "odbiorListuCheck";
            this.odbiorListuCheck.Size = new System.Drawing.Size(129, 17);
            this.odbiorListuCheck.TabIndex = 4;
            this.odbiorListuCheck.Text = "potwierdzenie odbioru";
            this.odbiorListuCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rozmiar listu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(90, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "LIST";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.obliczPaczkabtn);
            this.groupBox2.Controls.Add(this.iloscPaczek);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.trescPaczkiBox);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.odbiorPaczkiCheck);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rozmiarPaczkiBox);
            this.groupBox2.Location = new System.Drawing.Point(268, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 331);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // obliczPaczkabtn
            // 
            this.obliczPaczkabtn.Location = new System.Drawing.Point(75, 295);
            this.obliczPaczkabtn.Name = "obliczPaczkabtn";
            this.obliczPaczkabtn.Size = new System.Drawing.Size(75, 23);
            this.obliczPaczkabtn.TabIndex = 9;
            this.obliczPaczkabtn.Text = "OBLICZ";
            this.obliczPaczkabtn.UseVisualStyleBackColor = true;
            this.obliczPaczkabtn.Click += new System.EventHandler(this.obliczPaczkabtn_Click);
            // 
            // iloscPaczek
            // 
            this.iloscPaczek.Location = new System.Drawing.Point(21, 255);
            this.iloscPaczek.Name = "iloscPaczek";
            this.iloscPaczek.Size = new System.Drawing.Size(120, 20);
            this.iloscPaczek.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ilość:";
            // 
            // trescPaczkiBox
            // 
            this.trescPaczkiBox.Location = new System.Drawing.Point(21, 204);
            this.trescPaczkiBox.Name = "trescPaczkiBox";
            this.trescPaczkiBox.Size = new System.Drawing.Size(187, 20);
            this.trescPaczkiBox.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.emailPaczka);
            this.groupBox3.Controls.Add(this.smsPaczka);
            this.groupBox3.Location = new System.Drawing.Point(21, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 55);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // emailPaczka
            // 
            this.emailPaczka.AutoSize = true;
            this.emailPaczka.Location = new System.Drawing.Point(104, 19);
            this.emailPaczka.Name = "emailPaczka";
            this.emailPaczka.Size = new System.Drawing.Size(57, 17);
            this.emailPaczka.TabIndex = 1;
            this.emailPaczka.TabStop = true;
            this.emailPaczka.Text = "EMAIL";
            this.emailPaczka.UseVisualStyleBackColor = true;
            // 
            // smsPaczka
            // 
            this.smsPaczka.AutoSize = true;
            this.smsPaczka.Location = new System.Drawing.Point(21, 19);
            this.smsPaczka.Name = "smsPaczka";
            this.smsPaczka.Size = new System.Drawing.Size(48, 17);
            this.smsPaczka.TabIndex = 0;
            this.smsPaczka.TabStop = true;
            this.smsPaczka.Text = "SMS";
            this.smsPaczka.UseVisualStyleBackColor = true;
            // 
            // odbiorPaczkiCheck
            // 
            this.odbiorPaczkiCheck.AutoSize = true;
            this.odbiorPaczkiCheck.Location = new System.Drawing.Point(21, 108);
            this.odbiorPaczkiCheck.Name = "odbiorPaczkiCheck";
            this.odbiorPaczkiCheck.Size = new System.Drawing.Size(129, 17);
            this.odbiorPaczkiCheck.TabIndex = 4;
            this.odbiorPaczkiCheck.Text = "potwierdzenie odbioru";
            this.odbiorPaczkiCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gabaryt paczki:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(84, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "PACZKA";
            // 
            // rozmiarPaczkiBox
            // 
            this.rozmiarPaczkiBox.FormattingEnabled = true;
            this.rozmiarPaczkiBox.Items.AddRange(new object[] {
            "A - 10 zł",
            "B - 15 zł",
            "C - 20 zł",
            "D - 25 zł"});
            this.rozmiarPaczkiBox.Location = new System.Drawing.Point(21, 69);
            this.rozmiarPaczkiBox.Name = "rozmiarPaczkiBox";
            this.rozmiarPaczkiBox.Size = new System.Drawing.Size(187, 21);
            this.rozmiarPaczkiBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(586, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Informacje o przesyłce:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cena: ";
            // 
            // cenaValue
            // 
            this.cenaValue.AutoSize = true;
            this.cenaValue.Location = new System.Drawing.Point(567, 92);
            this.cenaValue.Name = "cenaValue";
            this.cenaValue.Size = new System.Drawing.Size(13, 13);
            this.cenaValue.TabIndex = 13;
            this.cenaValue.Text = "?";
            // 
            // szczegolyPods
            // 
            this.szczegolyPods.AutoSize = true;
            this.szczegolyPods.Location = new System.Drawing.Point(523, 187);
            this.szczegolyPods.Name = "szczegolyPods";
            this.szczegolyPods.Size = new System.Drawing.Size(13, 13);
            this.szczegolyPods.TabIndex = 15;
            this.szczegolyPods.Text = "?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(523, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Szczegóły przesyłki:";
            // 
            // checkListlbl
            // 
            this.checkListlbl.AutoSize = true;
            this.checkListlbl.Location = new System.Drawing.Point(523, 155);
            this.checkListlbl.Name = "checkListlbl";
            this.checkListlbl.Size = new System.Drawing.Size(13, 13);
            this.checkListlbl.TabIndex = 16;
            this.checkListlbl.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.checkListlbl);
            this.Controls.Add(this.szczegolyPods);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cenaValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.listBox.ResumeLayout(false);
            this.listBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iloscListu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iloscPaczek)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.ComboBox rozmiarListuBox;
        private System.Windows.Forms.GroupBox listBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox odbiorListuCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton emailList;
        private System.Windows.Forms.RadioButton smsList;
        private System.Windows.Forms.Button obliczListbtn;
        private System.Windows.Forms.NumericUpDown iloscListu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox trescListuBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button obliczPaczkabtn;
        private System.Windows.Forms.NumericUpDown iloscPaczek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox trescPaczkiBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton emailPaczka;
        private System.Windows.Forms.RadioButton smsPaczka;
        private System.Windows.Forms.CheckBox odbiorPaczkiCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox rozmiarPaczkiBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cenaValue;
        private System.Windows.Forms.Label szczegolyPods;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label checkListlbl;
    }
}

