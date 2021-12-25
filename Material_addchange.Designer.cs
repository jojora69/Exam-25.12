
namespace ex
{
    partial class Material_addchange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Material_addchange));
            this.addchange_button = new System.Windows.Forms.Button();
            this.material_type = new System.Windows.Forms.ComboBox();
            this.name_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.count_pack = new System.Windows.Forms.TextBox();
            this.unit_Box = new System.Windows.Forms.TextBox();
            this.count_stock = new System.Windows.Forms.TextBox();
            this.price_Box = new System.Windows.Forms.TextBox();
            this.min_count = new System.Windows.Forms.TextBox();
            this.descr_box = new System.Windows.Forms.TextBox();
            this.del_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addchange_button
            // 
            this.addchange_button.Location = new System.Drawing.Point(17, 581);
            this.addchange_button.Name = "addchange_button";
            this.addchange_button.Size = new System.Drawing.Size(107, 32);
            this.addchange_button.TabIndex = 0;
            this.addchange_button.Text = "Изменить";
            this.addchange_button.UseVisualStyleBackColor = true;
            this.addchange_button.Click += new System.EventHandler(this.addchange_button_Click);
            // 
            // material_type
            // 
            this.material_type.FormattingEnabled = true;
            this.material_type.Items.AddRange(new object[] {
            "Краска",
            "Резина",
            "Силикон"});
            this.material_type.Location = new System.Drawing.Point(231, 88);
            this.material_type.Name = "material_type";
            this.material_type.Size = new System.Drawing.Size(302, 21);
            this.material_type.TabIndex = 2;
            // 
            // name_Box
            // 
            this.name_Box.Location = new System.Drawing.Point(231, 35);
            this.name_Box.Multiline = true;
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(302, 30);
            this.name_Box.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование материала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип материала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество в упаковке";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Единица измерения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество на складе";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Минимальное количество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Описание";
            // 
            // count_pack
            // 
            this.count_pack.Location = new System.Drawing.Point(231, 129);
            this.count_pack.Multiline = true;
            this.count_pack.Name = "count_pack";
            this.count_pack.Size = new System.Drawing.Size(302, 30);
            this.count_pack.TabIndex = 12;
            // 
            // unit_Box
            // 
            this.unit_Box.Location = new System.Drawing.Point(231, 190);
            this.unit_Box.Multiline = true;
            this.unit_Box.Name = "unit_Box";
            this.unit_Box.Size = new System.Drawing.Size(302, 30);
            this.unit_Box.TabIndex = 13;
            // 
            // count_stock
            // 
            this.count_stock.Location = new System.Drawing.Point(231, 242);
            this.count_stock.Multiline = true;
            this.count_stock.Name = "count_stock";
            this.count_stock.Size = new System.Drawing.Size(302, 30);
            this.count_stock.TabIndex = 14;
            // 
            // price_Box
            // 
            this.price_Box.Location = new System.Drawing.Point(231, 282);
            this.price_Box.Multiline = true;
            this.price_Box.Name = "price_Box";
            this.price_Box.Size = new System.Drawing.Size(302, 30);
            this.price_Box.TabIndex = 15;
            // 
            // min_count
            // 
            this.min_count.Location = new System.Drawing.Point(232, 330);
            this.min_count.Multiline = true;
            this.min_count.Name = "min_count";
            this.min_count.Size = new System.Drawing.Size(302, 30);
            this.min_count.TabIndex = 16;
            // 
            // descr_box
            // 
            this.descr_box.Location = new System.Drawing.Point(232, 376);
            this.descr_box.Multiline = true;
            this.descr_box.Name = "descr_box";
            this.descr_box.Size = new System.Drawing.Size(302, 147);
            this.descr_box.TabIndex = 17;
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(452, 581);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(107, 32);
            this.del_button.TabIndex = 18;
            this.del_button.Text = "Удалить";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // Material_addchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 625);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.descr_box);
            this.Controls.Add(this.min_count);
            this.Controls.Add(this.price_Box);
            this.Controls.Add(this.count_stock);
            this.Controls.Add(this.unit_Box);
            this.Controls.Add(this.count_pack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.material_type);
            this.Controls.Add(this.addchange_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Material_addchange";
            this.Text = "Информация о материале";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addchange_button;
        private System.Windows.Forms.ComboBox material_type;
        private System.Windows.Forms.TextBox name_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox count_pack;
        private System.Windows.Forms.TextBox unit_Box;
        private System.Windows.Forms.TextBox count_stock;
        private System.Windows.Forms.TextBox price_Box;
        private System.Windows.Forms.TextBox min_count;
        private System.Windows.Forms.TextBox descr_box;
        private System.Windows.Forms.Button del_button;
    }
}