using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.Application.BookOperations.GetBookDetail
{
    public class GetBookDetailQuery
    {
        private readonly BookStoreDbContext _dbContext;
        public int BookId { get; set; }
        public GetBookDetailQuery(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public BookDetailViewModel Handle()
        {
            var book = _dbContext.Books.Where(b=> b.Id == BookId).SingleOrDefault();
            if(book is null)
            {
                throw new InvalidOperationException("Book not found");
            }
            BookDetailViewModel viewModel = new BookDetailViewModel();
            viewModel.Title = book.Title;
            viewModel.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy");
            viewModel.Genre = ((GenreEnum)book.GenreId).ToString();
            return viewModel;
        }

    }

    public class BookDetailViewModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
    }
}
