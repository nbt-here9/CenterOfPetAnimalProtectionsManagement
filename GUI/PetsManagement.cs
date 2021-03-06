﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Windows.Forms;
using BussinessObject.DataAccess;
using DataProvider;


namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class PetsManagement : Form
    {
        tblAccount admin;
        private string _action = "Show All";
        public PetsManagement(tblAccount user)
        {
            InitializeComponent();
            this.admin = user;
            InitializeData();
            this.Text = "Pets Management";
        }


        public PetsManagement() {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData() {
            cbPetStatus.Checked = true;
            cboPetSearchType.Enabled = false;
            dtmPetSearchDateAdoptedFrom.Enabled = false;
            dtmPetSearchDateAdoptedTo.Enabled = false;
            dtmPetSearchDateAdoptedFrom.Value = new DateTime(2020, 1, 1);
            dtmPetSearchDateAdoptedTo.Value = DateTime.Today;

            //load Pet Category
            try {
                List<tblPetCategory> petCate = TblPetCategoryDAO.Instance.GetAllCategories();
                cboPetSearchCategory.DataSource = petCate;
                cboPetSearchCategory.DisplayMember = "name";
                cboPetSearchCategory.ValueMember = "id";
                cboPetSearchCategory.SelectedIndex = -1;
            } catch (EntityException) {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }  
        }

        public void ShowCreatePet()
        {
            PetDetail newForm = new PetDetail();
            Application.Run(newForm);
        }

        public void ShowPetDetail()
        {
            PetDetail newForm = new PetDetail();
            Application.Run(newForm);
        }

        public void ShowAdminHome()
        {
            AdminHome newForm = new AdminHome(admin);
            Application.Run(newForm);
        }

        private void btnCreatePet_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                PetDetail newForm = new PetDetail();
                newForm.ShowDialog();
                this.Show();
                if (newForm.IsAction) {
                    RefreshDgv();
                }
            }
            catch (Exception)
            {
                // ignored
            }

            // Thread t = new Thread(new ThreadStart(ShowCreatePet));
            // t.Start();
            // this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            // Thread t = new Thread(new ThreadStart(ShowAdminHome));
            // t.SetApartmentState(ApartmentState.STA);
            // t.Start();
            this.Close();

        }

        private void cboPetSearchCategory_SelectedIndexChanged(object sender, EventArgs e) {
            if (cboPetSearchCategory.SelectedIndex != -1) {
                int cateId = 0;
                try {
                    cateId = int.Parse(cboPetSearchCategory.SelectedValue.ToString());
                } catch (FormatException) {

                }
                var petTypes = TblPetTypeDAO.Instance.GetTypesById(cateId);
                cboPetSearchType.DataSource = petTypes;
                cboPetSearchType.DisplayMember = "name";
                cboPetSearchType.ValueMember = "id";
                cboPetSearchType.Enabled = true;
                cboPetSearchType.SelectedIndex = -1;
            } else {
                cboPetSearchType.SelectedIndex = -1;
                cboPetSearchType.Enabled = false;
            }
        }

        private void cbAdopted_CheckedChanged(object sender, EventArgs e) {
            if (cbAdopted.Checked) {
                dtmPetSearchDateAdoptedFrom.Enabled = true;
                dtmPetSearchDateAdoptedTo.Enabled = true;
            } else {
                dtmPetSearchDateAdoptedFrom.Enabled = false;
                dtmPetSearchDateAdoptedFrom.Value = new DateTime(2020, 1, 1);
                dtmPetSearchDateAdoptedTo.Enabled = false;
                dtmPetSearchDateAdoptedTo.Value = DateTime.Today;
            }
        }

        private void btnShowAllPets_Click(object sender, EventArgs e) {
            try {
                ShowAllPets();
            } catch (EntityException) {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void dgvPets_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex != -1) {
                int pID = (int)dgvPets.CurrentRow.Cells[0].Value;
                try {
                    tblPet pet = TblPetDAO.Instance.GetPetByID(pID);
                    this.Hide();
                    PetDetail frm = new PetDetail(false, pet);
                    frm.ShowDialog();
                    this.Show();
                    if (frm.IsAction) {
                        RefreshDgv();
                    }
                } catch (Exception) {

                }
            }
           
        }

        //This function will load data from list to ListView
        private void LoadListView(List<tblPet> listPet) {
            DataTable dt = new DataTable();
            dt.Columns.Add("Pet ID", typeof(int));
            dt.Columns.Add("Pet Name", typeof(string));
            dt.Columns.Add("Adopted", typeof(bool));
            if (listPet.Count != 0) {
                foreach (var pet in listPet) {
                    dt.Rows.Add(pet.id, pet.name, !string.IsNullOrEmpty(pet.adopter));
                }
            }
            dgvPets.DataSource = dt;
        }


        private void btnClearFilter_Click(object sender, EventArgs e) {
            cboPetSearchCategory.SelectedIndex = -1;
            txtPetIdSearch.Clear();
            txtPetSearchFurcolor.Clear();
            cbPetStatus.Checked = false;
            cbAdopted.Checked = false;
        }

        private void btnSearchPet_Click(object sender, EventArgs e) {
            SearchPets();
        }

        private void SearchPets() {
            //get search information
            string searchCate = cboPetSearchCategory.SelectedIndex == -1 ? "" : cboPetSearchCategory.SelectedValue.ToString();
            string searchType = cboPetSearchType.SelectedIndex != -1 ? cboPetSearchType.SelectedValue.ToString() : "";
            string searchID = txtPetIdSearch.Text.Trim();
            string searchFurColor = txtPetSearchFurcolor.Text.Trim();
            string searchStatus = cbPetStatus.Checked.ToString();
            bool isAdopted = cbAdopted.Checked;
            DateTime searchAdoptedDateFrom = dtmPetSearchDateAdoptedFrom.Value;
            DateTime searchAdoptedDateTo = dtmPetSearchDateAdoptedTo.Value;
            try {
                var list = TblPetDAO.Instance.SearchPets(searchCate, searchType, searchID,
                searchFurColor, searchStatus, isAdopted, searchAdoptedDateFrom, searchAdoptedDateTo);
                LoadListView(list);
                _action = "Search";
            } catch (EntityException) {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ShowAllPets() {
            var list = TblPetDAO.Instance.GetAllPets();
            LoadListView(list);
            _action = "Show All";
        }

        private void RefreshDgv() {
            if(_action.Equals("Show All")) {
                ShowAllPets();
            } else {
                SearchPets();
            }
        }

        private void cboPetSearchCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboPetSearchType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
