using Library.IF;
using Library.Settings;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;
using System.Windows.Forms;
using Library.Bll;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library.App
{
    public partial class Form1 : Form
    {
        #region DI - внедрение зависимости
        // Устанавливаем зависимость от контейнера
        private static Configuration _configuration = Form2._configuration;
        private static IBook CreateBook(string name, string author, int indexGenre)
        {
            Genre genre = (Genre)indexGenre;

            var book = _configuration.Container.GetInstance<IBook>();
            book.Name = name;
            book.Author = author;
            book.Genre = genre;

            var library = _configuration.Container.GetInstance<ILibrary>();

            library.AddBook(book);
            return book;
        }
        private static ICheck CreateCheck(IBook book, int time, IUser user)
        {
            var check = _configuration.Container.GetInstance<ICheck>();
            check.Time = time;
            check.User = user;
            check.Book = book;
            check.DateTime = DateTime.Now;

            var library = _configuration.Container.GetInstance<ILibrary>();
            check.Library = library;
            library.TakeBook(check);

            return check;
        }
        private static IEnumerable<IBook> GetAllBooks()
        {
            var library = _configuration.Container.GetInstance<ILibrary>();
            var books = library.GetAllBooks();

            return books;
        }
        private static IEnumerable<ICheck> GetChecks()
        {
            var library = _configuration.Container.GetInstance<ILibrary>();
            var checks = library.GetChecks(user);

            return checks;
        }
        private static IEnumerable<IBook> FindBooksGenre(Genre genre)
        {
            var library = _configuration.Container.GetInstance<ILibrary>();
            var books = library.FindBooksGenre(genre);

            return books;
        }
        private static IEnumerable<IBook> FindBooksAuthor(string author)
        {
            var library = _configuration.Container.GetInstance<ILibrary>();
            var books = library.FindBooksAuthor(author);

            return books;
        }
        private static IBook GetBook(string name, string author)
        {
            var library = _configuration.Container.GetInstance<ILibrary>();
            var book = library.GetBook(name, author);

            return book;
        }
        private void ReturnBook(ICheck check)
        {
            var library = _configuration.Container.GetInstance<ILibrary>();
            library.ReturnBook(check);
        }
        #endregion
        private void UpdateLists()
        {
            listView1.View = View.Details;
            listUserBooks.Items.Clear();
            var checks = GetChecks();
            foreach (var _check in checks)
            {
                listUserBooks.Items.Add(_check);
            }

            listView1.Items.Clear();
            var books = GetAllBooks();
            foreach (var b in books)
            {
                ListViewItem listitem = new ListViewItem(b.Name);
                listitem.SubItems.Add(b.Author);
                listitem.SubItems.Add(b.Genre.ToString());
                listitem.SubItems.Add(b.isTaken ? "недоступна" : "доступна");
                listView1.Items.Add(listitem);
            }
        }
        private void ChangeSelectionColor(ListBox listBox, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.NavajoWhite);//Choose the color

            e.DrawBackground();
            e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
        static IUser user;

        public Form1()
        {
            InitializeComponent();
            user = Form2.currentUser;
            var library = _configuration.Container.GetInstance<ILibrary>();
            listGenre.DataSource = Enum.GetValues(typeof(Genre));
            addGenre.DataSource = Enum.GetValues(typeof(Genre));
            label1.Text = $"{library}, {user.Name}!";
        }

        private void getAllBooks_Click(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            var name = addName.Text;
            var author = addAuthor.Text;
            var genreIndex = addGenre.SelectedIndex;
            var genre = addGenre.SelectedItem;
            var confirmResult = MessageBox.Show($"Вы хотите добавить {name} - {author}, жанр {genre}. Верно?",
                                     "Подтверждение",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) { }
            else { return; }
            IBook book = CreateBook(name, author, genreIndex);

            label2.Text = $"Книга {book}\nуспешно добавлена.";

            UpdateLists();
        }

        private void findBooksGenre_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Genre genre = (Genre)listGenre.SelectedItem;
            var books = FindBooksGenre(genre);
            foreach (var b in books)
            {
                ListViewItem listitem = new ListViewItem(b.Name);
                listitem.SubItems.Add(b.Author);
                listitem.SubItems.Add(b.Genre.ToString());
                listitem.SubItems.Add(b.isTaken ? "недоступна" : "доступна");
                listView1.Items.Add(listitem);
            }
            if (listView1.Items == null)
            {
                label2.Text = "Ничего не найдено!";
            }
            else
            {
                label2.Text = $"Было найдено {listView1.Items.Count} книг\n в жанре {genre}";
            }
        }

        private void findBooksAuthor_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string author = textAuthor.Text;
            var books = FindBooksAuthor(author);
            foreach (var b in books)
            {
                ListViewItem listitem = new ListViewItem(b.Name);
                listitem.SubItems.Add(b.Author);
                listitem.SubItems.Add(b.Genre.ToString());
                listitem.SubItems.Add(b.isTaken ? "недоступна" : "доступна");
                listView1.Items.Add(listitem);
            }
            if (listView1.Items == null)
            {
                label2.Text = "Ничего не найдено!";
            }
            else
            {
                label2.Text = $"Было найдено {listView1.Items.Count} книг\n от автора {author}";
            }

        }

        private void takeBook_Click(object sender, EventArgs e)
        {
            string name;
            string author;
            try
            {
                name = listView1.SelectedItems[0].SubItems[0].Text;
                author = listView1.SelectedItems[0].SubItems[1].Text;
            }
            catch
            {
                label2.Text = "Книга не выбрана!";
                return;
            }

            IBook book = GetBook(name, author);
            if (book == null)
            {
                label2.Text = "Книга не выбрана!";
                return;
            }
            if (book.isTaken)
            {
                label2.Text = $"Книга {book}\n недоступна.";
                return;
            }
            int time;
            try
            {
                time = int.Parse(textTime.Text);
            }
            catch (Exception ex)
            {
                label2.Text = "Введите количество дней, на которое\nхотите взять книгу!";
                return;
            }
            if (time > 31)
            {
                label2.Text = $"Книгу можно взять не более чем на 31 день!";
                return;
            }
            var confirmResult = MessageBox.Show($"Вы хотите взять книгу {book}. Верно?",
                                     "Подтверждение",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) { }
            else { return; }
            var check = CreateCheck(book, time, user);

            label2.Text = check.ToString();

            UpdateLists();
        }

        private void returnBook_Click(object sender, EventArgs e)
        {
            ICheck check = (ICheck)listUserBooks.SelectedItem;
            if (check == null)
            {
                label2.Text = "Не выбрана книга, которую Вы хотите вернуть!";
                return;
            }

            IBook book = GetBook(check.BookName, check.BookAuthor);
            var confirmResult = MessageBox.Show($"Вы хотите вернуть книгу {book}. Верно?",
                                     "Подтверждение",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) { }
            else { return; }
            ReturnBook(check);
            label2.Text = $"Книга {book}\nбыла успешно возвращена!";
            confirmResult = MessageBox.Show($"Хотите оставить отзыв о книге?",
                                     "Подтверждение",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) 
            {
                Form3 form = new Form3(user, book);
                form.ShowDialog();
            }

            UpdateLists();
        }

        private void listUserBooks_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listUserBooks.Items[e.Index].ToString(), listUserBooks.Font, listUserBooks.Width).Height;
        }
        private void listUserBooks_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listUserBooks.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listUserBooks.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
            ChangeSelectionColor(listUserBooks, e);
        }

        private void booksUser_Click(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void listGenre_DrawItem(object sender, DrawItemEventArgs e)
        {
            ChangeSelectionColor(listGenre, e);
        }

        private void addGenre_DrawItem(object sender, DrawItemEventArgs e)
        {
            ChangeSelectionColor(addGenre, e);
        }

        private void reviews_Click(object sender, EventArgs e)
        {
            string name;
            string author;
            try
            {
                name = listView1.SelectedItems[0].SubItems[0].Text;
                author = listView1.SelectedItems[0].SubItems[1].Text;
            }
            catch
            {
                label2.Text = "Книга не выбрана!";
                return;
            }

            IBook book = GetBook(name, author);
            if (book == null)
            {
                label2.Text = "Книга не выбрана!";
                return;
            }
            Form3 form = new Form3(user, book);
            form.ShowDialog();
        }
    }
}