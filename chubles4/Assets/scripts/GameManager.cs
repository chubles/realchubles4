using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
   public int currentCake;
   public Text cakeText;
   public int cakeLeft;
   public Text cakeToProgress;
   public int EnemiesLeft;
   public Text EnemiesToProgress;
   public void AddCake(int cakeToAdd)
   {
       currentCake += cakeToAdd;
       cakeText.text = "Cake score = " + currentCake;
       cakeLeft -= 1;
       cakeToProgress.text = "Cake till next level = " + cakeLeft;
   }

   public void EnemieStuff(int enimesLooft)
   {
       EnemiesLeft -= 1;
       EnemiesToProgress.text = "Enemies till next level = " + EnemiesLeft;
   }

   /*public void MinCake(int cakeToMin)
   {
       cakeLeft -= 1;
       cakeToProgress.text = "Cake till next level = " + cakeLeft;
   }
   */
}

