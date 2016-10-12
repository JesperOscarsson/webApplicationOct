using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminServerManager
{

    public partial class Form1 : Form
    {

        T4DBEntities DataBase;

        public Form1()
        {
            InitializeComponent();
            DataBase = new T4DBEntities();
        }

        private void btnEducation_Click(object sender, EventArgs e)
        {
            clearPanels();
            updateLists();
            pnlEducation.Visible = true;
        }

        private void btnTech_Click(object sender, EventArgs e)
        {
            clearPanels();
            updateLists();
            pnlTech.Visible = true;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            clearPanels();
            updateLists();
            pnlPersonal.Visible = true;
        }

        private void clearPanels()
        {
            pnlEducation.Visible = false;
            pnlPersonal.Visible = false;
            pnlTech.Visible = false;
            pnlAddEducation.Visible = false;
            pnlAddCom.Visible = false;
            pnlAddTech.Visible = false;
            pnlAdd.Visible = false;
        }

        private void updateLists()
        {
            //Clear lists
            lBoxEducation.Items.Clear();
            lBoxPersonal.Items.Clear();
            lBoxTech.Items.Clear();
            //Update
            foreach(var item in DataBase.Educations)
            {
                lBoxEducation.Items.Add(item);
                lBoxEducation.DisplayMember = "Course";
            }
            foreach(var item in DataBase.TechnicalKnowledges)
            {
                lBoxTech.Items.Add(item);
                lBoxTech.DisplayMember = "Skill";
            }
            foreach(var item in DataBase.CommonKnowledges)
            {
                lBoxPersonal.Items.Add(item);
                lBoxPersonal.DisplayMember = "Attribute";
            }
        }

        private void rBtnEdu_CheckedChanged(object sender, EventArgs e)
        {
            clearPanels();
            pnlAdd.Visible = true;
            pnlAddEducation.Visible = true;            
        }

        private void rBtnTechKnow_CheckedChanged(object sender, EventArgs e)
        {
            clearPanels();
            pnlAdd.Visible = true;
            pnlAddTech.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearPanels();
            pnlAdd.Visible = true;
        }

        private void rBtnComKnow_CheckedChanged(object sender, EventArgs e)
        {
            clearPanels();
            pnlAdd.Visible = true;
            pnlAddCom.Visible = true;
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            if (rBtnEdu.Checked == true && rBtnTechKnow.Checked == false && rBtnComKnow.Checked == false)
            {
                Education temp = new Education() { School = txtBoxAddEduSchool.Text, Course = txtBoxAddEduCourse.Text, Period = txtBoxAddEduPeriod.Text };

                DataBase.Educations.Add(temp);
                DataBase.SaveChanges();

                MessageBox.Show("Added to database!");
            }

            if (rBtnEdu.Checked == false && rBtnTechKnow.Checked == true && rBtnComKnow.Checked == false)
            {
                TechnicalKnowledge temp = new TechnicalKnowledge() { Skill = txtBoxAddTechSkill.Text, Proficiency = txtBoxAddTechProf.Text };

                DataBase.TechnicalKnowledges.Add(temp);
                DataBase.SaveChanges();

                MessageBox.Show("Added to database!");
            }

            if (rBtnEdu.Checked == false && rBtnTechKnow.Checked == false && rBtnComKnow.Checked == true)
            {
                CommonKnowledge temp = new CommonKnowledge() { CommonSkill = txtBAddComAttri.Text, CommonProficiency = txtBoxAddComDesc.Text };

                DataBase.CommonKnowledges.Add(temp);
                DataBase.SaveChanges();

                MessageBox.Show("Added to database!");
            }
        }
    }
}
