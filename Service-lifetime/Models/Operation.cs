namespace Service_lifetime.Models;

public class Operation(Guid guid) : IOperationScoped, IOperationTransient,IOperationSingleton,IOperationSingletonInstance
{
    public Operation() : this(Guid.NewGuid())
    {
    }
    public Guid OperationId => guid;
}