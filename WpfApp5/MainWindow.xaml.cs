using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows;

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        public SerializableLibrary Books { get; set; } 

        public MainWindow()
        {
            InitializeComponent();
            LoadBooks();
            this.DataContext = this;
        }

        private void LoadBooks()
        {
            Books = new SerializableLibrary();
            BookBuilder bookBuilder = new BookBuilder();
            Book book = bookBuilder
                .SetTitle("The Lord of the Rings")
                .SetAuthor("J. R. R. Tolkien")
                .SetGenres(new[] { "Fantasy", "Adventure" })
                .SetISBN("978-0-618-57498-4")
                .SetPublicationDate(new DateTime(1954, 7, 29))
                .SetAnnotation("The Lord of the Rings is an epic high-fantasy novel written by English author and scholar J. R. R. Tolkien.")
                .SetTags(new[] { "fantasy", "adventure", "classic" })
                .Build();
            Books.AddBook(book);
            var secondBookBuilder = new BookBuilder();
            var secondBook = secondBookBuilder
                .SetTitle("The Hobbit")
                .SetAuthor("J. R. R. Tolkien")
                .SetGenres(new[] { "Fantasy", "Adventure" })
                .SetISBN("978-0-618-57498-5")
                .SetPublicationDate(new DateTime(1937, 9, 21))
                .SetAnnotation("The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien.")
                .SetTags(new[] { "fantasy", "adventure", "classic" })
                .Build();
            Books.AddBook(secondBook);
            BookCatalog.ItemsSource = Books.GetCatalog();
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
        }
        private void FilterBooks_Click(object sender, RoutedEventArgs e)
        {  
        }
    }
}