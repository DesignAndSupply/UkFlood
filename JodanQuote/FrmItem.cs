﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;
using values;
using Statements;
using Connection;

namespace JodanQuote
{
    public partial class FrmItem : Form
    {
        static int locked_identifiter = 0;

        public FrmItem()
        {
            InitializeComponent();
            if (Valuesclass.new_item_identifier == 0)
            {
                locked_identifiter = 0;
                lock_controls();

            }

        }

        private void FrmItem_Shown(object sender, EventArgs e)
        {
            locked_identifiter = 0;
            Fill_data();
            Format();
            //Refresh_Data();
        }

        void Fill_data()
        {
            //txt_project.Text = Valuesclass.project_id.ToString();
            //txt_item.Text = Valuesclass.item_id.ToString();
            this.sALES_LEDGERTableAdapter.Fill(dT_customer.SALES_LEDGER, Valuesclass.customer_account_ref);

            if (Valuesclass.new_item_identifier == 0)
            {
                dT_Door_Type.Clear();
                this.dt_Hardware_Item.DT_Hardware_Item.Clear();
                this.dT_Material.DT_materials.Clear();
                dt_Hardware_Item.EnforceConstraints = false;
               
                this.ada_Hardware_Item.Fill(dt_Hardware_Item.DT_Hardware_Item, Valuesclass.quote_id);
                this.ada_Item_Details.Fill(dT_Item_Details._DT_Item_Details, Valuesclass.project_id, Valuesclass.item_id, Valuesclass.revision_number);

               
              
            }
            else
            {
                Edit_Items();

            }

            
           // Refresh_Data();


        }

        void Refresh_Data()
        {


            double total = 0;
            for (int i = 0; i < grid_hardware_on_item.Rows.Count; ++i)
            {

                total += Convert.ToDouble(grid_hardware_on_item.Rows[i].Cells["Total_cost"].Value);


            }
            txt_hardware_cost.Text ="£" + total.ToString();

            if (string.IsNullOrEmpty(txt_hardware_cost.Text))
            {
                txt_hardware_cost.Text = "£0";

            }
            if (string.IsNullOrEmpty(txt_material_cost.Text))
            {
                txt_material_cost.Text = "£0";

            }
            if (string.IsNullOrEmpty(txt_labour_cost.Text))
            {
                txt_labour_cost.Text = "£0";
            }

            txt_project.Text = Valuesclass.project_id.ToString();
            txt_item.Text = Valuesclass.item_id.ToString();
            txt_revision.Text = Valuesclass.revision_number.ToString();

            double hardware_markup =Convert.ToDouble(txt_hardware_markup.Text);
            double hardware_cost = Convert.ToDouble(Convert.ToString(txt_hardware_cost.Text.Replace("£", string.Empty)));
            double sales_hardware = total * hardware_markup;
            txt_hardware_sales_cost.Text = "£" + Convert.ToString(sales_hardware);
          
            double material_markup = Convert.ToDouble(txt_material_markup.Text);
            double material_cost = Convert.ToDouble(Convert.ToString(txt_material_cost.Text.Replace("£", string.Empty)));
            double sales_material = material_cost * material_markup;
            txt_material_sales_cost.Text = "£" + Convert.ToString(sales_material);
            txt_material_cost.Text = "£" + material_cost;

            double labour_markup =Convert.ToDouble(txt_labour_markup.Text);
            double labour_cost = Convert.ToDouble(Convert.ToString(txt_labour_cost.Text.Replace("£", string.Empty)));
            double sales_labour= labour_markup * labour_cost;
            txt_labour_sales_cost.Text = "£" + Convert.ToString(sales_labour);
            txt_labour_cost.Text = "£" + labour_cost;


        }

        void Edit_Items()
        {

            this.ada_finish.Fill(dT_finish.dt_finish);
            cmb_finish.DataSource = dT_finish.dt_finish;
            cmb_finish.DisplayMember = "description";
            cmb_finish.ValueMember = "id";

            ada_materials.Fill(dT_Material.DT_materials);
            cmb_material.DataSource = dT_Material.DT_materials;
            cmb_material.DisplayMember = "description";
            cmb_material.ValueMember = "id";
            cmb_material.TabIndex = 1;

            ada_door_styles.Fill(dT_Door_Type.DT_door_styles);
            cmb_door_type.DataSource = dT_Door_Type.DT_door_styles;
            cmb_door_type.DisplayMember = "description";
            cmb_door_type.ValueMember = "id";


        }

        void Format()
        {

            grid_extras.EnableHeadersVisualStyles = false;
            grid_extras.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_extras.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_extras.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_extras.DefaultCellStyle.BackColor = Color.AliceBlue;

            grid_freehand_extras.EnableHeadersVisualStyles = false;
            grid_freehand_extras.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_freehand_extras.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_freehand_extras.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_freehand_extras.DefaultCellStyle.BackColor = Color.AliceBlue;

            grid_panel_info.EnableHeadersVisualStyles = false;
            grid_panel_info.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_panel_info.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_panel_info.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_panel_info.DefaultCellStyle.BackColor = Color.AliceBlue;

            grid_hardware_on_item.EnableHeadersVisualStyles = false;
            grid_hardware_on_item.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_hardware_on_item.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_hardware_on_item.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_hardware_on_item.DefaultCellStyle.BackColor = Color.AliceBlue;

        }

        void lock_controls()
        {
            if (locked_identifiter == 0)
            {
                foreach (Control pnl in this.Controls)
                {
                    if (pnl is Panel )
                    {
                        foreach (Control ctrl in pnl.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                        {
                            if (ctrl is TextBox)
                            {
                                ctrl.Enabled = false;
                            }
                            else if (ctrl is ComboBox)
                            {
                                ctrl.Enabled = false;
                            }
                            else if (ctrl is DataGridView)
                            {
                                ctrl.Enabled = false;
                            }
                            else if (ctrl is Button)
                            {

                                // ctrl.Enabled = false;

                            }
                            else
                            {

                            }


                        }


                    }



                }
                locked_identifiter = 1;
                btn_lock.Text = "     Unlock";
                btn_lock.Image = JodanQuote.Properties.Resources.unlock;
                btn_dimensions.Enabled = false;
                btn_printscren.Enabled = false;
                btn_revise.Enabled = false;
                btn_save.Enabled = false;
                btn_lock.Enabled = true;
                txt_project.Enabled = true;
                txt_revision.Enabled = true;
                txt_item.Enabled = true;

            }
            else
            {
                foreach (Control pnl in this.Controls)
                {
                    if (pnl is Panel & pnl.Name != "panel_customer_information")
                    {
                        foreach (Control ctrl in pnl.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                        {
                            if (ctrl is TextBox)
                            {
                                ctrl.Enabled = true;
                            }
                            else if (ctrl is ComboBox)
                            {
                                ctrl.Enabled = true;
                            }
                            else if (ctrl is DataGridView)
                            {
                                ctrl.Enabled = true;
                            }
                            else if (ctrl is Button)
                            {

                                // ctrl.Enabled = false;

                            }
                            else
                            {

                            }


                        }


                    }



                }
                btn_dimensions.Enabled = true;
                btn_printscren.Enabled = true;
                btn_revise.Enabled = true;
                btn_save.Enabled = true;
                btn_lock.Enabled = true;
                locked_identifiter = 0;
                btn_lock.Text = "       lock";
                btn_lock.Image = JodanQuote.Properties.Resources.locked;
                btn_dimensions.Enabled = true;
                Edit_Items();
            }


        }

        void Max_Quote()
        {

            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand select_max_quote_id = new SqlCommand(Statementsclass.select_max_quote_id, conn);
            SqlDataReader read_max_quote_id = select_max_quote_id.ExecuteReader();

            if (read_max_quote_id.Read())
            {
                Valuesclass.quote_id = (Convert.ToInt32(read_max_quote_id["Quote ID"])) + 1;
                read_max_quote_id.Close();
            }

            ConnectionClass.Dispose_connection(conn);

        }

        void Copy_Hardware()
        {
            Max_Quote();

            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
           
            for (int i = 0; i < grid_hardware_on_item.Rows.Count; i++)
            {

                SqlCommand insert_hardware = new SqlCommand(Statementsclass.insert_hardware, conn);
                insert_hardware.Parameters.AddWithValue("@id", Valuesclass.quote_id);
                insert_hardware.Parameters.AddWithValue("@hardware_id", grid_hardware_on_item.Rows[i].Cells["Hardware_ID"].Value);
                insert_hardware.Parameters.AddWithValue("@hardware_description", grid_hardware_on_item.Rows[i].Cells["Hardware_Description"].Value);
                insert_hardware.Parameters.AddWithValue("@hardware_cost", grid_hardware_on_item.Rows[i].Cells["Hardware_cost"].Value);
                insert_hardware.Parameters.AddWithValue("@Quantity", grid_hardware_on_item.Rows[i].Cells["qty"].Value);
                insert_hardware.Parameters.AddWithValue("@total_cost", grid_hardware_on_item.Rows[i].Cells["total_cost"].Value);
                insert_hardware.ExecuteNonQuery();



            }

            ConnectionClass.Dispose_connection(conn);




        }

        private void FrmItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
        }

        private void grid_panel_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
            }
            catch
            {


            }

        }

        private void grid_panel_info_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
            }
            catch (Exception )
            {
               

            }
        }

        private void btn_dimensions_Click(object sender, EventArgs e)
        {
            FrmDimensions dimensions = new FrmDimensions();
            dimensions.ShowDialog();
            //this.Hide();
            Valuesclass.item_id = Convert.ToInt32(txt_item.Text.ToString());
          
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuote quote = new FrmQuote();
            quote.Show();
        }

        private void btn_printscren_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
            int width = this.Width-45;
            int height = this.Height- 45;
            string path = @"\\designsvr1\apps\Design and Supply CSharp\Source Files\JodanQuote\Temp Folder\Item Printscreen.JPG";
            Bitmap printscreen = new Bitmap(width, height);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(227, 150, 0, 0, printscreen.Size);

            printscreen.Save(path, ImageFormat.Jpeg);

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;
            pd.DefaultPageSettings.Color = false;
            pd.PrintPage += PrintPage;
            pd.Print();
        }

        private void PrintPage(object o, PrintPageEventArgs e)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(@"\\designsvr1\apps\Design and Supply CSharp\Source Files\JodanQuote\Temp Folder\Item Printscreen.JPG");
            Point loc = new Point(-210, -140);
            e.Graphics.DrawImage(img, loc);
        }

        private void btn_lock_Click(object sender, EventArgs e)
        {
            lock_controls();
           // Edit_Items();

        }

        private void txt_structual_height_TextChanged(object sender, EventArgs e)
        {
           // int value = Convert.ToInt32(txt_structual_height.Text)-10;
           // txt_frame_height.Text = value.ToString();
        }

        private void txt_structual_width_TextChanged(object sender, EventArgs e)
        {
           // int value = Convert.ToInt32(txt_structual_width.Text)-6;
           // txt_frame_width.Text = value.ToString();
        }

        private void btn_add_hardware_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHardwareSelect select = new FrmHardwareSelect();
            select.Show();
        }
       
        private void btn_save_Click(object sender, EventArgs e)
        {
            Refresh_Data();



            int material_id = Convert.ToInt16(((DataRowView)cmb_material.SelectedItem)["id"]);
            string material_cost = Convert.ToString(txt_material_sales_cost.Text.Replace("£", string.Empty));
            string hardware_cost = Convert.ToString(txt_hardware_sales_cost.Text.Replace("£", string.Empty));
            string labour_cost = Convert.ToString(txt_labour_sales_cost.Text.Replace("£", string.Empty));
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand update_quotation_item = new SqlCommand(Statementsclass.update_quotation_item, conn);
            update_quotation_item.Parameters.AddWithValue("@structure_width", txt_structual_width.Text);
            update_quotation_item.Parameters.AddWithValue("@structure_height", txt_structual_height.Text);
            update_quotation_item.Parameters.AddWithValue("@frame_height", txt_frame_height.Text);
            update_quotation_item.Parameters.AddWithValue("@frame_width", txt_frame_width.Text);
            update_quotation_item.Parameters.AddWithValue("@material_thickness", cmb_material_thickness.Text);
            update_quotation_item.Parameters.AddWithValue("@material_id", material_id);
            update_quotation_item.Parameters.AddWithValue("@markup_hardware",txt_hardware_markup.Text );
            update_quotation_item.Parameters.AddWithValue("@markup_material", txt_material_markup.Text);
            update_quotation_item.Parameters.AddWithValue("@labour_rate",txt_labour_markup.Text );
            update_quotation_item.Parameters.AddWithValue("@hardware_cost", hardware_cost);
            update_quotation_item.Parameters.AddWithValue("@material_cost", material_cost);
            update_quotation_item.Parameters.AddWithValue("@labour_cost", labour_cost);
            update_quotation_item.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            update_quotation_item.Parameters.AddWithValue("@item_id", Valuesclass.item_id);
            update_quotation_item.Parameters.AddWithValue("@revision_id", Valuesclass.revision_number);
           
            update_quotation_item.ExecuteNonQuery();
            ConnectionClass.Dispose_connection(conn);
            MessageBox.Show("Item Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lock_controls();
        }
               
        private void grid_hardware_on_item_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_hardware_on_item.Columns["btn_delete"].Index && e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                int ID = Convert.ToInt32(grid_hardware_on_item.Rows[i].Cells["Id_Item_hardware"].Value);
                SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                SqlCommand delete_item_hardware = new SqlCommand(Statementsclass.delete_item_hardware, conn);
                delete_item_hardware.Parameters.AddWithValue("@ID", ID);

                delete_item_hardware.ExecuteNonQuery();
                ConnectionClass.Dispose_connection(conn);
                Fill_data();

            }
        }

        private void btn_add_hardware_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            FrmHardwareSelect select = new FrmHardwareSelect();
            select.ShowDialog();
            Fill_data();
        }

        private void cmb_material_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if(cmb_material.SelectedValue!= null)
            {
                Int16 id = Convert.ToInt16(((DataRowView)cmb_material.SelectedItem)["id"]);
                dT_Material_Thickness.EnforceConstraints = false;
                ada_material_thickness.Fill(dT_Material_Thickness._DT_Material_Thickness,id);
                cmb_material_thickness.DataSource = dT_Material_Thickness._DT_Material_Thickness;
                cmb_material_thickness.DisplayMember = "thickness";
                cmb_material_thickness.ValueMember = "thickness";
                cmb_material_thickness.TabIndex = 1;



            }

           

        }

        private void btn_revise_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you Sure You Want To Revise This Item?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {

                if (Valuesclass.new_item_identifier == 0)
                {

                    string project_id = dT_Item_Details._DT_Item_Details.Rows[0]["project_id"].ToString();
                    string item_id = dT_Item_Details._DT_Item_Details.Rows[0]["item_id"].ToString();
                    int Revision = Convert.ToInt32(dT_Item_Details._DT_Item_Details.Rows[0]["Revision_id"].ToString());
                    string order_id = dT_Item_Details._DT_Item_Details.Rows[0]["order_id"].ToString();
                    string material_id = dT_Item_Details._DT_Item_Details.Rows[0]["material_id"].ToString();
                    string finish_id = dT_Item_Details._DT_Item_Details.Rows[0]["finish_id"].ToString();
                    string door_ref = dT_Item_Details._DT_Item_Details.Rows[0]["door_ref"].ToString();
                    string door_style = dT_Item_Details._DT_Item_Details.Rows[0]["door_style"].ToString();
                    string door_type = dT_Item_Details._DT_Item_Details.Rows[0]["door_type"].ToString();
                    string structual_op_height = dT_Item_Details._DT_Item_Details.Rows[0]["structual_op_height"].ToString();
                    string structual_op_width = dT_Item_Details._DT_Item_Details.Rows[0]["structual_op_width"].ToString();
                    string frame_width = dT_Item_Details._DT_Item_Details.Rows[0]["frame_width"].ToString();
                    string frame_height = dT_Item_Details._DT_Item_Details.Rows[0]["frame_height"].ToString();
                    string total_cost = dT_Item_Details._DT_Item_Details.Rows[0]["total_cost"].ToString();
                    string material_thickness = dT_Item_Details._DT_Item_Details.Rows[0]["material_thickness"].ToString();
                    string finish_description = dT_Item_Details._DT_Item_Details.Rows[0]["finish_description"].ToString();
                    string markup_hardware = dT_Item_Details._DT_Item_Details.Rows[0]["markup_hardware"].ToString();
                    string markup_material = dT_Item_Details._DT_Item_Details.Rows[0]["markup_material"].ToString();
                    string labour_rate = dT_Item_Details._DT_Item_Details.Rows[0]["labour_rate"].ToString();
                    string material_cost = dT_Item_Details._DT_Item_Details.Rows[0]["material_cost"].ToString();
                    string hardware_cost = dT_Item_Details._DT_Item_Details.Rows[0]["hardware_cost"].ToString();
                    string labour_cost = dT_Item_Details._DT_Item_Details.Rows[0]["labour_cost"].ToString();

                    SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                    SqlCommand revise_item = new SqlCommand(Statementsclass.revise_item, conn);
                    revise_item.Parameters.AddWithValue("@item_id", item_id);
                    revise_item.Parameters.AddWithValue("@project_id", project_id);
                    revise_item.Parameters.AddWithValue("@item_date", DateTime.Now);
                    revise_item.Parameters.AddWithValue("@revision_id", Revision + 1);
                    revise_item.Parameters.AddWithValue("@material_id", material_id);
                    revise_item.Parameters.AddWithValue("@finish_id", finish_id);
                    revise_item.Parameters.AddWithValue("@door_ref", door_ref);
                    revise_item.Parameters.AddWithValue("@door_type", door_type);
                    revise_item.Parameters.AddWithValue("@door_style", door_style);
                    revise_item.Parameters.AddWithValue("@structual_op_height", structual_op_height);
                    revise_item.Parameters.AddWithValue("@structual_op_width", structual_op_width);
                    revise_item.Parameters.AddWithValue("@frame_width", frame_width);
                    revise_item.Parameters.AddWithValue("@frame_height", frame_height);
                    revise_item.Parameters.AddWithValue("@finish_description", finish_description);
                    revise_item.Parameters.AddWithValue("@material_thickness", material_thickness);
                    revise_item.Parameters.AddWithValue("@total_cost", total_cost);
                    revise_item.Parameters.AddWithValue("@created_by", loginclass.Login.globalFullName);
                    revise_item.Parameters.AddWithValue("@markup_hardware", markup_hardware);
                    revise_item.Parameters.AddWithValue("@markup_material", markup_material);
                    revise_item.Parameters.AddWithValue("@labour_rate", labour_rate);
                    revise_item.Parameters.AddWithValue("@hardware_cost", hardware_cost);
                    revise_item.Parameters.AddWithValue("@material_cost", material_cost);
                    revise_item.Parameters.AddWithValue("@labour_cost", labour_cost);
                    revise_item.ExecuteNonQuery();
                    ConnectionClass.Dispose_connection(conn);
                    Valuesclass.revision_number = Revision + 1;

                }
                Max_Quote();
                Copy_Hardware();
                
                dT_Door_Type.Clear();
                this.dt_Hardware_Item.DT_Hardware_Item.Clear();
                this.dT_Material.DT_materials.Clear();
                dt_Hardware_Item.EnforceConstraints = false;
                this.sALES_LEDGERTableAdapter.Fill(dT_customer.SALES_LEDGER, Valuesclass.customer_account_ref);
                this.ada_Hardware_Item.Fill(dt_Hardware_Item.DT_Hardware_Item, Valuesclass.quote_id);
                this.ada_Item_Details.Fill(dT_Item_Details._DT_Item_Details, Valuesclass.project_id, Valuesclass.item_id, Valuesclass.revision_number);
            }

            else
            {
                return;
            }
            locked_identifiter = 1;
            Fill_data();
            lock_controls();
            Edit_Items();
        }

        private void grid_hardware_on_item_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dT_Item_Details.Tables[0].Rows.Count <0)

            {
                if (e.ColumnIndex == 2)
                {
                    Refresh_Data();
                }


            }
           


        }

        private void txt_material_markup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Refresh_Data();

            }
            catch
            {

            }
        }

        private void txt_hardware_markup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Refresh_Data();

            }
            catch
            {

            }
        }

        private void txt_labour_markup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Refresh_Data();

            }
            catch
            {

            }
        }

        private void txt_material_cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Refresh_Data();

            }
            catch
            {

            }
        }

        private void txt_hardware_cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Refresh_Data();

            }
            catch
            {

            }
        }

        private void txt_labour_cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Refresh_Data();

            }
            catch
            {

            }
        }
    }
}

