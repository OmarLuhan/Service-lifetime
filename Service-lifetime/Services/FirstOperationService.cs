using Service_lifetime.Models;

namespace Service_lifetime.Services;

public interface IOperationService
{
    public object Operations();
}

public class FirstOperationService(
    IOperationTransient transientOperation,
    IOperationScoped scopedOperation,
    IOperationSingleton singletonOperation,
    IOperationSingletonInstance instanceOperation):IOperationService
{
    public object  Operations()
    {
        var operations = new{
            transient= transientOperation.OperationId,
            scoped=scopedOperation.OperationId,
            singleton=singletonOperation.OperationId,
            instance=instanceOperation.OperationId
            };
        return operations;
    }
}