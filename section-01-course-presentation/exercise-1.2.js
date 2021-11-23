/* Faça um programa para ler o valor do raio de um círculo,
 e depois mostrar o valor da área deste círculo com quatro casas decimais
 conforme exemplos. */

const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

const circleAreaCalc = (radius) => Math.PI * (Math.pow(radius, 2.0));

rl.question('Entre com o raio: ', (answer) => {
  const area = circleAreaCalc(Number(answer));

  console.log(`A área do círculo é: A=${area.toFixed(4)}`);

  rl.close();
});