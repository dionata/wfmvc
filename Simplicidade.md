# Conversao Simples #

Para que seja evitado todo o processo de conversao de um objeto em um form e virse-versa, pense no
seguinte modelo.
```
(...)
using WFMVC.Windows.Forms;
(...)
public class MeuForm : Form
{
	private void ButtonToModel_Click(object sender, EventArgs e)
	{
		/**
		 * Método que converte o formulario atual
		 * em modelo.
		 **/
		Modelo m = this.Model<Modelo>();
	}
	
	private void ButtonToForm_Click(object sender, EventArgs e)
	{
		
		Model m = new Model();
		//ou Model m = dao.GetModel();
		
		/**
		 * Método que preenche os campos do form
		 * através do objeto mapeado.
		 **/
		this.View(m);
	}
}
```

O que eu sempre procurei foi um meio fácil de converter um objeto diretamente no formulário sem ter que
executar toda uma implementação de um BindingContext, ou de ter que mapear todo o objeto com atributos
em excesso, já que gosto de utilizar atributos com NHibernate, o que implicaria em mais sujeira no codigo.

Os métodos de extensão acima convertem diretamente os objetos de acordo com os tipos das propriedades do objeto
parâmetro.

É necessário que a Classe tenha seus campos definidos como Propriedade pública.
```
public DateTime Data {get;set;}
```

E que os nomes dos controles dos formulários sejam idênticos aos nomes das propriedades da classe relacionada.
```
private DateTimePicker Data;
```