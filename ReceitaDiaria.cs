/*
Ex 07

- 300 clientes
- Pagamento com cheque, cartão de crédito e dinheiro
- Somar total de cada tipo de pagamento e total geral
- Exibir resultados

*/

using System;

namespace Ex07 {
    
    class Ex07 {
        
        static void Main(string[] args) {
            
            double[] receita = new double[3] {0, 0, 0}, qtde = new double[3] {0, 0, 0};
            double receita_unitaria;
            int i;
            bool valid=false;
            string resp;
           
            for (i=0; i<300; i++) { // MUDAR PARA I<300
                do {
                
                    Console.WriteLine("===============================================================");
                    Console.WriteLine($"Informe o código de identificação de pagamento do {i+1}º cliente:\n1- Cheque\n2- Cartão de Crédito\n3- Cédulas");
                    Console.WriteLine("===============================================================");
                    resp = Console.ReadLine();
                    
                    switch(resp) {
                        
                        case "1":
                            Console.WriteLine("Informe o valor gasto.");
                            receita_unitaria = double.Parse(Console.ReadLine());
                            
                            qtde[0] += 1;
                            receita[0] += receita_unitaria;
                            
                            valid=true;
                            break;
                        
                        case "2":
                            Console.WriteLine("Informe o valor gasto.");
                            receita_unitaria = double.Parse(Console.ReadLine());
                            
                            qtde[1] += 1;
                            receita[1] += receita_unitaria;
                            
                            valid=true;
                            break;
                            
                        case "3":
                            Console.WriteLine("Informe o valor gasto.");
                            receita_unitaria = double.Parse(Console.ReadLine());
                            
                            qtde[2] += 1;
                            receita[2] += receita_unitaria;
                            
                            valid=true;
                            break;
                            
                        default:
                            Console.Clear();
                            Console.WriteLine("Insira uma resposta válida");
                            valid=false;
                            break;
                        
                    } 
    
    
                }while (valid==false);
                Console.Clear();                
            }
            Console.WriteLine($"{qtde[0]} pagamentos com cheque com um total de R$ {receita[0]}");
            Console.WriteLine($"{qtde[1]} pagamentos com cartão de crédito com um total de R$ {receita[1]}");
            Console.WriteLine($"{qtde[2]} pagamentos à vista com um total de R$ {receita[2]}");
        }
    }
}


