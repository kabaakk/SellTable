using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductLemon : MonoBehaviour
{
    public GameObject lemon;
    public static ProductLemon instance;

    private void Awake()
    {
        instance = this;
    }

    public void CreateLemon()
    {
        Instantiate(lemon, transform.position, transform.rotation);
    }
}
