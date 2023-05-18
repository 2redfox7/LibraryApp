namespace Library.App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            takeBook = new Button();
            findBooksGenre = new Button();
            findBooksAuthor = new Button();
            returnBook = new Button();
            getAllBooks = new Button();
            addBook = new Button();
            listGenre = new ListBox();
            textAuthor = new TextBox();
            addName = new TextBox();
            addAuthor = new TextBox();
            addGenre = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textTime = new TextBox();
            label3 = new Label();
            label5 = new Label();
            listUserBooks = new ListBox();
            booksUser = new Button();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            bookName = new ColumnHeader();
            bookAuthor = new ColumnHeader();
            genre = new ColumnHeader();
            available = new ColumnHeader();
            reviews = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // takeBook
            // 
            takeBook.BackColor = Color.Tan;
            takeBook.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            takeBook.Location = new Point(36, 148);
            takeBook.Name = "takeBook";
            takeBook.Size = new Size(165, 57);
            takeBook.TabIndex = 0;
            takeBook.Text = "Взять книгу";
            takeBook.UseVisualStyleBackColor = false;
            takeBook.Click += takeBook_Click;
            // 
            // findBooksGenre
            // 
            findBooksGenre.BackColor = SystemColors.AppWorkspace;
            findBooksGenre.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            findBooksGenre.Location = new Point(460, 148);
            findBooksGenre.Name = "findBooksGenre";
            findBooksGenre.Size = new Size(153, 57);
            findBooksGenre.TabIndex = 1;
            findBooksGenre.Text = "Найти книгу по жанру";
            findBooksGenre.UseVisualStyleBackColor = false;
            findBooksGenre.Click += findBooksGenre_Click;
            // 
            // findBooksAuthor
            // 
            findBooksAuthor.BackColor = SystemColors.AppWorkspace;
            findBooksAuthor.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            findBooksAuthor.Location = new Point(628, 148);
            findBooksAuthor.Name = "findBooksAuthor";
            findBooksAuthor.Size = new Size(160, 57);
            findBooksAuthor.TabIndex = 2;
            findBooksAuthor.Text = "Найти книгу по автору";
            findBooksAuthor.UseVisualStyleBackColor = false;
            findBooksAuthor.Click += findBooksAuthor_Click;
            // 
            // returnBook
            // 
            returnBook.BackColor = Color.Tan;
            returnBook.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            returnBook.Location = new Point(1197, 527);
            returnBook.Name = "returnBook";
            returnBook.Size = new Size(165, 57);
            returnBook.TabIndex = 3;
            returnBook.Text = "Вернуть книгу";
            returnBook.UseVisualStyleBackColor = false;
            returnBook.Click += returnBook_Click;
            // 
            // getAllBooks
            // 
            getAllBooks.BackColor = SystemColors.AppWorkspace;
            getAllBooks.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            getAllBooks.Location = new Point(252, 148);
            getAllBooks.Name = "getAllBooks";
            getAllBooks.Size = new Size(202, 57);
            getAllBooks.TabIndex = 4;
            getAllBooks.Text = "Посмотреть список \r\nвсех книг";
            getAllBooks.UseVisualStyleBackColor = false;
            getAllBooks.Click += getAllBooks_Click;
            // 
            // addBook
            // 
            addBook.BackColor = Color.Tan;
            addBook.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            addBook.Location = new Point(36, 326);
            addBook.Name = "addBook";
            addBook.Size = new Size(165, 57);
            addBook.TabIndex = 5;
            addBook.Text = "Добавить книгу";
            addBook.UseVisualStyleBackColor = false;
            addBook.Click += addBook_Click;
            // 
            // listGenre
            // 
            listGenre.BackColor = Color.Ivory;
            listGenre.DrawMode = DrawMode.OwnerDrawFixed;
            listGenre.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            listGenre.FormattingEnabled = true;
            listGenre.ItemHeight = 21;
            listGenre.Location = new Point(460, 114);
            listGenre.Name = "listGenre";
            listGenre.Size = new Size(153, 25);
            listGenre.TabIndex = 7;
            listGenre.DrawItem += listGenre_DrawItem;
            // 
            // textAuthor
            // 
            textAuthor.BackColor = Color.Ivory;
            textAuthor.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textAuthor.Location = new Point(628, 114);
            textAuthor.Name = "textAuthor";
            textAuthor.Size = new Size(160, 28);
            textAuthor.TabIndex = 8;
            // 
            // addName
            // 
            addName.BackColor = Color.Ivory;
            addName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            addName.Location = new Point(36, 421);
            addName.Name = "addName";
            addName.Size = new Size(165, 28);
            addName.TabIndex = 9;
            // 
            // addAuthor
            // 
            addAuthor.BackColor = Color.Ivory;
            addAuthor.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            addAuthor.Location = new Point(36, 483);
            addAuthor.Name = "addAuthor";
            addAuthor.Size = new Size(165, 28);
            addAuthor.TabIndex = 10;
            // 
            // addGenre
            // 
            addGenre.BackColor = Color.Ivory;
            addGenre.DrawMode = DrawMode.OwnerDrawFixed;
            addGenre.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            addGenre.FormattingEnabled = true;
            addGenre.ItemHeight = 21;
            addGenre.Location = new Point(36, 559);
            addGenre.Name = "addGenre";
            addGenre.Size = new Size(165, 25);
            addGenre.TabIndex = 11;
            addGenre.DrawItem += addGenre_DrawItem;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.NavajoWhite;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 25);
            label1.Name = "label1";
            label1.Size = new Size(406, 27);
            label1.TabIndex = 12;
            label1.Text = "Добро пожаловать в библиотеку!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(36, 65);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 13;
            // 
            // textTime
            // 
            textTime.BackColor = Color.Ivory;
            textTime.Location = new Point(36, 280);
            textTime.Name = "textTime";
            textTime.Size = new Size(165, 27);
            textTime.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 223);
            label3.Name = "label3";
            label3.Size = new Size(165, 42);
            label3.TabIndex = 16;
            label3.Text = "На какой срок \r\nхотите взять книгу?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Tan;
            label5.Font = new Font("Century Gothic", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1077, 164);
            label5.Name = "label5";
            label5.Size = new Size(212, 23);
            label5.TabIndex = 19;
            label5.Text = "Книги, взятые Вами:";
            // 
            // listUserBooks
            // 
            listUserBooks.BackColor = Color.Ivory;
            listUserBooks.DrawMode = DrawMode.OwnerDrawVariable;
            listUserBooks.Font = new Font("Century Gothic", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
            listUserBooks.FormattingEnabled = true;
            listUserBooks.ItemHeight = 20;
            listUserBooks.Location = new Point(970, 216);
            listUserBooks.Name = "listUserBooks";
            listUserBooks.Size = new Size(392, 304);
            listUserBooks.TabIndex = 20;
            listUserBooks.DrawItem += listUserBooks_DrawItem;
            listUserBooks.MeasureItem += listUserBooks_MeasureItem;
            // 
            // booksUser
            // 
            booksUser.BackColor = SystemColors.AppWorkspace;
            booksUser.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            booksUser.Location = new Point(970, 526);
            booksUser.Name = "booksUser";
            booksUser.Size = new Size(216, 57);
            booksUser.TabIndex = 21;
            booksUser.Text = "Посмотреть список \r\nвзятых книг";
            booksUser.UseVisualStyleBackColor = false;
            booksUser.Click += booksUser_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 397);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 22;
            label4.Text = "Название:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 459);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 23;
            label6.Text = "Автор:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(36, 533);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 24;
            label7.Text = "Жанр:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(496, 81);
            label8.Name = "label8";
            label8.Size = new Size(65, 21);
            label8.TabIndex = 25;
            label8.Text = "Жанр:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(674, 81);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 26;
            label9.Text = "Автор:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imgonline_com_ua_Resize_qUqTZVZ9QpDILu;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(1077, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 130);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.BackColor = Color.Ivory;
            listView1.Columns.AddRange(new ColumnHeader[] { bookName, bookAuthor, genre, available });
            listView1.Font = new Font("Century Gothic", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.LabelEdit = true;
            listView1.Location = new Point(254, 216);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(710, 368);
            listView1.TabIndex = 29;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // bookName
            // 
            bookName.Text = "Название";
            bookName.Width = 200;
            // 
            // bookAuthor
            // 
            bookAuthor.Text = "Автор";
            bookAuthor.Width = 200;
            // 
            // genre
            // 
            genre.Text = "Жанр";
            genre.Width = 160;
            // 
            // available
            // 
            available.Text = "Доступ";
            available.Width = 150;
            // 
            // reviews
            // 
            reviews.BackColor = Color.Tan;
            reviews.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            reviews.Location = new Point(818, 148);
            reviews.Name = "reviews";
            reviews.Size = new Size(212, 57);
            reviews.TabIndex = 30;
            reviews.Text = "Отзывы о книге";
            reviews.UseVisualStyleBackColor = false;
            reviews.Click += reviews_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1374, 605);
            Controls.Add(reviews);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(booksUser);
            Controls.Add(listUserBooks);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textTime);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addGenre);
            Controls.Add(addAuthor);
            Controls.Add(addName);
            Controls.Add(textAuthor);
            Controls.Add(listGenre);
            Controls.Add(addBook);
            Controls.Add(getAllBooks);
            Controls.Add(returnBook);
            Controls.Add(findBooksAuthor);
            Controls.Add(findBooksGenre);
            Controls.Add(takeBook);
            Name = "Form1";
            Text = "Библиотека";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button takeBook;
        private Button findBooksGenre;
        private Button findBooksAuthor;
        private Button returnBook;
        private Button getAllBooks;
        private Button addBook;
        private ListBox listGenre;
        private TextBox textAuthor;
        private TextBox addName;
        private TextBox addAuthor;
        private ListBox addGenre;
        private Label label1;
        private Label label2;
        private TextBox textTime;
        private Label label3;
        private Label label5;
        private ListBox listUserBooks;
        private Button booksUser;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        private ListView listView1;
        private ColumnHeader bookName;
        private ColumnHeader available;
        private ColumnHeader bookAuthor;
        private ColumnHeader genre;
        private Button reviews;
    }
}