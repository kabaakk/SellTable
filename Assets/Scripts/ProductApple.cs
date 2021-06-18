using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductApple : MonoBehaviour
{
    public GameObject apple;
    public static ProductApple instance;

    private void Awake()
    {
        instance = this;
    }

    public void CreateApple()
    {
        Instantiate(apple, transform.position, transform.rotation);
    }
}
