namespace ChainOfResponsibility;

public class CeoHandler : ApprovalHandler
{
    public override void Handle(ExpenseRequest request)
    {
        Console.WriteLine($"[CEO] Analisando pedido...");
        Console.WriteLine($"  → Validando nota fiscal...");
        Console.WriteLine($"  → Verificando orçamento do departamento {request.Department}...");
        Console.WriteLine($"  → Verificando conformidade com política...");
        Console.WriteLine($"  → Verificando alinhamento estratégico...");
        Console.WriteLine($"  → Verificando aprovação do conselho...");
        Console.WriteLine($"✅ [CEO] Despesa de R$ {request.Amount:N2} APROVADA");
    }
}
