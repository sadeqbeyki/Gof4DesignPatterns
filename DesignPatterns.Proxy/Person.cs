namespace DesignPatterns.Proxy;
//step 1
public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
//step 2
public interface IPersonRepository
{
    List<Person> GetAll();
    void Add(Person person);
    Person GetById(int id);
}
//step 3
public class InMemoryPersonRepository : IPersonRepository
{
    private readonly List<Person> list = new List<Person>
    {
        new Person
        {
            Id= 1,
            FirstName="dorsa",
            LastName="sahmani"
        },
        new Person
        {
            Id= 2,
            FirstName = "Pantea",
            LastName = "Behzad"
        }
    };
    public void Add(Person person)
    {
        person.Id = list.Count + 1;
        list.Add(person);
    }

    public List<Person> GetAll()
    {
        return list;
    }

    public Person GetById(int id)
    {
        return list.FirstOrDefault(x => x.Id == id);
    }
}

//step 4
public class CachePersonRepository : IPersonRepository
{
    private readonly IPersonRepository personRepository;

    public CachePersonRepository(IPersonRepository personRepository)
    {
        this.personRepository = personRepository;
    }

    public void Add(Person person)
    {
        personRepository.Add(person);
    }

    public List<Person> GetAll()
    {
        // check cache if not exist
        if (1 == 1)
        {
            var result = personRepository.GetAll();
            //add result to cache
        }
        var cacheResult = new List<Person>(); //Read From Cache
        return cacheResult;
    }

    public Person GetById(int id)
    {
        // check cache if not exist
        if (1 == 1)
        {
            var result = personRepository.GetAll();
            //add result to cache
        }
        var cacheResult = new Person(); //Read From Cache
        return cacheResult;
    }
}
