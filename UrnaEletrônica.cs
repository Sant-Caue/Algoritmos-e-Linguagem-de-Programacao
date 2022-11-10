/*
- Urna eletrônica
- Computar votos do candidato A e B 
- Computar votos nulos
- Computar votos em branco
- Total geral de votos
- Mostrar candidato vencedor

- Codificação:
1- Candidato A 
2- Candidato B 
3- Voto em branco
4- Voto nulo

*/

using System;

namespace Ex08 {
    
    class Ex08 {
        
        static void Main (string[] args) {
            
            string resp, valid="";
            int A=0, B=0, branco=0, nulo=0, total=0;
            double percentual, percentual_valido;
            
            do {
                
                Console.WriteLine("=========================================================");
                Console.WriteLine("           Informe o código de votação\n1- Candidato A\n2- Candidato B\n3- Voto em branco\n4- Anular voto");
                Console.WriteLine("=========================================================");
                
                resp = Console.ReadLine();
                valid = "1";
                total++;
                
                switch (resp) {
                
                case "1":
                    A++;
                    Console.WriteLine("Voto computado para o candidato A");
                    break;
                    
                case "2":  
                    B++;
                    Console.WriteLine("Voto computado para o candidato B");
                    break;
                    
                case "3":
                    branco++;
                    Console.WriteLine("Voto em branco");
                    break;
                    
                case "4":
                    nulo++;
                    break;
                    
                default:
                    Console.Clear();
                    total--;
                    Console.WriteLine("Informe um código válido");
                    valid = "E";
                    break;
                }
                
                if (valid != "E") {
                    do {
                        Console.WriteLine("Deseja computar outro voto?\n1- Sim\n2- Não");
                        
                        valid = Console.ReadLine();
                        Console.Clear();
                        
                        if (valid == "1" || valid == "2") {
                            break;
                        } else 
                            Console.WriteLine("Informe um código válido.");
                            
                    } while (valid != "1" || valid != "2");
                }    
            } while (valid == "1" || valid == "E");
            
            Console.WriteLine($"Foram computados {A} votos para o candidato A");
            Console.WriteLine($"Foram computados {B} votos para o candidato B");
            Console.WriteLine($"Foram computados {branco} votos brancos");
            Console.WriteLine($"Foram computados {nulo} votos nulos");
            Console.WriteLine($"Foram computados {total} votos totais");
            
            if (A > B) {
                percentual = (A/(double)total)*100;
                percentual_valido = (A/(double)(A+B))*100;
                
                Console.WriteLine($"O candidato A venceu a eleição com {percentual.ToString("F2")} dos votos totais e {percentual_valido.ToString("F2")} dos votos validos.");
            
                
            } else if (B > A) {
                percentual = (B/(double)total)*100;
                percentual_valido = (B/(double)(A+B))*100;
                
                Console.WriteLine($"O candidato B venceu a eleição com {percentual.ToString("F2")} dos votos totais e {percentual_valido.ToString("F2")} dos votos validos.");
            } else
                Console.WriteLine("Houve empate.");
            

        }
    }
}


