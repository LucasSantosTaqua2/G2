using System;

namespace G2
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            int pontuacao = 0;
            int idade;
            resposta = "";

            Console.WriteLine("");//Espaço
            
            Console.WriteLine("-------------");
            Console.WriteLine("|QUIZ DETRAN|");
            Console.WriteLine("-------------");

            Console.WriteLine("");//Espaço

            Console.Write("Informe sua idade: ");
            idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");//Espaço

            switch(idade)
            {
                case >17:

                    //Pergunta 1--------------------------------------------------------------------------
                    Console.WriteLine("1)Qual dessas alternativas é uma competência do DETRAN ? ");
                    Console.WriteLine("A) Organizar estatísticas de trânsito em todo o país.");//Incorreta
                    Console.WriteLine("B) Coordenar os órgãos do Sistema Nacional de Trânsito.");//Correta--
                    Console.WriteLine("C) Vistoriar, registrar, licenciar e emplacar veículos.");//Incorreta
                    Console.WriteLine("D) Aprovar a sinalização de trânsito.");//Incorreta
                    resposta = Console.ReadLine();

                    switch(resposta)
                    {
                        case "a":
                            pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;

                        case "b":
                            pontuacao = pontuacao + 2;
                            Console.WriteLine("Alternativa Correta !");//Correta
                        break;  

                        case "c":
                            pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;  

                        case "d":
                        pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;

                        default:
                            Console.WriteLine("Alternativa Inválida !");
                        break;         
                    }

                    Console.WriteLine("");//Espaço----------

                    //Pergunta 2--------------------------------------------------------------------------
                    Console.WriteLine("2)Após um acidente com motocicleta, a vítima está inconsciente e caída no chão com os joelhos dobrados. Nesta situação, um cuidado a ser prestado à vítima é: ");
                    Console.WriteLine("A) Transportar a vítima para o hospital o mais rápido possível, na posição sentada.");//Incorreta
                    Console.WriteLine("B) Verificar presença de fratura no joelho e tentar colocar a articulação no lugar.");//Incorreta
                    Console.WriteLine("C) Não tirar o capacete do motociclista."); //Correta--
                    Console.WriteLine("D) Movimentar a cabeça para cima e para baixo, e de um lado para outro.");//Incorreta
                    resposta = Console.ReadLine();
                    
                    switch(resposta)
                    {
                        case "a":
                            pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;

                        case "b":
                            pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;  

                        case "c":
                            pontuacao = pontuacao + 2;
                            Console.WriteLine("Alternativa Correta !");//Correta
                        break;  

                        case "d":
                        pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;

                        default:
                            Console.WriteLine("Alternativa Inválida !");
                        break;         
                    }

                    Console.WriteLine("");//Espaço----------

                //Pergunta 3--------------------------------------------------------------------------
                    Console.WriteLine("3)É uma medida administrativa prevista no Código de Trânsito Brasileiro: ");
                    Console.WriteLine("A) Frequência obrigatória em curso de reciclagem.");//Incorreta
                    Console.WriteLine("B) Recolhimento da Carteira Nacional de Habilitação.");//Correta--
                    Console.WriteLine("C) Apreensão de animais que se encontrem soltos na via.");//Incorreta
                    Console.WriteLine("D) Advertência verbal.");//Incorreta
                    resposta = Console.ReadLine();
                    
                    switch(resposta)
                    {
                        case "a":
                            pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;

                        case "b":
                            pontuacao = pontuacao + 2;
                            Console.WriteLine("Alternativa Correta !");//Correta
                        break;  

                        case "c":
                            pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;  

                        case "d":
                        pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;

                        default:
                            Console.WriteLine("Alternativa Inválida !");
                        break;         
                    }

                    Console.WriteLine("");//Espaço----------

                //Pergunta 4--------------------------------------------------------------------------
                    Console.WriteLine("4)Uma das regras fundamentais para fazer a sinalização do acidente é: ");
                    Console.WriteLine("A) Sinalizar o local até a uma distância a 3 metros do acidente.");
                    Console.WriteLine("B) Iniciar a sinalização após o acidente ser visível.");
                    Console.WriteLine("C) Não sinalizar com materiais encontrados nas imediações tais com galhos de árvores e latas.");
                    Console.WriteLine("D) Não permitir que curiosos parem na via destinada ao tráfego.");//Correta
                    resposta = Console.ReadLine();
                    
                    switch(resposta)
                    {
                        case "a":
                            pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;

                        case "b":
                            pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;  

                        case "c":
                            pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;  

                        case "d":
                        pontuacao = pontuacao + 2;
                            Console.WriteLine("Alternativa Correta !");//Correta
                        break;

                        default:
                            Console.WriteLine("Alternativa Inválida !");
                        break;         
                    }

                    Console.WriteLine("");//Espaço----------

                    //Pergunta 5--------------------------------------------------------------------------
                    Console.Write("5)Em caso de acidente de trânsito com vítima, para acionar o Corpo de Bombeiros, deve-se ligar para: ");
                    Console.WriteLine("A) 199.");
                    Console.WriteLine("B) 191.");
                    Console.WriteLine("C) 193.");//Correta
                    Console.WriteLine("D) 190.");
                    resposta = Console.ReadLine();
                    
                    switch(resposta)
                    {
                        case "a":
                            pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;

                        case "b":
                            pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;  

                        case "c":
                            pontuacao = pontuacao + 2;
                            Console.WriteLine("Alternativa Correta !");//Correta
                        break;  

                        case "d":
                        pontuacao = pontuacao - 2;
                            Console.WriteLine("Alternativa Incorreta !");
                        break;

                        default:
                            Console.WriteLine("Alternativa Inválida !");
                        break;         
                    }

                    Console.WriteLine("");//Espaço----------





                    Console.WriteLine("");//Espaço----------

                    switch(pontuacao)
                    {
                        case >7:
                            Console.WriteLine("Obrigado por responder o QUIZ. Agora você está apto para dirigir!");
                        break;
                        
                        default:
                            Console.WriteLine("Obrigado por responder o QUIZ. Infelizmente você não está apto para dirigir.");
                        break;
                    }
                break;

                default:
                    Console.WriteLine("Você não tem a idade necessária para dirigir.");
                break;
            }
        }
    }
}
