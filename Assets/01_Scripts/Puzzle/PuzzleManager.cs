   using UnityEngine;

   public class PuzzleManager : MonoBehaviour
   {
       [SerializeField] private string solution = "1234";
       [SerializeField] private ChestController chest;
       private int attempts;

       public void CheckCode(string input)
       {
           attempts++;

           if (input == solution)
           {
               Debug.Log("Puzzle resuelto en " + attempts + " intentos.");
               chest.Unlock();
           }
           else
           {
               Debug.Log("Código incorrecto. Intentos: " + attempts);
           }
       }
   }