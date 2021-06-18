using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductOrange : MonoBehaviour
{
    public GameObject orange;
    public static ProductOrange instance;

    private void Awake()
    {
        instance = this;
    }

    public void CreateOrange()
    {
        Instantiate(orange, transform.position, transform.rotation);
    }
}
