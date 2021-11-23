const readline = require('readline');

const password = '2002';

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

const line = () => {
  return new Promise((resolve, reject) => {
    rl.question('Entre com a senha: ', (answer) => {
      resolve(answer);
    });
  });
};

const main = async () => {
  let runLoop = true;

  do {
    const inputPassword = await line();

    if (password === inputPassword) {
      console.log('Acesso Permitido');

      rl.close();

      runLoop = false;
    } else {
      console.log('Senha invalida');
    }
  } while (runLoop);
};

main();
