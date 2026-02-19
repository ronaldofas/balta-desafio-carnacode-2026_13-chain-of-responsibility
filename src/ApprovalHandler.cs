namespace ChainOfResponsibility;

public abstract class ApprovalHandler
{
    private ApprovalHandler? _nextHandler;

    public ApprovalHandler SetNext(ApprovalHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public virtual void Handle(ExpenseRequest request)
    {
        if (_nextHandler is not null)
            _nextHandler.Handle(request);
        else
            Console.WriteLine($"❌ Nenhum aprovador disponível para a despesa de R$ {request.Amount:N2}");
    }
}
