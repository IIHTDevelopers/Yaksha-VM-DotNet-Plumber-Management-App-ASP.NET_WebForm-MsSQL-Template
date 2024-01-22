using PlumberManagementApp.DAL;
using PlumberManagementApp.Model;
using System;
using System.Web.UI;

namespace PlumberManagementApp
{
    public partial class PlumberManagement : Page
    {
        private readonly datalayer _dataLayer;
        private readonly PlumberManagementApp.DAL.Interfaces.IPlumberService _plumberService;

        public PlumberManagement()
        {
            _dataLayer = new datalayer();
            _plumberService = new DAL.Services.PlumberService(new DAL.Services.PlumberRepository(new PlumberManagementApp.DAL.PlumberDbContext()));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            var plumbers = _plumberService.GetAll();
            _dataLayer.fillgridView(plumbers, gv);
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = gv.SelectedRow.Cells[1].Text;
            // Retrieve the plumber details and populate the form
            var plumber = _plumberService.GetById(id);
            if (plumber != null)
            {
                txtFirstName.Text = plumber.FirstName;
                txtLastName.Text = plumber.LastName;
                txtDateOfBirth.Text = plumber.DateOfBirth.ToString("yyyy-MM-dd");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var newPlumber = new PlumberModel
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = DateTime.Parse(txtDateOfBirth.Text)
            };

            _plumberService.Add();
            BindGridView();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = gv.SelectedRow.Cells[1].Text.ToString();
            var existingPlumber = _plumberService.GetById(id);

            if (existingPlumber != null)
            {
                existingPlumber.LastName = txtLastName.Text;
                existingPlumber.FirstName = txtFirstName.Text;
                existingPlumber.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text);

                _plumberService.Update();
                BindGridView();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string id = gv.SelectedRow.Cells[1].Text.ToString();
            _plumberService.Delete();
            BindGridView();
        }
    }
}
