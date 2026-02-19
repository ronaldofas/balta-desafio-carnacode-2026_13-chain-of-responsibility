using ChainOfResponsibility;

Console.WriteLine("=== Sistema de Aprovação de Despesas (Chain of Responsibility) ===\n");

// Montando a cadeia de responsabilidade
var supervisor = new SupervisorHandler();
var gerente = new GerenteHandler();
var diretor = new DiretorHandler();
var ceo = new CeoHandler();

supervisor
    .SetNext(gerente)
    .SetNext(diretor)
    .SetNext(ceo);

// Testes com diferentes valores
var despesas = new[]
{
    new ExpenseRequest("João Silva", 50.00m, "Material de escritório", "TI"),
    new ExpenseRequest("Maria Santos", 350.00m, "Curso de capacitação", "RH"),
    new ExpenseRequest("Pedro Oliveira", 2500.00m, "Notebook", "TI"),
    new ExpenseRequest("Ana Costa", 15000.00m, "Servidor para datacenter", "TI")
};

foreach (var despesa in despesas)
{
    Console.WriteLine($"\n=== Processando Despesa ===");
    Console.WriteLine($"Funcionário: {despesa.EmployeeName}");
    Console.WriteLine($"Valor: R$ {despesa.Amount:N2}");
    Console.WriteLine($"Propósito: {despesa.Purpose}");
    Console.WriteLine($"Departamento: {despesa.Department}\n");

    supervisor.Handle(despesa);
}

Console.WriteLine("\n=== BENEFÍCIOS DO CHAIN OF RESPONSIBILITY ===");
Console.WriteLine("✓ Cada aprovador é independente e com responsabilidade única");
Console.WriteLine("✓ Fácil adicionar/remover níveis sem modificar código existente");
Console.WriteLine("✓ Cadeia montada dinamicamente — flexível e configurável");
Console.WriteLine("✓ Cada handler pode ser testado isoladamente");
Console.WriteLine("✓ Respeita o Open/Closed Principle");
