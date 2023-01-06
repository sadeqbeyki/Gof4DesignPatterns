namespace DesignPatterns.Specification;
//step 4

public interface IMovieRepository
{
    List<Movie> Search(bool? hasDVD);

    //Specification step 3
    List<Movie> Search(Specification<Movie> specifications);
}
