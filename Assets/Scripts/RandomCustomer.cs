using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCustomer : MonoBehaviour
{
    public static RandomCustomer instance;

    private void Awake()
    {
        instance = this;
    }

    public void ShowRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 12);
        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;

            child.gameObject.SetActive(shouldShow);
        }
    }

    private void OnEnable()
    {
        ShowRandomSprite();
    }
}
