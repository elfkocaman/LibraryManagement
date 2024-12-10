namespace LibraryManagement
{
    partial class Form_BookLibrary
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
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.textBox_Genre = new System.Windows.Forms.TextBox();
            this.textBox_PublishedYear = new System.Windows.Forms.TextBox();
            this.dataGridView_Books = new System.Windows.Forms.DataGridView();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_BookId = new System.Windows.Forms.Label();
            this.textBox_BookId = new System.Windows.Forms.TextBox();
            this.button_Temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(162, 61);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(237, 20);
            this.textBox_Title.TabIndex = 0;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(162, 94);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(237, 20);
            this.textBox_Author.TabIndex = 1;
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Location = new System.Drawing.Point(162, 154);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(237, 20);
            this.textBox_Genre.TabIndex = 2;
            // 
            // textBox_PublishedYear
            // 
            this.textBox_PublishedYear.Location = new System.Drawing.Point(162, 125);
            this.textBox_PublishedYear.Name = "textBox_PublishedYear";
            this.textBox_PublishedYear.Size = new System.Drawing.Size(237, 20);
            this.textBox_PublishedYear.TabIndex = 3;
            // 
            // dataGridView_Books
            // 
            this.dataGridView_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Books.Location = new System.Drawing.Point(0, 327);
            this.dataGridView_Books.Name = "dataGridView_Books";
            this.dataGridView_Books.Size = new System.Drawing.Size(540, 329);
            this.dataGridView_Books.TabIndex = 4;
            this.dataGridView_Books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Books_CellClick);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(14, 215);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(125, 45);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "Kitap Ekle";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(145, 215);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(120, 45);
            this.button_Update.TabIndex = 6;
            this.button_Update.Text = "Kitap Güncelle";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(271, 215);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(122, 45);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Kitap Sil";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Başlık :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yazar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yayınlanma Yılı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tür :";
            // 
            // label_BookId
            // 
            this.label_BookId.AutoSize = true;
            this.label_BookId.Location = new System.Drawing.Point(107, 30);
            this.label_BookId.Name = "label_BookId";
            this.label_BookId.Size = new System.Drawing.Size(49, 13);
            this.label_BookId.TabIndex = 12;
            this.label_BookId.Text = "Kitap Id :";
            // 
            // textBox_BookId
            // 
            this.textBox_BookId.Location = new System.Drawing.Point(162, 27);
            this.textBox_BookId.Name = "textBox_BookId";
            this.textBox_BookId.ReadOnly = true;
            this.textBox_BookId.Size = new System.Drawing.Size(237, 20);
            this.textBox_BookId.TabIndex = 13;
            // 
            // button_Temizle
            // 
            this.button_Temizle.Location = new System.Drawing.Point(399, 215);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(120, 45);
            this.button_Temizle.TabIndex = 14;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.UseVisualStyleBackColor = true;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // Form_BookLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 657);
            this.Controls.Add(this.button_Temizle);
            this.Controls.Add(this.textBox_BookId);
            this.Controls.Add(this.label_BookId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_Books);
            this.Controls.Add(this.textBox_PublishedYear);
            this.Controls.Add(this.textBox_Genre);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.textBox_Title);
            this.MaximumSize = new System.Drawing.Size(556, 696);
            this.MinimumSize = new System.Drawing.Size(556, 696);
            this.Name = "Form_BookLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Library";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.TextBox textBox_PublishedYear;
        private System.Windows.Forms.DataGridView dataGridView_Books;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_BookId;
        private System.Windows.Forms.TextBox textBox_BookId;
        private System.Windows.Forms.Button button_Temizle;
    }
}

