namespace ChainOfResponsibility;

public class GerenteHandler : ApprovalHandler
{
    private const decimal LimiteAprovacao = 500m;

    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= LimiteAprovacao)
        {
            Console.WriteLine($"[Gerente] Analisando pedido...");
            Console.WriteLine($"  → Validando nota fiscal...");
            Console.WriteLine($"  → Verificando orçamento do departamento {request.Department}...");
            Console.WriteLine($"  → Verificando conformidade com política...");
            Console.WriteLine($"✅ [Gerente] Despesa de R$ {request.Amount:N2} APROVADA");
        }
        else
        {
            Console.WriteLine("[Gerente] Valor acima do meu limite, encaminhando...");
            base.Handle(request);
        }
    }
}
