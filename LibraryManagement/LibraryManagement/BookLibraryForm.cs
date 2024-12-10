using LibraryManagement.Data;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form_BookLibrary : Form
    {
        private LibraryRepository _repository;
        public Form_BookLibrary()
        {
            InitializeComponent();
            _repository = new LibraryRepository();
            LoadBooks();
        }
        private void LoadBooks()
        {
            var books = _repository.GetAllBooks();
            dataGridView_Books.DataSource = books.ToList();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            // Boş alanları kontrol eden kod
            if (string.IsNullOrEmpty(textBox_Title.Text) || string.IsNullOrEmpty(textBox_Author.Text) || string.IsNullOrEmpty(textBox_Genre.Text))
            {
                MessageBox.Show("Başlık, Yazar ve Tür alanları boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Yayın yılı geçerli bir tarih olmalı
            if (!int.TryParse(textBox_PublishedYear.Text, out int publishedYear) || publishedYear > DateTime.Now.Year)
            {
                MessageBox.Show("Yayın yılı geçerli bir yıl olmalı ve gelecekteki bir tarih olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var book = new Book
            {
                Title = textBox_Title.Text,
                Author = textBox_Author.Text,
                PublishedYear = publishedYear,
                Genre = textBox_Genre.Text,

            };
            try
            {
                _repository.AddBook(book);
                LoadBooks();
                MessageBox.Show("Kitap başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception ex)
            {
                //Hata yönetimi
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView_Books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçilen satır var mı diye kontrol ediliyor
            if (e.RowIndex >= 0)
            {
                // Seçilen satır alınıyor
                var selectedRow = dataGridView_Books.Rows[e.RowIndex];


                textBox_BookId.Text = selectedRow.Cells["BookId"].Value.ToString();
                textBox_Title.Text = selectedRow.Cells["Title"].Value.ToString();
                textBox_Author.Text = selectedRow.Cells["Author"].Value.ToString();
                textBox_PublishedYear.Text = selectedRow.Cells["PublishedYear"].Value.ToString();
                textBox_Genre.Text = selectedRow.Cells["Genre"].Value.ToString();
            }
        }
        private void button_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Title.Text) || string.IsNullOrEmpty(textBox_Author.Text) || string.IsNullOrEmpty(textBox_Genre.Text))
            {
                MessageBox.Show("Başlık, Yazar ve Tür alanları boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBox_PublishedYear.Text, out int publishedYear) || publishedYear > DateTime.Now.Year)
            {
                MessageBox.Show("Yayın yılı geçerli bir yıl olmalı ve gelecekteki bir tarih olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kitap Id'sinin geçerli olduğundan emin olunuyor
            if (string.IsNullOrWhiteSpace(textBox_BookId.Text) || !int.TryParse(textBox_BookId.Text, out int bookId))
            {
                MessageBox.Show("Geçerli bir kitap seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var book = new Book
            {
                BookId = bookId,
                Title = textBox_Title.Text,
                Author = textBox_Author.Text,
                PublishedYear = publishedYear,
                Genre = textBox_Genre.Text
            };
            try
            {
                _repository.UpdateBook(book);
                LoadBooks();
                MessageBox.Show("Kitap başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_BookId.Text) || !int.TryParse(textBox_BookId.Text, out int bookId))
            {
                MessageBox.Show("Geçerli bir kitap seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                _repository.DeleteBook(bookId);
                LoadBooks();
                MessageBox.Show("Kitap başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            textBox_BookId.Text = string.Empty;
            textBox_Title.Text = string.Empty;
            textBox_Author.Text = string.Empty;
            textBox_PublishedYear.Text = string.Empty;
            textBox_Genre.Text = string.Empty;
        }
    }
}
