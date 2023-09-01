using System;
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
      
List<int> vetor = new List<int>();

for(int i = 0; i <= 9; i++){

    int.TryParse(Console.ReadLine(), out int x);

    vetor.Add(x);
}

for(int j = 0; j <= vetor.ToArray().Length - 1; j++){
    
    if(vetor[j] <= 0){
        vetor[j] = 1;
    }
    
    Console.WriteLine("X" + "[" + j + "]" + " = " + vetor[j]);
}
    }

}
