namespace ChainOfResponsibility;

public class DiretorHandler : ApprovalHandler
{
    private const decimal LimiteAprovacao = 5000m;

    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= LimiteAprovacao)
        {
            Console.WriteLine($"[Diretor] Analisando pedido...");
            Console.WriteLine($"  → Validando nota fiscal...");
            Console.WriteLine($"  → Verificando orçamento do departamento {request.Department}...");
            Console.WriteLine($"  → Verificando conformidade com política...");
            Console.WriteLine($"  → Verificando alinhamento estratégico...");
            Console.WriteLine($"✅ [Diretor] Despesa de R$ {request.Amount:N2} APROVADA");
        }
        else
        {
            Console.WriteLine("[Diretor] Valor acima do meu limite, encaminhando...");
            base.Handle(request);
        }
    }
}
