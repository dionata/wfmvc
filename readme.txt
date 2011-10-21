***********************************************************************************************
WFMVC é uma biblioteca de utilitários para aplicações Windows Forms com a implementação 
do padrão MVC.
Possui Logger (Log4Net), Validação, Extensões MVC para Windows Forms.

Para utilizar a biblioteca, basta adicioná-la às referências do seu projeto.

1. Logger: O simples logger somente precisa ser invocado no momento em que for necessário 
o log de algum evento na aplicação. Aconselhamos a utilização do log como Propriedade 
privada ou protegida da sua classe, para que seus recursos sejam utilizados corretamente.

2. Exceptions: Ainda não finalizado.

3. Validação: O sistema de validação se baseia em um Enum e uma classe Validator.
Instancie um Validator no cabeçalho da sua classe para que ele esteja disponível.
Adicione um método para os eventos delegados do validator caso queira utilizá-lo dinamicamente
em campos de texto de informação.

4. O provedor MvcFormApplication fornece métodos de extensão para objetos e subtipos de 
System.Windows.Forms, para que seu conteúdo seja traduzido em Modelos de Domínio (Entidades).
Para tanto basta que seu formulário contenha os controles com os nomes idênticos 
às propriedades da sua classe de Modelo.