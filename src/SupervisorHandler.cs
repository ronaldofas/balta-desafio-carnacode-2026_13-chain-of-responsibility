namespace ChainOfResponsibility;

public class SupervisorHandler : ApprovalHandler
{
    private const decimal LimiteAprovacao = 100m;

    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= LimiteAprovacao)
        {
            Console.WriteLine($"[Supervisor] Analisando pedido...");
            Console.WriteLine($"  → Validando nota fiscal...");
            Console.WriteLine($"  → Verificando orçamento do departamento {request.Department}...");
            Console.WriteLine($"✅ [Supervisor] Despesa de R$ {request.Amount:N2} APROVADA");
        }
        else
        {
            Console.WriteLine("[Supervisor] Valor acima do meu limite, encaminhando...");
            base.Handle(request);
        }
    }
}
