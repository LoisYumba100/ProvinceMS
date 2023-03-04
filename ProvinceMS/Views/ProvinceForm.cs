using Microsoft.EntityFrameworkCore;
using ProvinceMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvinceMS.Views
{
    public partial class ProvinceForm : Form
    {
        private readonly ProvincesContext _context;
        public ProvinceForm()
        {
            InitializeComponent();

            _context = new ProvincesContext();
        }


        private void txtProvinceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNew_Click(object sender, EventArgs e)
        {
            //  txtProvinceName.DataBindings.Clear();
            //  txtProvinceName.Text = string.Empty;

            btnSave.Text = "Insert";
        }

        private void CreateProvince()
        {
            try
            {
                string provinceName = txtProvinceName.Text;

                if (_context.Provinces.Any(p => p.ProvinceName == provinceName))
                {
                    MessageBox.Show("This Province already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Province province = new Province();
                province.ProvinceName = provinceName;

                _context.Provinces.Add(province);
                _context.SaveChanges();

                ReadProvince();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }



        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "Insert")
                {
                    CreateProvince();
                }
                else if (btnSave.Text == "Update")
                {
                    UpdateProvince();
                    _context.SaveChanges();
                }

                ReadProvince();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void ReadProvince()
        {
            try
            {
                List<Province> provinces = new List<Province>();

                provinces = _context.Provinces
                    .OrderBy(p => p.ProvinceName).ToList();

                dgvProvinces.DataSource = provinces;


                //  txtProvinceName.DataBindings.Clear();
                //  txtProvinceName.DataBindings.Add("Text", provinces, "ProvinceName");

                btnSave.Text = "Update";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        private void UpdateProvince()
        {
            try
            {
                string provinceName = txtProvinceName.Text;

                if (string.IsNullOrWhiteSpace(provinceName))
                {
                    MessageBox.Show("Please enter a valid Province name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var province = _context.Provinces.FirstOrDefault(p => p.ProvinceName == provinceName);

                if (province == null)
                {
                    MessageBox.Show("Province name was updated successfully");
                    return;
                }

                province.ProvinceName = provinceName;

                _context.SaveChanges();

                ReadProvince();
            }
            catch (Exception ex)
            {
                MessageBox.Show("something went wrong:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteProvinces();

                ReadProvince();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void DeleteProvinces()
        {
            try
            {
                string provinceName = txtProvinceName.Text;

                var province = _context.Provinces.FirstOrDefault(p => p.ProvinceName == provinceName);

                if (province == null)
                {
                    MessageBox.Show("Province not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _context.Provinces.Remove(province);
                _context.SaveChanges();

                ReadProvince();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void ProvinceForm_Load(object sender, EventArgs e)
        {
            try
            {
                ReadProvinces();
                comboBox1.DataSource = _context.Provinces.ToList();
                comboBox1.DisplayMember = "ProvinceName";
                comboBox1.ValueMember = "ProvinceId";


                ReadDistricts();
                comboBox2.DataSource = _context.Districts.ToList();
                comboBox2.DisplayMember = "DistrictName";
                comboBox2.ValueMember = "DistrictId";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }



        private void dgvProvinces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            try
            {
                txtProvinceName.DataBindings.Clear();
                txtProvinceName.Text = string.Empty;

                btnSave.Text = "insert";

                ReadProvince();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void ReadProvinces()
        {
            try
            {
                List<Province> provinces = new List<Province>();

                provinces = _context.Provinces
                    .OrderBy(p => p.ProvinceName).ToList();


                  dgvProvinces.DataSource = provinces;

                  txtProvinceName.DataBindings.Clear();
                 txtProvinceName.DataBindings.Add("Text", provinces, "ProvinceName");

                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void ReadDistricts()
        {
            try
            {
                List<District> districts = new List<District>();

                districts = _context.Districts
                    .OrderBy(o => o.DistrictName).ToList();

                  dgvProvinces.DataSource = districts;
            }
            catch
            {
                throw;
            }
        }

        private void ReadTowns()
        {
            try
            {
                List<Town> towns = _context.Towns
                    .OrderBy(o => o.TownName).ToList();

                 dgvProvinces.DataSource = towns;
                  txtProvinceName.DataBindings.Clear();
                  txtProvinceName.DataBindings.Add("Text", towns, "TownName");
            }
            catch
            {
                throw;
            }
        }



        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProvince = comboBox1.SelectedItem as Province;
            if (selectedProvince != null)
            {
                var districts = _context.Districts
                    .Where(d => d.ProvinceId == selectedProvince.ProvinceId)
                    .OrderBy(d => d.DistrictName)
                    .ToList();
                comboBox2.DataSource = districts;
                comboBox2.DisplayMember = "DistrictName";
                comboBox2.ValueMember = "DistrictId";

                var towns = _context.Towns
                    .Where(t => t.District.ProvinceId == selectedProvince.ProvinceId)
                    .OrderBy(t => t.TownName)
                    .ToList();
                // dgvProvinces.DataSource = towns;

            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTown.Enabled = true;
        }

        //where everything will load from
        private void ProvicneForm_Load(object sender, EventArgs e)
        {

            try
            {
                ReadProvinces();
                comboBox1.DataSource = _context.Provinces.ToList();
                comboBox1.DisplayMember = "ProvinceName";
                comboBox1.ValueMember = "ProvinceId";


                ReadDistricts();
                comboBox2.DataSource = _context.Districts.ToList();
                comboBox2.DisplayMember = "DistrictName";
                comboBox2.ValueMember = "DistrictId";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int districtId = (int)comboBox2.SelectedValue;
            string townName = textBoxTown.Text;


            Town town = new Town { TownName = townName, DistrictId = districtId };

            _context.Towns.Add(town);
            _context.SaveChanges();


            BindData();
        }

        /* private void BindData()
           {
               ProvincesContext context = new ProvincesContext();
               var data = from p in _context.Provinces
                          join d in _context.Districts on p.ProvinceId equals d.ProvinceId
                          join t in _context.Towns on d.DistrictId equals t.DistrictId
                          select new { Province = p.ProvinceName, District = d.DistrictName, Town = t.TownName };

               dgvProvinces.DataSource = data.ToList();   
           }*/


        private void BindData()
        {

            using (var context = new ProvincesContext())
            {
                var data = from province in context.Provinces
                           join district in context.Districts on province.ProvinceId equals district.ProvinceId
                           join town in context.Towns on district.DistrictId equals town.DistrictId
                           select new
                           {
                               ProvinceId = province.ProvinceId,
                               ProvinceName = province.ProvinceName,
                               DistrictId = district.DistrictId,
                               DistrictName = district.DistrictName,
                               TownId = town.TownId,
                               TownName = town.TownName
                           };


                dgvProvinces.DataSource = data.ToList();
            }
        }



    }
}
