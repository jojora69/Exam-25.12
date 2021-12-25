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
    public partial class Materials : Form
    {
        // Строки для работы с запросами 
        string query_uni = "select material.ID as '№ п/п', material.Title as 'Наименование', materialtype.Title as 'Тип материала', material.Cost as 'Цена', material.CountInStock as 'Количество на складе', material.MinCount as 'Минимальное количество', material.CountInPack as 'Количество в упаковке', Unit as 'Единица измерения', material.Description as 'Описание' from material join materialtype on material.MaterialTypeID = materialtype.ID";
        string query_search = "";
        string query_sort = "";
        string query_filtr = "";
        public Materials()
        {
            InitializeComponent();
            get_Info(query_uni + ";");
        }
        
        //Подключение для вывода информации в таблицу P.S. Подключение к БД осуществлено в App.config
        public void get_Info(string query)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["test"].ConnectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            try
            {
                conn.Open();
                DataTable data = new DataTable();
                adapter.Fill(data);
                table.DataSource = data;
                table.ClearSelection();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + Environment.NewLine + ex.Message);
            }
        }

        // Поиск по Наименованию и Описанию
        private void search_box_TextChanged(object sender, EventArgs e)
        {
            if (search_box.Text == "" || search_box.Text == "Введите для поиска")
                query_search = " where material.ID > 0 ";
            else
                query_search = " where concat(material.Title, material.Description) like '%" + search_box.Text + "%' ";
            get_Info(query_uni + query_search + query_filtr + query_sort);
        }

        //Сортировка по наименованию, количеству на складе и цене
        private void sort_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sort_box.SelectedIndex)
            {
                case 0:
                    query_sort = " order by material.Title;";
                    break;
                case 1:
                    query_sort = " order by material.Title desc;";
                    break;
                case 2:
                    query_sort = " order by material.CountInStock;";
                    break;
                case 3:
                    query_sort = " order by material.CountInStock desc;";
                    break;
                case 4:
                    query_sort = " order by material.Cost;";
                    break;
                case 5:
                    query_sort = " order by material.Cost desc;";
                    break;
            }
            get_Info(query_uni + query_search + query_filtr + query_sort);
        }

        //Фильтрация
        private void filtr_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (filtr_box.SelectedIndex)
            {
                case 0:
                    query_filtr = "";
                    break;
                case 1:
                    query_filtr = " and material.MaterialTypeID = 1";
                    break;
                case 2:
                    query_filtr = " and material.MaterialTypeID = 2";
                    break;
                case 3:
                    query_filtr = " and material.MaterialTypeID = 3";
                    break;
            }
            get_Info(query_uni + query_search + query_filtr + query_sort);
        }

        //Переход к редактированию строки на нажатии на нужную
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table.RowCount > 0)
            {
                Material_addchange Win = new Material_addchange(Convert.ToInt32(table[0, table.CurrentRow.Index].Value), "change");
                Win.Owner = this;
                Win.Show();
            }
            else
            {
                MessageBox.Show("Вы не выбрали строку!");
            }
        }

        //Кнопка добавления
        private void add_button_Click(object sender, EventArgs e)
        {
            Material_addchange Win = new Material_addchange(0, "add");
            Win.Owner = this;
            Win.Show();
        }

        private void Materials_Activated(object sender, EventArgs e)
        {
            get_Info(query_uni + query_search + query_sort + query_filtr);
        }

        private void search_box_Leave(object sender, EventArgs e)
        {
            if (search_box.Text == "")
            {
                search_box.Text = "Введите для поиска";
                search_box.ForeColor = Color.Gray;
            }
        }

        private void search_box_Enter(object sender, EventArgs e)
        {
            
            if (search_box.Text == "Введите для поиска")
            {
                search_box.Clear();
                search_box.ForeColor = Color.Black;
            }
        }
    }
}
