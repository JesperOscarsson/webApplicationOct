namespace AdminServerManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rBtnEdu = new System.Windows.Forms.RadioButton();
            this.rBtnTechKnow = new System.Windows.Forms.RadioButton();
            this.rBtnComKnow = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.pnlAddEducation = new System.Windows.Forms.Panel();
            this.txtBoxAddEduSchool = new System.Windows.Forms.TextBox();
            this.txtBoxAddEduCourse = new System.Windows.Forms.TextBox();
            this.txtBoxAddEduPeriod = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlAddTech = new System.Windows.Forms.Panel();
            this.txtBoxAddTechSkill = new System.Windows.Forms.TextBox();
            this.txtBoxAddTechProf = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlAddCom = new System.Windows.Forms.Panel();
            this.txtBAddComAttri = new System.Windows.Forms.TextBox();
            this.txtBoxAddComDesc = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.lBoxEducation = new System.Windows.Forms.ListBox();
            this.lBoxTech = new System.Windows.Forms.ListBox();
            this.lBoxPersonal = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAddEducation.SuspendLayout();
            this.pnlAddTech.SuspendLayout();
            this.pnlAddCom.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER MANAGER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "For updating server tables on WebAppDB";
            // 
            // rBtnEdu
            // 
            this.rBtnEdu.AutoSize = true;
            this.rBtnEdu.Location = new System.Drawing.Point(14, 206);
            this.rBtnEdu.Name = "rBtnEdu";
            this.rBtnEdu.Size = new System.Drawing.Size(73, 17);
            this.rBtnEdu.TabIndex = 0;
            this.rBtnEdu.Text = "Education";
            this.rBtnEdu.UseVisualStyleBackColor = true;
            this.rBtnEdu.CheckedChanged += new System.EventHandler(this.rBtnEdu_CheckedChanged);
            // 
            // rBtnTechKnow
            // 
            this.rBtnTechKnow.AutoSize = true;
            this.rBtnTechKnow.Location = new System.Drawing.Point(93, 206);
            this.rBtnTechKnow.Name = "rBtnTechKnow";
            this.rBtnTechKnow.Size = new System.Drawing.Size(80, 17);
            this.rBtnTechKnow.TabIndex = 1;
            this.rBtnTechKnow.Text = "Tech.Know";
            this.rBtnTechKnow.UseVisualStyleBackColor = true;
            this.rBtnTechKnow.CheckedChanged += new System.EventHandler(this.rBtnTechKnow_CheckedChanged);
            // 
            // rBtnComKnow
            // 
            this.rBtnComKnow.AutoSize = true;
            this.rBtnComKnow.Location = new System.Drawing.Point(179, 206);
            this.rBtnComKnow.Name = "rBtnComKnow";
            this.rBtnComKnow.Size = new System.Drawing.Size(66, 17);
            this.rBtnComKnow.TabIndex = 2;
            this.rBtnComKnow.Text = "Personal";
            this.rBtnComKnow.UseVisualStyleBackColor = true;
            this.rBtnComKnow.CheckedChanged += new System.EventHandler(this.rBtnComKnow_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Pick something to add";
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.Location = new System.Drawing.Point(185, 439);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAddAdd.TabIndex = 4;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = true;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // pnlAddEducation
            // 
            this.pnlAddEducation.Controls.Add(this.label15);
            this.pnlAddEducation.Controls.Add(this.label16);
            this.pnlAddEducation.Controls.Add(this.label17);
            this.pnlAddEducation.Controls.Add(this.txtBoxAddEduPeriod);
            this.pnlAddEducation.Controls.Add(this.txtBoxAddEduCourse);
            this.pnlAddEducation.Controls.Add(this.txtBoxAddEduSchool);
            this.pnlAddEducation.Location = new System.Drawing.Point(14, 233);
            this.pnlAddEducation.Name = "pnlAddEducation";
            this.pnlAddEducation.Size = new System.Drawing.Size(281, 179);
            this.pnlAddEducation.TabIndex = 5;
            this.pnlAddEducation.Visible = false;
            // 
            // txtBoxAddEduSchool
            // 
            this.txtBoxAddEduSchool.Location = new System.Drawing.Point(87, 47);
            this.txtBoxAddEduSchool.Name = "txtBoxAddEduSchool";
            this.txtBoxAddEduSchool.Size = new System.Drawing.Size(156, 20);
            this.txtBoxAddEduSchool.TabIndex = 10;
            this.txtBoxAddEduSchool.Text = "Ex. Yale University";
            // 
            // txtBoxAddEduCourse
            // 
            this.txtBoxAddEduCourse.Location = new System.Drawing.Point(87, 79);
            this.txtBoxAddEduCourse.Name = "txtBoxAddEduCourse";
            this.txtBoxAddEduCourse.Size = new System.Drawing.Size(156, 20);
            this.txtBoxAddEduCourse.TabIndex = 11;
            this.txtBoxAddEduCourse.Text = "Ex. Linear Algebra";
            // 
            // txtBoxAddEduPeriod
            // 
            this.txtBoxAddEduPeriod.Location = new System.Drawing.Point(87, 111);
            this.txtBoxAddEduPeriod.Name = "txtBoxAddEduPeriod";
            this.txtBoxAddEduPeriod.Size = new System.Drawing.Size(156, 20);
            this.txtBoxAddEduPeriod.TabIndex = 12;
            this.txtBoxAddEduPeriod.Text = "Ex. 2014 - 2016";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "School:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Course:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Period:";
            // 
            // pnlAddTech
            // 
            this.pnlAddTech.Controls.Add(this.label18);
            this.pnlAddTech.Controls.Add(this.label19);
            this.pnlAddTech.Controls.Add(this.txtBoxAddTechProf);
            this.pnlAddTech.Controls.Add(this.txtBoxAddTechSkill);
            this.pnlAddTech.Location = new System.Drawing.Point(14, 233);
            this.pnlAddTech.Name = "pnlAddTech";
            this.pnlAddTech.Size = new System.Drawing.Size(281, 179);
            this.pnlAddTech.TabIndex = 6;
            this.pnlAddTech.Visible = false;
            // 
            // txtBoxAddTechSkill
            // 
            this.txtBoxAddTechSkill.Location = new System.Drawing.Point(96, 52);
            this.txtBoxAddTechSkill.Name = "txtBoxAddTechSkill";
            this.txtBoxAddTechSkill.Size = new System.Drawing.Size(156, 20);
            this.txtBoxAddTechSkill.TabIndex = 9;
            this.txtBoxAddTechSkill.Text = "Ex. MS Word";
            // 
            // txtBoxAddTechProf
            // 
            this.txtBoxAddTechProf.Location = new System.Drawing.Point(94, 84);
            this.txtBoxAddTechProf.Name = "txtBoxAddTechProf";
            this.txtBoxAddTechProf.Size = new System.Drawing.Size(156, 20);
            this.txtBoxAddTechProf.TabIndex = 10;
            this.txtBoxAddTechProf.Text = "Ex. Average";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(59, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Skill:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Proficiency:";
            // 
            // pnlAddCom
            // 
            this.pnlAddCom.Controls.Add(this.label20);
            this.pnlAddCom.Controls.Add(this.label21);
            this.pnlAddCom.Controls.Add(this.txtBoxAddComDesc);
            this.pnlAddCom.Controls.Add(this.txtBAddComAttri);
            this.pnlAddCom.Location = new System.Drawing.Point(14, 233);
            this.pnlAddCom.Name = "pnlAddCom";
            this.pnlAddCom.Size = new System.Drawing.Size(281, 200);
            this.pnlAddCom.TabIndex = 7;
            this.pnlAddCom.Visible = false;
            // 
            // txtBAddComAttri
            // 
            this.txtBAddComAttri.Location = new System.Drawing.Point(90, 6);
            this.txtBAddComAttri.Name = "txtBAddComAttri";
            this.txtBAddComAttri.Size = new System.Drawing.Size(156, 20);
            this.txtBAddComAttri.TabIndex = 9;
            this.txtBAddComAttri.Text = "Ex. Cooperation";
            // 
            // txtBoxAddComDesc
            // 
            this.txtBoxAddComDesc.Location = new System.Drawing.Point(90, 38);
            this.txtBoxAddComDesc.Multiline = true;
            this.txtBoxAddComDesc.Name = "txtBoxAddComDesc";
            this.txtBoxAddComDesc.Size = new System.Drawing.Size(156, 156);
            this.txtBoxAddComDesc.TabIndex = 10;
            this.txtBoxAddComDesc.Text = "Ex. Good at working in teams";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Attribute:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Description:";
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.pnlAddCom);
            this.pnlAdd.Controls.Add(this.label5);
            this.pnlAdd.Controls.Add(this.label4);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.lBoxPersonal);
            this.pnlAdd.Controls.Add(this.lBoxTech);
            this.pnlAdd.Controls.Add(this.lBoxEducation);
            this.pnlAdd.Controls.Add(this.pnlAddTech);
            this.pnlAdd.Controls.Add(this.pnlAddEducation);
            this.pnlAdd.Controls.Add(this.btnAddAdd);
            this.pnlAdd.Controls.Add(this.label14);
            this.pnlAdd.Controls.Add(this.rBtnComKnow);
            this.pnlAdd.Controls.Add(this.rBtnTechKnow);
            this.pnlAdd.Controls.Add(this.rBtnEdu);
            this.pnlAdd.Location = new System.Drawing.Point(12, 52);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(379, 465);
            this.pnlAdd.TabIndex = 7;
            // 
            // lBoxEducation
            // 
            this.lBoxEducation.FormattingEnabled = true;
            this.lBoxEducation.Location = new System.Drawing.Point(3, 25);
            this.lBoxEducation.Name = "lBoxEducation";
            this.lBoxEducation.Size = new System.Drawing.Size(120, 160);
            this.lBoxEducation.TabIndex = 8;
            // 
            // lBoxTech
            // 
            this.lBoxTech.FormattingEnabled = true;
            this.lBoxTech.Location = new System.Drawing.Point(129, 25);
            this.lBoxTech.Name = "lBoxTech";
            this.lBoxTech.Size = new System.Drawing.Size(120, 160);
            this.lBoxTech.TabIndex = 9;
            // 
            // lBoxPersonal
            // 
            this.lBoxPersonal.FormattingEnabled = true;
            this.lBoxPersonal.Location = new System.Drawing.Point(255, 25);
            this.lBoxPersonal.Name = "lBoxPersonal";
            this.lBoxPersonal.Size = new System.Drawing.Size(120, 160);
            this.lBoxPersonal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Educations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Technical Knowledge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Personal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 524);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAddEducation.ResumeLayout(false);
            this.pnlAddEducation.PerformLayout();
            this.pnlAddTech.ResumeLayout(false);
            this.pnlAddTech.PerformLayout();
            this.pnlAddCom.ResumeLayout(false);
            this.pnlAddCom.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBtnEdu;
        private System.Windows.Forms.RadioButton rBtnTechKnow;
        private System.Windows.Forms.RadioButton rBtnComKnow;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Panel pnlAddEducation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBoxAddEduPeriod;
        private System.Windows.Forms.TextBox txtBoxAddEduCourse;
        private System.Windows.Forms.TextBox txtBoxAddEduSchool;
        private System.Windows.Forms.Panel pnlAddTech;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBoxAddTechProf;
        private System.Windows.Forms.TextBox txtBoxAddTechSkill;
        private System.Windows.Forms.Panel pnlAddCom;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBoxAddComDesc;
        private System.Windows.Forms.TextBox txtBAddComAttri;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lBoxPersonal;
        private System.Windows.Forms.ListBox lBoxTech;
        private System.Windows.Forms.ListBox lBoxEducation;
    }
}

