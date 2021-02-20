<h2>Projeto Desafio Localiza - Locação de veículos de passeio (.NET)</h2>
</hr>
<p>API de um processo de locação de veículos que possui as funcionalidades de registro de usuários, veículos, marcas, modelos, reservas e checklists.</p>
<h3>Equipe</h3>
</hr>
<ul>
  <li><a href="https://github.com/cassio-morais">Cássio Morais</a> ajudou no desenvolvimento, modelagem e implementação das regras de negócios do sistema, além de ser responsável por gerenciar e publicar a aplicação.</li> 
  <li><a href="https://github.com/vstorresti">Victor Torres</a> ajudou no desenvolvimento, modelagem e arquitetura do sistema, além de ser responsável por implementar configurações de segurança do sistema.</li>
</ul>
<h3>Estrutura do Projeto</h3>
</hr>
Utilizamos como referência uma abstração da arquitetura Clean, com o intuito de desacoplar a regra de negócio do sistema permitindo uma maior facilidade de manutenção.
<ul>
  <li>Domain</li> - Camada que contém nossas models/entidades, interface de repositório dessas models e a as ViewModels para Data Transfer Object.
  <li>Application</li> - Regras de negócios e suas interfaces.
  <li>Infrastructure</li> - Implementação do Entity Framework, DTO Handler e a implementação dos repositórios.
  <li>Controller</li> - Controllers, em suma. 
  <li>IoC</li> - Container para injeção de dependência das interfaces de serviço, infraestrutura (repositórios) e utilitários.
  <li>Migration</li> - Gerenciador de migrations do Entity Framework.
</ul>
