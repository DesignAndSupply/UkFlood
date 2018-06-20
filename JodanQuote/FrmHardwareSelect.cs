﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Connection;
using values;
using Statements;

namespace JodanQuote
{
    public partial class FrmHardwareSelect : Form
    {
        

        public FrmHardwareSelect()
        {
            InitializeComponent();
            Fill_data();
            Format();
           
        }
        void Set_Value()
        {

            for (int i = 0; i < grid_hardware.Rows.Count; i++)
            {

                grid_hardware.Rows[i].Cells["hardware_quantity"].Value = 1;
                grid_hardware.Rows[i].Cells["hardware_total"].Value = 0;

            }

        }

        void Fill_data()
        {


            DataTable dt_stock = new DataTable();
            SqlConnection conn = ConnectionClass.GetConnection_orderdatabase();
            SqlDataAdapter select_stock_category = new SqlDataAdapter(Statementsclass.select_stock_category, conn);
            select_stock_category.Fill(dt_stock);
            cmb_type.DataSource = dt_stock;
            cmb_type.DisplayMember = "description";
            cmb_type.ValueMember = "ID";
            cmb_type.SelectedIndex = -1;
            ConnectionClass.Dispose_connection(conn);
            
            this.c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);
        
        }
        
        void Format()
        {

            grid_hardware.EnableHeadersVisualStyles = false;
            grid_hardware.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_hardware.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_hardware.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_hardware.DefaultCellStyle.BackColor = Color.AliceBlue;

            grid_hardware_selected.EnableHeadersVisualStyles = false;
            grid_hardware_selected.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_hardware_selected.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_hardware_selected.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_hardware_selected.DefaultCellStyle.BackColor = Color.AliceBlue;


           
        }

        private void FrmHardwareSelect_Load(object sender, EventArgs e)
        {
            Set_Value();
        }

        private void grid_hardware_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            Total_cost(sender,e);
        }

        void Total_cost(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_hardware.Columns["hardware_quantity"].Index && e.RowIndex >= 0)
            {
                try
                {
                    int i = e.RowIndex;
                    double cost = Convert.ToDouble(grid_hardware.Rows[i].Cells["hardware_cost"].Value);
                    double quantity = Convert.ToInt32(grid_hardware.Rows[i].Cells["hardware_quantity"].Value);
                    if(string.IsNullOrEmpty(Convert.ToString(quantity)))
                    {

                        quantity = 1;
                    }
                    double row_total = cost * quantity;
                    if (row_total > 0)
                    {
                        grid_hardware.Rows[i].Cells["hardware_total"].Value = row_total;

                    }
                }

                catch
                {

                }

            }

        }

        private void grid_hardware_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Total_cost(sender, e);
        }

        private void cmb_type_TextChanged(object sender, EventArgs e)
        {
            if(cmb_type.SelectedIndex > 0)
            {
                if(txt_description.Text == null )
                {
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.CommandText = Statementsclass.Search_stock_category;
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@category", cmb_type.SelectedValue);
                    c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);
                    grid_hardware.DataSource = dT_hardware.c_view_hardware;

                }
                else
                {
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.CommandText = Statementsclass.Search_stock_category_description;
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@category", cmb_type.SelectedValue);
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text);
                    c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);
                    grid_hardware.DataSource = dT_hardware.c_view_hardware;
                    



                }

                Set_Value();


            }
        }

        private void pct_clear_Click(object sender, EventArgs e)
        {
            txt_description.Text = "";
            cmb_type.SelectedIndex = -1;
           
            c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            c_view_hardwareTableAdapter.Adapter.SelectCommand.CommandText = "SELECT LEFT(Description, 20) AS Description, Cost FROM c_view_hardware";
            this.c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);
            grid_hardware.DataSource = dT_hardware.c_view_hardware;
        }

        private void txt_description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                if (cmb_type.SelectedIndex < 0)
                {
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.CommandText = Statementsclass.Search_stock_description;
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text);
                    c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);
                    grid_hardware.DataSource = dT_hardware.c_view_hardware;

                }
                else
                {
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.CommandText = Statementsclass.Search_stock_category_description;
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@category", cmb_type.SelectedValue);
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text);
                    c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);
                    grid_hardware.DataSource = dT_hardware.c_view_hardware;




                }
                Set_Value();
            }
        }

        private void grid_hardware_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == grid_hardware.Columns["btn_add"].Index && e.RowIndex >= 0)
                {

                    int row = e.RowIndex;
                    int i = grid_hardware_selected.RowCount;
                    double cost = Convert.ToDouble(grid_hardware.Rows[row].Cells["hardware_cost"].Value);
                    double quantity = Convert.ToInt32(grid_hardware.Rows[row].Cells["hardware_quantity"].Value);
                    
                    double row_total = cost * quantity;
                    if (string.IsNullOrEmpty(Convert.ToString(quantity)) || quantity == 0)
                    {
                        MessageBox.Show("    Please Choose A Quantity!", "  Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;

                    }

                   

                    grid_hardware_selected.Rows.Add(1);
                    grid_hardware_selected.Rows[i].Cells["id"].Value = grid_hardware.Rows[row].Cells["hardware_id"].Value;
                    grid_hardware_selected.Rows[i].Cells["Description"].Value = grid_hardware.Rows[row].Cells["hardware_description"].Value;
                    grid_hardware_selected.Rows[i].Cells["Cost"].Value = cost;
                    grid_hardware_selected.Rows[i].Cells["Quantity"].Value = quantity;
                    grid_hardware_selected.Rows[i].Cells["Total"].Value = row_total;
                    



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "");


            }
        }

        private void grid_hardware_selected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_hardware_selected.Columns["btn_delete"].Index && e.RowIndex >= 0)
            {

                int i = e.RowIndex;
                DialogResult delete = MessageBox.Show("Remove Hardware From Item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (delete == DialogResult.Yes)
                {
                    grid_hardware_selected.Rows.RemoveAt(i);


                }


            }
        }

        private void btn_add_hardware_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_hardware_selected.Rows.Count ; i++)
            {

                int hardware_id = Convert.ToInt32(grid_hardware_selected.Rows[i].Cells["id"].Value);
                string hardware_description = Convert.ToString(grid_hardware_selected.Rows[i].Cells["Description"].Value);
                int hardware_cost = Convert.ToInt32(grid_hardware_selected.Rows[i].Cells["Cost"].Value);
                int quantity = Convert.ToInt32(grid_hardware_selected.Rows[i].Cells["Quantity"].Value);
                int total_cost = Convert.ToInt32(grid_hardware_selected.Rows[i].Cells["Total"].Value);

                SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                SqlCommand insert_hardware = new SqlCommand(Statementsclass.insert_hardware, conn);
                insert_hardware.Parameters.AddWithValue("@id", Valuesclass.quote_id);
                insert_hardware.Parameters.AddWithValue("@hardware_id", hardware_id);
                insert_hardware.Parameters.AddWithValue("@hardware_description", hardware_description);
                insert_hardware.Parameters.AddWithValue("@hardware_cost", hardware_cost);
                insert_hardware.Parameters.AddWithValue("@quantity", quantity);
                insert_hardware.Parameters.AddWithValue("@total_cost", total_cost);
                insert_hardware.ExecuteNonQuery();
                ConnectionClass.Dispose_connection(conn);





            }
            MessageBox.Show(grid_hardware_selected.RowCount + " Hardware Item(s) Added", "  Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
             this.Hide();
             FrmItem item = new FrmItem();
             item.Show();
           

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            grid_hardware_selected.Rows.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmItem item = new FrmItem();
            item.Show();
        }

        private void FrmHardwareSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_back.PerformClick();
        }
    }
}
