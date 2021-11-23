/* Fazer um programa paraler o código de uma peça 1, o número de peças 1,
o valor unitário de cada peça 1, o código de uma peça 2,
o número de peças 2 e o valor unitário de cada peça 2.
Calcule e mostre o valor a ser pago. */

var readline = require('readline');
let piecesData = [];

const formatInput = (inputData, splitParam) => {
  const inputsList = inputData.split(splitParam).map((data) => Number(data));
  return inputsList;
};

const consoleRead = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

const line = (message) => {
  return new Promise((resolve, _rejects) => {
    consoleRead.question(message, (answer) => {
      piecesData = [...piecesData, formatInput(answer, ' ')];
      resolve();
    });
  });
};

const calcTotalPrice = (piecesInputData) => {

  const total = piecesInputData
    .reduce((acc, [_cod, quantity, value]) => (acc + (quantity * value)), 0);

  return total;
};

const main = async () => {
  await line('Insira os dados da primeira peça: ');
  await line('Insira os dados da segunda peça: ');

  const total = calcTotalPrice(piecesData);

  console.log(`VALOR A PAGAR: R$ ${total}`);
  consoleRead.close();
};

main();
