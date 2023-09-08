using retangulo_sem_liskov;

Retangulo retangulo = new Retangulo();
retangulo.Largura = 4;
retangulo.Altura = 5;
Console.WriteLine("Área do Retângulo: " + retangulo.Area());

Retangulo quadrado = new Quadrado();
quadrado.Largura = 4;
quadrado.Altura = 5;
Console.WriteLine("Área do Quadrado : " + quadrado.Area()); 

Console.ReadLine(); 