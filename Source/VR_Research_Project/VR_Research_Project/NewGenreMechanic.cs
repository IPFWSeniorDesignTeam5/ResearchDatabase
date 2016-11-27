using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VR_Research_Project
{
    public partial class NewGenreMechanic : Form
    {
        GenresAndMechanics.GenreAndMechanicsType m_kType;

        ResearchDatabaseDataSet m_kDataSet;

        public NewGenreMechanic()
        {
            InitializeComponent();
        }

        public void Initialize( GenresAndMechanics.GenreAndMechanicsType newType, ResearchDatabaseDataSet workingSet )
        {
            m_kType = newType;
            m_kDataSet = workingSet;

            switch (newType)
            {
                case GenresAndMechanics.GenreAndMechanicsType.GenreType:
                    Text = "New Genre...";
                    break;
                default:
                    Text = "New Mechanic...";
                    break;
            }
        }

        private void CancelButton_clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_clicked(object sender, EventArgs e)
        {
            errorText.Text = "";

            string newType = typeName_text.Text;

            if (m_kType == GenresAndMechanics.GenreAndMechanicsType.GenreType)
            {
                if (m_kDataSet.Genre.Where(x => x.Description.ToUpper() == newType.ToUpper()).Count() > 0)
                    errorText.Text = "That genre already exists.";
                else
                {
                    ResearchDatabaseDataSetTableAdapters.GenreTableAdapter lk_adapt = new ResearchDatabaseDataSetTableAdapters.GenreTableAdapter();
                    lk_adapt.Insert(newType);
                    lk_adapt.Update(m_kDataSet);
                    lk_adapt.Fill(m_kDataSet.Genre);
                    Close();
                }
            } else
            {
                if (m_kDataSet.Mechanic.Where(x => x.Description.ToUpper() == newType.ToUpper()).Count() > 0)
                    errorText.Text = "That mechanic already exists.";
                else
                {
                    ResearchDatabaseDataSetTableAdapters.MechanicTableAdapter lk_adapt = new ResearchDatabaseDataSetTableAdapters.MechanicTableAdapter();
                    lk_adapt.Insert(newType);
                    lk_adapt.Update(m_kDataSet);
                    lk_adapt.Fill(m_kDataSet.Mechanic);
                    Close();
                }
            }
        }
    }
}
