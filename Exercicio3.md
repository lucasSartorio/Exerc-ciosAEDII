Na matemática tradicional, 1 / 2 = 0.5. Mas na programação, como o número 1 e o número 2 foram digitados sem casas decimais, o compilador assume que eles são do tipo inteiro (int).
Quando você divide um inteiro por outro inteiro, o Java faz uma divisão inteira e simplesmente descarta o resto.A conta 1 / 2 resulta em 0.
A fórmula inteira se transforma em Math.pow(SomaDosQuadrados, 0).
Pelas regras da matemática, qualquer número elevado a zero (x^0) é igual a 1. É por isso que o programa sempre imprime 1.0.