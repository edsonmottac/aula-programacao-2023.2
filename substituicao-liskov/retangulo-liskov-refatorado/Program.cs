using retangulo_liskov_refatorado;

// Cria um objeto do tipo Retangulo
IForma retangulo = new Retangulo();
((Retangulo)retangulo).Largura = 5;
((Retangulo)retangulo).Altura = 4;

// Calcula a área do retângulo
Console.WriteLine("Área do retângulo: " + retangulo.Area());

// Cria um objeto do tipo Quadrado
IForma quadrado = new Quadrado();
((Quadrado)quadrado).Lado = 5;

// Calcula a área do quadrado
Console.WriteLine("Área do quadrado: " + quadrado.Area());

Console.ReadLine(); 