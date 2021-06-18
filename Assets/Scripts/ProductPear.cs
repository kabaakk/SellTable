using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductPear : MonoBehaviour
{
    public GameObject pear;
    public static ProductPear instance;

    private void Awake()
    {
        instance = this;
    }

    public void CreatePear()
    {
        Instantiate(pear, transform.position, transform.rotation);
    }
}
