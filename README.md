![CO-1](https://github.com/user-attachments/assets/7b600675-587d-4e1a-9786-2ea50e35d8a7)

## 🥁 CarnaCode 2026 - Desafio 13 - Chain of Responsibility

Oi, eu sou o Ronaldo e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio
No desafio **Chain of Responsibility** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)


## Problema
Uma empresa precisa processar pedidos de reembolso com diferentes níveis de aprovação baseados no valor. 
O código atual usa condicionais gigantes e está difícil de manter quando novos níveis de aprovação são adicionados.

## Solução
Para resolver os problemas de acoplamento e complexidade condicional, implementamos o padrão **Chain of Responsibility**.

### Arquitetura
1. **ApprovalHandler**: Classe base abstrata que define o comportamento padrão de encadear chamadas.
2. **Handlers Concretos**: Cada cargo (Supervisor, Gerente, Diretor, CEO) é uma classe separada com sua própria regra de aprovação.
3. **Encadeamento Dinâmico**: A cadeia é montada em tempo de execução (`supervisor -> gerente -> diretor -> ceo`), permitindo flexibilidade total.

### Benefícios Alcançados
* **Desacoplamento**: Quem envia o pedido não precisa saber quem vai aprovar.
* **Single Responsibility**: Cada classe cuida apenas da sua regra de negócio.
* **Open/Closed Principle**: Novos níveis de aprovação podem ser adicionados sem tocar no código existente dos outros handlers.
* **Flexibilidade**: A ordem dos aprovadores pode ser alterada facilmente na composição da cadeia.

## Sobre o CarnaCode 2026
O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio
[Repositório central](https://github.com/ronaldofas/balta-desafio-carnacode-2026-central)
