using System.Xml.Schema;

namespace UML_1Lesson_Part2;

public interface IServiceInterface
{
    public void operation();
}

public class Service : IServiceInterface
{
    public void operation()
    {
        throw new NotImplementedException();
    }
}

public class Proxy : IServiceInterface
{
    private Service realService;

    public Proxy(Service s)
    {
        realService = s;
    }

    public void checkAccess() 
    {
    
    }
    public void operation()
    {
        throw new NotImplementedException();
    }

    
}
