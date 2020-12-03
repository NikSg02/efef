using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nik_block;
using System.Data.Entity;




namespace Tinker_quest
{
    public partial class Form2 : Form
    {
        IdProdukts model = new IdProdukts();
        public Form2()
        {
            InitializeComponent();
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtArt.Text = txtName.Text = txtRemove.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.IdGoods = 0;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кудашкинDataSet.IdProdukts". При необходимости она может быть перемещена или удалена.
            this.idProduktsTableAdapter.Fill(this.кудашкинDataSet.IdProdukts);
            Clear();
            PopulateDataGridView();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Article = txtArt.Text.Trim();
            model.Name = txtName.Text.Trim();
            model.Remove = txtRemove.Text.Trim();
            using (КудашкинEntities db = new КудашкинEntities())
            {
                if (model.IdGoods == 0)//Insert
                    db.IdProdukts.Add(model);
                else //Update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");
        }
        void PopulateDataGridView()
        {
            dgvIdProdukts.AutoGenerateColumns = false;
            using (КудашкинEntities db = new КудашкинEntities())
            {
                dgvIdProdukts.DataSource = db.IdProdukts.ToList<IdProdukts>();

            }
        }

        private void dgvIdProdukts_DoubleClick(object sender, EventArgs e)
        {     
          if(dgvIdProdukts.CurrentRow.Index != -1)
            {
                model.IdGoods = Convert.ToInt32(dgvIdProdukts.CurrentRow.Cells["IdGoods"].Value);
                using (КудашкинEntities db = new КудашкинEntities())
                {
                    model = db.IdProdukts.Where(x => x.IdGoods == model.IdGoods).FirstOrDefault();
                    txtArt.Text = model.Article;
                    txtName.Text = model.Name;
                    txtRemove.Text = model.Remove;
                    
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (КудашкинEntities db = new КудашкинEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.IdProdukts.Attach(model);
                    db.IdProdukts.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }
    }

}
