const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

const messageImpossible = () => {
  console.log('Impossível calcular');

  rl.close();
};

rl.question('Entre com os coeficientes "a", "b", "c" -> ', (answer) => {
  const inputData = answer.split(' ');

  const inputNumber = inputData.map((input) => Number(input));

  const [a, b, c] = inputNumber;

  if (a === 0) return messageImpossible();

  const delta = Math.pow(b, 2.0) - (4 * a * c);

  if (delta < 0) return messageImpossible();

  const x1 = (- b + Math.sqrt(delta, 2.0)) / (2 * a);

  const x2 = (- b -  Math.sqrt(delta, 2.0)) / (2 * a);

  console.log('X1 = ', x1.toFixed(5));
  console.log('X2 = ', x2.toFixed(5));

  rl.close();
});
