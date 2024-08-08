[Day 7]
Olá pessoal, como vocês estão? 😊

Hoje, estudando, entendi como consigo aplicar herança com classe abstrata e fiz um exercício para fixar essa matéria. Me perdoem a demora, pois na sexta aconteceu um problema na internet de casa 🌐.

Bom, o exercício consistia em criar uma classe abstrata Veiculo e colocar atributos, construtores e métodos. Criei os atributos Marca, Cor e Ano. Após isso, criei um construtor e o método ExibirInformações, que contém uma regra de negócio, e os outros métodos foram abstratos, ou seja, eles não têm implementação na classe 🚗.

Mas afinal, por que criar uma classe abstrata e não uma classe pública? A classe abstrata é muito útil na herança, pois é usada especificamente como um molde para outra classe herdar. Tanto que, se tentar instanciar uma classe abstrata, vai acontecer um erro 🚫. Já para os métodos é diferente: quando há um método abstrato, significa que esse método vai ser implementado na classe herdada, que no nosso caso é Carro 🚘.

Após isso, criei a classe Carro, coloquei o construtor e passei os argumentos da classe Carro para o .base(). Isso significa que todos os argumentos da classe Carro vão para o construtor da classe Veiculo. Depois de ter feito essas criações, parti para a implementação dos métodos abstratos. Em C#, quando vamos sobrescrever métodos abstratos ou virtuais (isso é algo que vamos tratar em polimorfismo, próximo pilar), usamos a palavra override para sobrescrever os métodos e escrever a sua regra de negócio 🔄.

Após ter feito essas coisas, parti para o método Main, onde criei os atributos, instanciei a classe Carro, passei para o seu construtor os atributos e depois chamei os métodos 🔧.
