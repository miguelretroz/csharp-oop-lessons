const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

const products = [
  {
    cod: 1,
    price: 4.00,
  },
  {
    cod: 2,
    price: 4.50,
  },
  {
    cod: 3,
    price: 5.00,
  },
  {
    cod: 4,
    price: 2.00,
  },
  {
    cod: 5,
    price: 1.50,
  },
];

rl.question('Entre com o código e a quantidade: ', (answer) => {
  const inputData = answer.split(' ');

  const prodCod = inputData[0];
  const prodAmount = inputData[1];

  const product = products.find(({ cod }) => cod == prodCod);

  const total = product.price * prodAmount;

  console.log(`Total: R$ ${total.toFixed(2)}`);

  rl.close();
});