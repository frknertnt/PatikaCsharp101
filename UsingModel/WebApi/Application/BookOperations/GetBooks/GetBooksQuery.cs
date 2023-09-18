using WebApi.Common;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
        private readonly BookStoreDbContext _dbContext;

        public GetBooksQuery(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<BookViewModel> Handle()
        {
            var bookList = _dbContext.Books.OrderBy(b=>b.Id).ToList<Book>();
            List<BookViewModel> viewModel = new List<BookViewModel>();
            foreach (var book in bookList)
            {
                viewModel.Add(new BookViewModel()
                {
                    Title = book.Title,
                    Genre = ((GenreEnum)book.GenreId).ToString(),
                    PublisDate = book.PublishDate.Date.ToString("dd/MM/yyy"),
                    PageCount = book.PageCount, 
                });
            }
            return viewModel;
        }
    }
    public class BookViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublisDate { get; set; }
        public string Genre { get; set; }
    }
}
