# Modulo 2 - Aula 1

## Abstração 1:
Nesse exercício, você deverá implementar uma classe abstrata com o nome EsporteBase que será a base para outras classes. Essa classe deverá conter os seguintes métodos e propriedades abstratas:

Propriedades:
    QuantidadeJogadoresPorTime
    TempoDeJogoEmMinutos  

Métodos:
    Iniciar
    Finalizar
    ExibirDescricao  
Implemente uma segunda classe que irá herdar de EsporteBase, chamada Futebol. Essa classe deverá implementar as propriedade e métodos da classe base.

Crie um construtor para essa classe definindo as propriedades:

QuantidadeJogadoresPorTime = 11
TempoDeJogoEmMinutos = 90  
Os métodos Iniciar e Finalizar, devem retornar as frases "O jogo foi iniciado" e "O jogo foi finalizado", respectivamente.

O método ExibirDescricao deverá retornar a frase "O futebol é um esporte praticado por X jogadores em cada time durante Y minutos", onde as informações X e Y devem ser os valores das propriedades preenchidas no construtor.

## Abstração 2:
O código a seguir possui um ou mais erros que não permitem sua compilação. Identifique e reescreva o código para corrigir o problema.

public abstract class Funcionario
{
    public abstract void getBonificacao();
}

public abstract class Secretaria
{

}

public class SecretariaAdministrativa : Secretaria
{
    public override void getBonificacao()
    {
        //..
    }
}

public class SecretariaAgencia : Secretaria
{
    public override void getBonificacao()
    {
        //..
    }
}

public class Presidente : Funcionario
{
    public override void getBonificacao()
    {
        //..
    }
}

public class Gerente : Funcionario
{
    public void getBonificacao()
    {
        //..
    }
}

public class Diretor : Gerente
{

}
## Abstração 3:
Classes abstratas são úteis para implementar comportamentos comuns a classes derivadas.

Elas podem conter propriedades e métodos abstratos ou não abstratos, mas não podem ser instanciadas e podem forçar novas implementações de métodos virtuais.

Crie uma classe abstrata chamada Figura. Nessa classe, nós teremos uma propriedade abstrata cor do tipo string e um método abstrato double area().

Em seguida, vamos criar a classe Retangulo que vai herdar a classe Figura e declarar dois atributos nela como double (lado1 e lado2). Vamos também sobrescrever o método double area(), onde colocaremos um return com a função lado 1 * lado 2, para obtermos a área.

Vamos criar uma classe Triangulo que vai herdar a classe Figura com os atributos base e altura e um método double area() que retorna base * altura.

Para finalizar, vamos criar uma classe estática chamada Teste com um método estático chamado DetalhesFigura que receberá um objeto do tipo Figura e retornará as informações sobre o objeto.

Exemplo:

Retangulo retangulo = new Retangulo();
retangulo.cor = "Azul";
retangulo.lado1 = 3.5;
retangulo.lado2 = 2;
Teste.DetalhesFigura(retangulo); //"Cor da figura: Azul - Área da figura: 7"

## Abstração 4:
Classes abstratas são úteis para implementar comportamentos comuns a classes derivadas.
Escreva uma classe abstrata chamada CartaoWeb. Essa classe representa todos os tipos de cartões virtuais e conterá apenas um atributo: Destinatario (string). Nessa classe você deverá também declarar o método public abstract void ShowMessage(). Crie classes filhas da classe CartaoWeb: DiaDosNamorados, Natal, Aniversario. Cada uma dessas classes deve conter um método construtor que receba o nome do destinatário do cartão. Cada classe também deve implementar o método ShowMessage(), mostrando uma mensagem ao usuário com seu nome e que seja específica para a data de comemorativa do cartão. Ex: "Feliz Dia dos Namorados, José!", "Feliz Natal, Maria!", "Feliz Aniversário, João!"

## Interface 1:
Crie uma interface Exercicio contendo os contratos para:
FazerProva - implementado;
FazerTreino - implementado;
FazerFortalecimento - contrato;
FazerAlongamento - contrato;

Crie uma classe Natacao que implemente os métodos:
Fortalecimento -> Malhar membros superiores e inferiores;
Alongamento -> Alongar membros superiores e inferiores;
Crie uma classe CorridaObstaculos que implemente os métodos;
Fortalecimento -> Malhar membros inferiores;
Alongamento -> Alongar membros inferiores;
Crie uma classe teste

## Interface 2:
Considerando a classe abstrata AnimalBase e a classe Cachorro, realize a conversão da classe abstrata para uma interface chamada IAnimal. Essa nova interface deverá ser implementada pela classe Cachorro.

public abstract class AnimalBase
{   
    public abstract void comer(string comida);    	
    public abstract void dormir();
    public abstract string emitirSom();
}

public class Cachorro : AnimalBase
{
    public string nome { get; set; }    	
    public string raca { get; set; }    	

    public override void comer(string comida){}
    public override void dormir(){}
    public override string emitirSom() { return "AuAu"; }
}

## Interface 3:
Crie a interface IData que fornece os métodos: void  setData(DateTime  data), que ajusta a data do objeto; DateTime  getData(), que retorna a data do objeto; e string  dataString, que retorna a data do objeto como uma string. Crie uma classe Produto que possui nome, valor e data de validade.

Crie uma classe Venda que possui data e produto. Produto e Venda implementam a interface IData. Crie uma classe estática chamada TestarVenda e um método estático chamado DetalhesVenda que recebe uma Venda e retorna uma string com os dados da venda.

Exemplo:

Produto produto = new Produto();
produto.nome = "Leite Integral";
produto.valor = 5;
produto.setData(new DateTime(2023, 3, 1));
Venda venda = new Venda();
venda.produto = produto;
venda.setData(DateTime.Now);
TestarVenda.DetalhesVenda(venda); //"Data da venda: 29/10/2022 - Produto: Leite Integral - Valor do produto: 5 - Vencimento: 01/03/2023"
Dica: no método para converter a data para string utilize .ToString("dd/MM/yyyy")


## Interface 4:
Uma interface define um contrato. Qualquer classe que implemente esse contrato deve fornecer implementações dos membros definidos na interface.

Crie um programa em C# que contenha uma interface IVeiculo com dois métodos, um para Dirigir do tipo void e outro para Reabastecer do tipo bool que tenha um parâmetro do tipo int com a quantidade de gasolina a ser reabastecida.

Em seguida, crie uma classe Carro com um construtor que receba um parâmetro com a quantidade de gasolina inicial do carro e implemente os métodos Dirigir e Reabastecer do carro.

O método Dirigir retornará "Dirigindo", se a gasolina for maior que 0. O método Reabastecer aumentará a gasolina do carro e retornará true.
<<<<<<< HEAD


## Reflection 1:
Utilizando Reflections, além de termos a possibilidade de selecionar membros específicos de uma classe em tempo de execução, podemos retornar todos os membros públicos da mesma (propriedade, campos e metodos).

Considerando a classe a seguir, crie uma classe estática chamada Reflections e nessa classe crie um método estático com o nome de RetornaMembrosPublicos. Este método receberá um objeto (tipo object) e retornará uma lista de strings com os nomes dos membros públicos (propriedade, campos e metodos) pertencentes à esse objeto.

public class AlgumaClasse
{
    public int CampoX;
    private int CampoY;
    public int Propriedade1 { get; set; }
    private int Propriedade2 { get; set; }

    public string Metodo1()
    {
        return "Método1 chamado";
    }
    
    public string Metodo2()
    {
        return "Metodo2 chamado";
    }
}
Exemplo:

Reflections.RetornaMembrosPublicos(new AlgumaClasse())
Lembre-se:

Coloque o código da classe AlgumaClasse na sua solução.
Como toda classe herda da classe object, o retorno desse método conterá métodos que fazem parte dessa classe, são eles: GetType, ToString, GetHashCode e Equals

## Reflection 2:

Neste exercício você deve criar uma classe estática com o nome Reflection e um método estático com o nome ConcatStringMembers, que receberá um objeto e retornará uma string com os resultados de todos os membros de um objeto, que são/retornam strings.

Use apenas os próprios métodos do objeto e não os métodos derivados. Considere somente os métodos sem parâmetros. Cada método (o método! NÃO o retorno do método!) deve ser considerado apenas uma vez. Para objetos nulos, retorne uma string vazia.

Utilize a classe do exemplo abaixo como base para os testes:

public class testClass
{
    public string Output1()
    {
        return "Output";
    }

    public string Output2()
    {
        return "It";
    }
}
Reflection.ConcatStringMembers(null) => ""
Reflection.ConcatStringMembers(new testClass()) => "OutputIt"

## Reflection 3:

Reflections é algo interessante que o C# fornece, com ela podemos escrever código o qual lê as informações do metadado dos objeto em tempo de execução. Essas informações são toda a estrutura existente na classe, portanto métodos, propriedades e até mesmo atributos de classes e métodos são visualizadas.

Escreva uma classe estática chamada Utils e um método estático chamado isClass que receba um objeto e verifique se esse objeto é uma classe. Retorne um bool como resposta.

## Reflection 4:
Considerando a classe a seguir, crie uma classe estática chamada Reflections e nessa classe crie um método estático com o nome de RetornaPropriedadesPublicas. Este método receberá objeto (tipo object) e retornará uma lista de strings com os nomes das propriedades publicas pertencentes a esse objeto.

public class AlgumaClasse
{
    public int CampoX;
    private int CampoY;
    public int Propriedade1 { get; set; }
    private int Propriedade2 { get; set; }

    public string Metodo1()
    {
        return "Método1 chamado";
    }
    
    private string Metodo2()
    {
        return "Method2 chamado";
    }
}
Exemplo:

Reflections.RetornaPropriedadesPublicas(new AlgumaClasse()) = List<string> {  }
Lembre-se: Coloque o código da classe AlgumaClasse na sua solução.
=======
>>>>>>> 85e5d3a9a2a0cd2a24cc845c0920423bdabee248
