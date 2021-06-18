using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductCherry : MonoBehaviour
{
    public GameObject cherry;
    public static ProductCherry instance;

    private void Awake()
    {
        instance = this;
    }

    public void CreateCherry()
    {
        Instantiate(cherry, transform.position, transform.rotation);
    }
}
