using System;

namespace api.Services
{
  public class Fizzbuzz{
    public string say(int input){
      if(isFizzBuzz(input)){
        return "FizzBuzz";
      }
      if (isFizz(input) ){
        return "Fizz";
      }
      if (isBuzz(input)){
        return "Buzz";
      }
        return input+"";
    }

    public static bool isFizz(int input){
       return input% 3 == 0 ;
    }
    public static bool isBuzz(int input){
       return input% 5 == 0 ;
    }

     public static bool isFizzBuzz(int input){
       return input % 15 == 0;
    }
  }

}