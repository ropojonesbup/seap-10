import * as readline from 'readline';

// Create an interface to read input from the command line
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// Function to ask a question and receive input
function askQuestion(query: string): Promise<string> {
  return new Promise((resolve) => rl.question(query, resolve));
}

// Main function to execute input and output logic
async function main() {
  const name = await askQuestion('What is your name? ');
  console.log(`Hello, ${name}!`);
  
  // Close the readline interface
  rl.close();
}

// Execute the main function
main();
