using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LookingGlass
{
    public partial class DataController : Form
    {
        public DataTable dtApplication;
        public DataTable dtCandidateQualification;
        public DataTable dtCadidates;
        public DataTable dtCandidateSkill;
        public DataTable dtEmployers;
        public DataTable dtQulifications;
        public DataTable dtSkills;
        public DataTable dtVacancies;
        public DataTable dtVacancyQualification;
        public DataTable dtVacancySkills;

        public DataView ApplicationView;
        public DataView CandidateQualificationView;
        public DataView CandidatesView;
        public DataView CandidatesSkillsView;
        public DataView EmployersView;
        public DataView QualificationsView;
        public DataView SkillsView;
        public DataView VacanciesView;
        public DataView VacancyQualificationView;
        public DataView VacancySkillsView;

        public MySqlDataAdapter daEmployers;
        public MySqlDataAdapter daCadidateQualification;
        public MySqlDataAdapter daCandidates;
        public MySqlDataAdapter daCandidatesSkill;
        public MySqlDataAdapter daQualifications;
        public MySqlDataAdapter daSkills;
        public MySqlDataAdapter daVacancies;
        public MySqlDataAdapter daVacancyQualification;
        public MySqlDataAdapter daVacancySkills;
        public MySqlDataAdapter daApplication;

        public CurrencyManager cmEmployer;
        public CurrencyManager cmApplication;
        public CurrencyManager cmCandidateQualification;
        public CurrencyManager cmCandidates;
        public CurrencyManager cmCandidateSkills;
        public CurrencyManager cmQualifications;
        public CurrencyManager cmSkills;
        public CurrencyManager cmVacancies;
        public CurrencyManager cmVacancyQualification;
        public CurrencyManager cmVacancySkills;



        public DataController()
        {
            InitializeComponent();
            ctcLookingGlass.Open();

             daApplication = new MySqlDataAdapter("SELECT * FROM application", ctcLookingGlass);
             daCadidateQualification = new MySqlDataAdapter("SELECT * FROM candidatequalification", ctcLookingGlass);
             daCandidates = new MySqlDataAdapter("SELECT * FROM candidates", ctcLookingGlass);
             daCandidatesSkill = new MySqlDataAdapter("SELECT * FROM candidateskill", ctcLookingGlass);
             daEmployers = new MySqlDataAdapter("SELECT * FROM employers", ctcLookingGlass);
             daQualifications = new MySqlDataAdapter("SELECT * FROM qualifications", ctcLookingGlass);
             daSkills = new MySqlDataAdapter("SELECT * FROM skills", ctcLookingGlass);
             daVacancies = new MySqlDataAdapter("SELECT * FROM vacancies", ctcLookingGlass);
             daVacancyQualification = new MySqlDataAdapter("SELECT * FROM vacancyqualification", ctcLookingGlass);
             daVacancySkills = new MySqlDataAdapter("SELECT * FROM vacancyskills", ctcLookingGlass);

            dsLGdataCon.EnforceConstraints = false;


            dtApplication = dsLGdataCon.Tables["application"];
            dtCandidateQualification = dsLGdataCon.Tables["candidatequalification"];
            dtCadidates = dsLGdataCon.Tables["candidates"];
            dtCandidateSkill = dsLGdataCon.Tables["candidateskill"];
            dtEmployers = dsLGdataCon.Tables["employers"];
            dtQulifications = dsLGdataCon.Tables["qualifications"];
            dtSkills = dsLGdataCon.Tables["skills"];
            dtVacancies = dsLGdataCon.Tables["vacancies"];
            dtVacancyQualification = dsLGdataCon.Tables["vacancyqualification"];
            dtVacancySkills = dsLGdataCon.Tables["vacancyskills"];


            daApplication.Fill(dtApplication);
            daCadidateQualification.Fill(dtCandidateQualification);
            daCandidates.Fill(dtCadidates);
            daCandidatesSkill.Fill(dtCandidateSkill);
            daEmployers.Fill(dtEmployers);
            daQualifications.Fill(dtQulifications);
            daSkills.Fill(dtSkills);
            daVacancies.Fill(dtVacancies);
            daVacancyQualification.Fill(dtVacancyQualification);
            daVacancySkills.Fill(dtVacancySkills);



            daApplication.Update(dtApplication);
            daCadidateQualification.Update(dtCandidateQualification);
            daCandidates.Update(dtCadidates);
            daCandidatesSkill.Update(dtCandidateSkill);
            daEmployers.Update(dtEmployers);
            daQualifications.Update(dtQulifications);
            daSkills.Update(dtSkills);
            daVacancies.Update(dtVacancies);
            daVacancyQualification.Update(dtVacancyQualification);
            daVacancySkills.Update(dtVacancySkills);


            ApplicationView = new DataView(dtApplication);
            CandidatesView = new DataView(dtCadidates);
            CandidatesView.Sort = "CandidateID";
            CandidateQualificationView = new DataView(dtCandidateQualification);
            CandidatesSkillsView = new DataView(dtCandidateSkill);
            EmployersView = new DataView(dtEmployers);
            EmployersView.Sort = "EmployerID";
            QualificationsView = new DataView(dtQulifications);
            QualificationsView.Sort = "QualificationID";
            SkillsView = new DataView(dtSkills);
            SkillsView.Sort = "SkillID";
            VacanciesView = new DataView(dtVacancies);
           // VacanciesView.Sort = "VacancyID";
            VacancyQualificationView = new DataView(dtVacancyQualification);
            VacancySkillsView = new DataView(dtVacancySkills);

            cmEmployer = (CurrencyManager)this.BindingContext[dsLGdataCon, "employers"];
            cmApplication = (CurrencyManager)this.BindingContext[dsLGdataCon, "application"];
            cmCandidateQualification = (CurrencyManager)this.BindingContext[dsLGdataCon, "candidatequalification"];
            cmCandidates = (CurrencyManager)this.BindingContext[dsLGdataCon, "candidates"];
            cmCandidateSkills = (CurrencyManager)this.BindingContext[dsLGdataCon, "candidateskill"];
            cmQualifications = (CurrencyManager)this.BindingContext[dsLGdataCon, "qualifications"];
            cmSkills = (CurrencyManager)this.BindingContext[dsLGdataCon, "skills"];
            cmVacancies = (CurrencyManager)this.BindingContext[dsLGdataCon, "vacancies"];
            cmVacancyQualification = (CurrencyManager)this.BindingContext[dsLGdataCon, "vacancyqualification"];
            cmVacancySkills = (CurrencyManager)this.BindingContext[dsLGdataCon, "vacancyskills"];
        }

        private void daCandidateSkill_RowUpdated(object sender, MySqlRowUpdatedEventArgs e)
        {
            int newID = 0;
            MySqlCommand idCMD = new MySqlCommand("SELECT @@IDENTITY", ctcLookingGlass);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["candidateskill"] = newID;
            }
        }
        public void AddEmployer()
        {

            daEmployers.Update(dsLGdataCon, "Employers");
        }

        public void AssignCandSkills()
        {
            daCandidatesSkill.Update(dsLGdataCon, "candidateskill");
        }


    }
}
