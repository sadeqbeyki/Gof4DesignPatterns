namespace DesignPatterns.Specification;
//step 5
public class MovieRepository : IMovieRepository
{
    private readonly MovieContext _context;

    public MovieRepository(MovieContext context)
    {
        _context = context;
    }

    public List<Movie> Search(bool? hasDVD)
    {
        return _context.movies
            .Where(c => !hasDVD.HasValue
            || (hasDVD.HasValue && c.CreationDate <= DateTime.Now.AddMonths(-6))).ToList();
    }

    //Specification step 4
    public List<Movie> Search(Specification<Movie> specifications)
    {
        return _context.movies.Where(c => specifications.IsSatisfiedBy(c)).ToList();
    }
}
