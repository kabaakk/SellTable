using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovement : MonoBehaviour
{
    public float speed = -10f;

    private Transform target;
    private int wavepointIndex = 0;

    public GameObject character;
    CustomerMovement movement;

    BoxCollider collider;

    public static CustomerMovement instance;

    // Start is called before the first frame update
    void Start()
    {
        target = Waypoints.points[0];
        movement = GetComponent<CustomerMovement>();
        collider = GetComponent<BoxCollider>();
        collider.isTrigger = true;
    }

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

        if (wavepointIndex == 4)
        {
            speed = 0;
            character.transform.eulerAngles = new Vector3(-4.7f, -92.148f, 0.9030001f);
            movement.enabled = false;
            Products.instance.products.SetActive(true);
            ProductList();
            collider.isTrigger = false;
        }
    }

    private void ProductList()
    {
        Products.instance.ShowRandomSprite();
    }

    void GetNextWaypoint()
    {
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
}
