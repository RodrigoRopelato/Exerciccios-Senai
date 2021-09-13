# Exerciccios-Senai
Programação de Aplicativos
Lista de Exercícios 1

1- Crie um programa que realize a conversão de temperatura em graus
Fahrenheit para Celsius.
Para realizar a conversão, realize o seguinte cálculo na ação do botão:

C = ((F - 32)* 5/9)

Onde:
C = Celsius (Saída)
F = Fahrenheit (Entrada)
Exemplos para teste:
Entrada
(Fahrenheit)

Saída
(Celsius)
158 70
-352 -213,33
75 23,88

2- Crie um programa para calcular o volume de uma caixa retangular. Para
isso, seu formulário deve receber como entrada os seguintes dados:
- comprimento
- largura
- altura

Para calcular o volume dessa caixa, utilize a seguinte fórmula:
volume = comprimento * largura * altura

O resultado deverá ser exibido em uma mensagem para o usuário
(MessageBox)

Lembre-se de validar todas as entradas. Nenhuma delas poderá ser
menor do que 0 (Zero). Caso isso ocorra, gere uma mensagem de aviso
para que o usuário verifique a sua digitação.

3- Crie um programa para calcular a média de consumo de combustível de
um carro. Seu programa deverá ter as seguintes entradas:
- Quilometragem Inicial do Percurso
- Quilometragem Final do Percurso
- Consumo de Combustível durante o Percurso realizado
pelo veículo Final do Percurso
Realize as validações:
- Entradas menores do que zero;
- Quilometragem Final não pode ser menor do que a Quilometragem
Inicial;
- Demais validações que julgar necessárias.

Na ação do clique de botão, você deve, inicialmente, obter a diferença de
Quilometragem.

DiferencaKm = (KmFinal - KmInicial)

Após obter a diferença, realize o cálculo do consumo médio efetuado
pelo carro.

GastoCombustivel = (DiferencaKm / ConsumoCombistivel)

4- Crie um programa para manipular elementos de texto (strings).
Entrada: um textBox
Botões e ações:
 TAMANHO: deve retornar uma mensagem para o usuário, com o número
de elementos (caracteres) do texto informado.
 PALAVRAS: deve retornar uma mensagem para o usuário com a
quantidade de palavras inseridas.

 INVERTER: deve retornar uma mensagem para o usuário, com o texto
inserido, de forma invertida.

5- Crie um programa para calcular a média de notas de um aluno. Para isso,
crie um formulário com 4 entradas de notas (Nota 1, Nota 2, Nota 3, Nota
4).
Realize a validação dos dados inseridos (não pode ser vazio, não pode ser
menor do que zero, não pode ser maior do que dez, etc..)
Embora seu programa aceite 4 notas como inserção, você pode efetuar o
cálculo da média com apenas 2 ou 3 notas, não sendo necessário inserir
todas as 4 notas.
Valide todos os cenários, e retorne a média das notas apresentadas via
mensagem (MessageBox) para o usuário.