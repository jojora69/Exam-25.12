using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex
{
    public partial class Material_addchange : Form
    {
        int ID_mat;
        public Material_addchange(int ID, string mode)
        {
            InitializeComponent();
            if(mode == "change") // Если открывается форма изменения, то делается запрос чтобы отредактировать данные
            {
                string query = "select Title, MaterialTypeID, CountInStock, Unit, CountInPack, MinCount, Cost, Description from material where ID =" + ID.ToString() + ";";
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["test"].ConnectionString);
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    if (rd.HasRows)
                        while (rd.Read())
                        {
                            name_Box.Text = rd.GetString(0);
                            material_type.SelectedIndex = Convert.ToInt32(rd.GetString(1)) - 1;
                            count_pack.Text = rd.GetString(2);
                            unit_Box.Text = rd.GetString(3);
                            count_stock.Text = rd.GetString(4);
                            price_Box.Text = rd.GetString(5);
                            min_count.Text = rd.GetString(6);
                            descr_box.Text = rd.GetString(7);
                        }
                    conn.Close();
                    ID_mat = ID;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Произошла ошибка" + Environment.NewLine + ex.Message);
                }
                
            }
            else if (mode == "add") // Если открывается форма добавления, то кнопка удаления будет скрыта, и переименована кнопка в Создать
            {
                del_button.Visible = false;
                addchange_button.Text = "Создать";
            }
        }

        // Кнопка добавления, которая выполняет запрос при определенном условии
        private void addchange_button_Click(object sender, EventArgs e)
        {
            string query = "";
            if (addchange_button.Text == "Изменить")
            {
                query = "update material set Title = '" + name_Box.Text + "', MaterialTypeID = " + (material_type.SelectedIndex + 1).ToString() + ", CountInStock = " + count_stock.Text + ", Unit = '" + unit_Box.Text + "', CountInPack = " + count_pack.Text + ", MinCount = " + min_count.Text + ", Cost = " + price_Box.Text + ", Description = '" + descr_box.Text + "' where ID =" + ID_mat.ToString() + ";";
            }
            else if (addchange_button.Text == "Создать")
            {
                query = "insert into material(Title, MaterialTypeID, CountInStock, Unit, CountInPack, MinCount, Cost, Description) values('" + name_Box.Text + "', " + (material_type.SelectedIndex + 1).ToString() + ", " + count_stock.Text + ", '" + unit_Box.Text + "', " + count_pack.Text + ", " + min_count.Text + ", " + price_Box.Text + ", '" + descr_box.Text + "');";
            }
            if (price_Box.Text.Contains(","))
            {
                MessageBox.Show("Исправьте значение стоимости! Используйте вместо запятой точку!");
            }
            else
                do_Action(query);

            this.Close();
        }

        public void do_Action(string query)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["test"].ConnectionString);
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }
        // Кнопка удаления, с подтверждением от пользователя
            private void del_button_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить материал ?", "Вы уверены?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string query = "delete from material where ID =" + ID_mat + ";";
                do_Action(query);
                this.Close();
            }
        }
    }
}
