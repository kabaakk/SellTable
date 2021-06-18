using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Products : MonoBehaviour
{
   public static Products instance;
   public GameObject products, goldEffect;
   public bool appleActive,cherryActive,lemonActive,orangeActive,pearActive;
   public int customerCount = 0;
   public int goldCoin = 0;
   public Text coinText, goldCount, customerCountText, goldCountNext, customerCountNext;

    private void Awake()
    {
        instance = this;
    }

    public void ShowRandomSprite()
   {
        int index = UnityEngine.Random.Range(1, 5);
        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;

            child.gameObject.SetActive(shouldShow);

            if (index == 0)
            {
                appleActive = true;
            }

            if (index == 1)
            {
                cherryActive = true;
            }

            if (index == 2)
            {
                lemonActive = true;
            }

            if (index == 3)
            {
                orangeActive = true;
            }

            if (index == 4)
            {
                pearActive = true;
            }
        }
   }
}
