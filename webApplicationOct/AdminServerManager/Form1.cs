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
            pnlEducation.Visible = true;
        }

        private void btnTech_Click(object sender, EventArgs e)
        {
            clearPanels();
            pnlTech.Visible = true;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            clearPanels();
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
            }
            foreach(var item in DataBase.TechnicalKnowledges)
            {
                lBoxTech.Items.Add(item);
            }
            foreach(var item in DataBase.CommonKnowledges)
            {
                lBoxPersonal.Items.Add(item);
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
    }
}
