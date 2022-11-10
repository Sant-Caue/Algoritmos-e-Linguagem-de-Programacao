using System;

namespace Ex6 {
    
    class Ex6 {
        
        static void Main() {
            
            int i=1, j=0, cont=1;
            double k;
            double[] seq = new double[10];
             
            foreach(double num in seq){
                 Console.WriteLine($"Digite o {j+1}º número");
                 seq[j] = double.Parse(Console.ReadLine());
                 j++;
             }
             
            for (i=0; i < 10; i++) {
                for (j=0; j < 10; j++) {
                    
                    if (seq[i] < seq[j]) {
                        k = seq[j];
                        seq[j] = seq[i];
                        seq[i] = k;
                    }
                }
            }
            
            
            for (i=0; i < 10; i++) { 
                cont=1;
                
                for (j=0; j < 10; j++) {

                    if (i!=j && seq[i] == seq[j]) {
                        cont++;
                    } 
                        else if (i!=j && seq[i] != seq[j]) {
                            //Evitar break
                        } 
                            else break;
                }
                
                if (cont > 1 && ((i+1)<10 && seq[i] != seq[i+1] || i ==9)) {
                    Console.WriteLine($"O número {seq[j]} se repetiu {cont+1} vezes");
                    
                }   
                    else if (cont == 1 && ((i+1<10 && seq[i] != seq[i+1]) || i==9)) {
                        Console.WriteLine($"O número {seq[j]} não se repetiu");    
                    }
                    
            }
           
            Console.ReadKey();
        }
    }
}
