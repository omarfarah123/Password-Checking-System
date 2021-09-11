/*Omar Farah 
C# Password Checking System*/

using System;

namespace PasswordChecker
{
  class Program
  {
    const int minLength = 8;
      const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      const string LowerCase = "abcdefghijklmnopqrstuvwxyz";
      const string Digits = "1234567890";
      const string specialChars = "!@#$%^&*?";
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter a password");
      string password = Console.ReadLine();
      int score = 0;
    
      if(password.Length >= minLength){
        score++;
      }
      if(Tools.Contains(password, UpperCase)){
        score++;
      }
      if(Tools.Contains(password, LowerCase)){
        score++;
      }
      if(Tools.Contains(password, Digits)){
        score++;
      }
      if(Tools.Contains(password, specialChars)){
        score++;
      }
      if(password == "password" || password == "1234"){ 
         score = 0;
      }

      Console.WriteLine(score);

      switch(score){
        case 1:
          Console.WriteLine("Weak Password");
          break;
        case 2:
          Console.WriteLine("The Password Is Medium");
          break;
        case 3:
          Console.WriteLine("The Password Is Strong");
          break;
        case 4:
          Console.WriteLine("Extremely Strong Password");
          break;
        case 5: 
            Console.WriteLine("Extremely Strong Password");
          break;
        default:
              Console.WriteLine("Password does not meet standards");
          break;
      }

    }
  }
}
