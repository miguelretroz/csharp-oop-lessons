const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});


const line = (message) => {
  return new Promise((resolve, _reject) => {
    rl.question(message, (answer) => resolve(answer));
  });
};

const main = async () => {
  const result = {
    in: 0,
    out: 0,
  };

  const n = Number(await line('Entre com a quantidade de números (N): '));

  for (let i = 1; i <= n; i += 1) {
    const number = Number(await line(`Entre com o ${i}° número: `));

    if (number >= 10 && number <= 20) result.in += 1;
    else result.out += 1;
  }

  console.log(result.in, ' in');
  console.log(result.out, ' out');

  rl.close();
};

main();