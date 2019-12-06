using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
   public int currentCake;
   public Text cakeText;

   public void AddCake(int cakeToAdd)
   {
       currentCake += cakeToAdd;
       cakeText.text = "Cake score = " + currentCake;
   }
}

