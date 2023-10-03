using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DataFirst
    {

    public partial class Form1 : Form
        {

        // ---- Pagination Vairables  ----
        int PageSize = 2;
        int PageIndex = 0;
        // ---- End of Pagination Vairables  ----

        public Form1 ()
            {
            InitializeComponent();
            }

        private void Form1_Load ( object sender, EventArgs e )
            {
            GetList();
            }

        private void GetList ()
            {
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();
            var queryApprentice = from app in Context.Apprentices
                                  orderby app.ApprenticeID
                                  select new
                                      {
                                      app.ApprenticeID,
                                      Code = app.ApprenticeCode,
                                      Name = app.ApprenticeName,
                                      LastName = app.ApprenticeFamily,
                                      Age = app.ApprenticeAge
                                      };
            dataGridView1.DataSource = queryApprentice.ToArray();
            }

        private void ClearFields ()
            {
            txtCode.Text = string.Empty;
            txtCode.Tag = string.Empty;
            txtCode.Tag = null;
            txtName.Text = string.Empty;
            txtFamily.Text = string.Empty;
            txtAge.Text = string.Empty;
            errorProvider1.Clear();
            }

        private Apprentice ApprenticeGenerator ()
            {
            Apprentice apprentice = new Apprentice()
                {
                ApprenticeCode = Convert.ToInt64(txtCode.Text),
                ApprenticeName = txtName.Text,
                ApprenticeFamily = txtFamily.Text,
                ApprenticeAge = Convert.ToByte(txtAge.Text)
                };

            return apprentice;
            }

        private void dataGridView1_CellClick ( object sender, DataGridViewCellEventArgs e )
            {
            txtCode.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCode.Text = dataGridView1.CurrentRow.Cells["Code"].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtFamily.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
            txtAge.Text = dataGridView1.CurrentRow.Cells["Age"].Value.ToString();
            }

        //---- Basic TextBoxes Settings ----
        /// <summary>
        /// chaneg color of txtbox whenever Entring it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAge_Enter ( object sender, EventArgs e )
            {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.AliceBlue;
            }

        /// <summary>
        /// chaneg color of txtbox whenever LEAVING it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAge_Leave ( object sender, EventArgs e )
            {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
            }

        /// <summary>
        /// only digits & control keys are allowed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCode_KeyPress ( object sender, KeyPressEventArgs e )
            {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
            }

        //---- End of Basic TextBoxes Settings ----

        //---- Buttons ----

        /// <summary>
        /// BTN 'Insert Apprentice'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click ( object sender, EventArgs e )
            {
            Apprentice apprentice = new Apprentice();
            apprentice = ApprenticeGenerator();

            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();
            Context.Apprentices.Add(apprentice);
            Context.SaveChanges();
            GetList();
            ClearFields();
            MessageBox.Show("Apprentice Successfully Added");
            }

        /// <summary>
        /// BTN 'Edit Apprentice'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click ( object sender, EventArgs e )
            {
            long apprenticeID = Convert.ToInt64(txtCode.Tag);
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();
            Apprentice apprentice = Context.Apprentices
                .Where(c => c.ApprenticeID == apprenticeID)
                .First();

            apprentice.ApprenticeCode = Convert.ToInt64(txtCode.Text);
            apprentice.ApprenticeName = txtName.Text;
            apprentice.ApprenticeFamily = txtFamily.Text;
            apprentice.ApprenticeAge = Convert.ToByte(txtAge.Text);

            Context.SaveChanges();
            GetList();
            ClearFields();
            MessageBox.Show("Apprentice Successfully Edited");
            }

        /// <summary>
        /// BTN 'Delete Apprentice'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click ( object sender, EventArgs e )
            {
            long apprenticeID = Convert.ToInt64(txtCode.Tag);
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();
            Apprentice apprentice = Context.Apprentices
                .Where(c => c.ApprenticeID == apprenticeID)
                .First();
            if (MessageBox.Show("Do you really want to delete?", "Delete Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                Context.Apprentices.Remove(apprentice);
                Context.SaveChanges();
                GetList();
                ClearFields();
                MessageBox.Show("Apprentice Successfully Deleted");
                }
            }

        /// <summary>
        /// search by text name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged ( object sender, EventArgs e )
            {
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();
            var querySearchName = from name in Context.Apprentices
                                  where name.ApprenticeName.Contains(txtName.Text)
                                  select name;
            dataGridView1.DataSource = querySearchName.ToList();
            }

        /// <summary>
        /// search with text family
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFamily_TextChanged ( object sender, EventArgs e )
            {
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();
            var querySearchFamily = from Family in Context.Apprentices
                                    where Family.ApprenticeName.Contains(txtFamily.Text)
                                    select Family;
            dataGridView1.DataSource = querySearchFamily.ToList();
            }

        /// <summary>
        /// BTN 'Delete Query'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteQuery_Click ( object sender, EventArgs e )
            {
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();

            var queryDelete = from st in Context.Apprentices
                              where st.ApprenticeID > 10
                              select st;
            foreach (var st in queryDelete)
                {
                Context.Apprentices.Remove(st);
                }
            Context.SaveChanges();
            GetList();
            }

        /// <summary>
        /// BTN 'Selected Courses'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click ( object sender, EventArgs e )
            {
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();
            var queryFK = from st in Context.Apprentices
                          where st.CourseSelects.Count > 0
                          select st;
            dataGridView1.DataSource = queryFK.ToList();
            }

        /// <summary>
        /// BTN 'Not Selected Courses'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNotSC_Click ( object sender, EventArgs e )
            {
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();
            var queryFK = from st in Context.Apprentices
                          where st.CourseSelects.Count == 0
                          select st;
            dataGridView1.DataSource = queryFK.ToList();
            }

        /// <summary>
        /// BTN 'Join Query'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJoin_Click ( object sender, EventArgs e )
            {
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();

            var queryJoin = from st in Context.Apprentices
                            join cs in Context.CourseSelects
                            on st.ApprenticeID equals cs.FK_ApprenticeID
                            join co in Context.Courses
                            on cs.FK_CourseID equals co.CourseID
                            where st.ApprenticeAge > 30
                            select new
                                {
                                st.ApprenticeCode,
                                st.ApprenticeName,
                                st.ApprenticeFamily,
                                st.ApprenticeAge,
                                co.CourseTitle,
                                co.CourseUnits,
                                cs.CoSeDate,
                                cs.CoseScore
                                };

            dataGridView1.DataSource = queryJoin.ToList();
            }

        /// <summary>
        /// BTN 'Paging Query'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPage_Click ( object sender, EventArgs e )
            {
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();

            decimal decimalPaging = Context.Apprentices.Count() / (decimal)PageSize;
            decimal afterPoint = decimalPaging - (Math.Truncate(decimalPaging));
            if (afterPoint > 0)
                {
                decimalPaging += 1;
                }
            PageIndex = (PageIndex + 1) % Convert.ToInt32(decimalPaging);

            var queryPagination = Context.Apprentices.OrderBy(c => c.ApprenticeID)
                .Skip(PageIndex * PageSize).Take(PageSize);

            dataGridView1.DataSource = queryPagination.ToList();
            }

        /// <summary>
        /// BTN 'SP GetList'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetList_Click ( object sender, EventArgs e )
            {
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();
            dataGridView1.DataSource = Context.sp_GetListApprentice();
            }

        /// <summary>
        /// BTN 'GetList1'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetListTailored_Click ( object sender, EventArgs e )
            {
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();
            dataGridView1.DataSource = Context.sp_GetListApprentice01();
            }

        /// <summary>
        /// BTN 'SP Input'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpInput_Click ( object sender, EventArgs e )
            {
             DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();
            dataGridView1.DataSource = Context.sp_GetListApprenticeID(3);
            }

        /// <summary>
        /// BTN 'SP Output'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOutput_Click ( object sender, EventArgs e )
            {
            DB_EF_DataFirstEntities Context = new DB_EF_DataFirstEntities();
            MessageBox.Show(Context.sp_GetNumber(0).First().ToString());
            }
        }
    }
