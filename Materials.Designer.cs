
namespace ex
{
    partial class Materials
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materials));
            this.table = new System.Windows.Forms.DataGridView();
            this.search_box = new System.Windows.Forms.TextBox();
            this.sort_box = new System.Windows.Forms.ComboBox();
            this.filtr_box = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 75);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(523, 332);
            this.table.TabIndex = 0;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // search_box
            // 
            this.search_box.ForeColor = System.Drawing.Color.Gray;
            this.search_box.Location = new System.Drawing.Point(12, 35);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(269, 20);
            this.search_box.TabIndex = 1;
            this.search_box.Text = "Введите для поиска";
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            this.search_box.Enter += new System.EventHandler(this.search_box_Enter);
            this.search_box.Leave += new System.EventHandler(this.search_box_Leave);
            // 
            // sort_box
            // 
            this.sort_box.FormattingEnabled = true;
            this.sort_box.Items.AddRange(new object[] {
            "Все типы",
            "От А до Я",
            "От Я до А",
            "Остаток на складе: возр. ",
            "Остаток на складе: убыв.",
            "Стоимость: возр. ",
            "Стоимость: убыв. "});
            this.sort_box.Location = new System.Drawing.Point(287, 35);
            this.sort_box.Name = "sort_box";
            this.sort_box.Size = new System.Drawing.Size(121, 21);
            this.sort_box.TabIndex = 2;
            this.sort_box.Text = "Сортировка";
            this.sort_box.SelectedIndexChanged += new System.EventHandler(this.sort_box_SelectedIndexChanged);
            // 
            // filtr_box
            // 
            this.filtr_box.FormattingEnabled = true;
            this.filtr_box.Items.AddRange(new object[] {
            "Все типы",
            "Краска",
            "Резина",
            "Силикон"});
            this.filtr_box.Location = new System.Drawing.Point(414, 35);
            this.filtr_box.Name = "filtr_box";
            this.filtr_box.Size = new System.Drawing.Size(121, 21);
            this.filtr_box.TabIndex = 3;
            this.filtr_box.Text = "Фильтрация";
            this.filtr_box.SelectedIndexChanged += new System.EventHandler(this.filtr_box_SelectedIndexChanged);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(12, 413);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(158, 28);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Добавить материал";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.filtr_box);
            this.Controls.Add(this.sort_box);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Materials";
            this.Text = "Материалы";
            this.Activated += new System.EventHandler(this.Materials_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.ComboBox sort_box;
        private System.Windows.Forms.ComboBox filtr_box;
        private System.Windows.Forms.Button add_button;
    }
}

