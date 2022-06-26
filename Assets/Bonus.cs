using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



public class Bonus : MonoBehaviour
{
   public string bonusName;
   public Text coinCount;

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.name == "Player")
      {
         switch (bonusName)
         {
            case "coin":
               int coins = PlayerPrefs.GetInt("coins");
               coins = 10;
               PlayerPrefs.SetInt("coins", coins +  1);
               Destroy(gameObject);
               coinCount.text = (coins + 1).ToString();
               break;
               
         }
      }
   }
}
