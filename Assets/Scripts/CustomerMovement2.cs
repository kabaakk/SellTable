using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomerMovement2 : MonoBehaviour
{
    public float speed = -10f;

    private Transform target;
    private int wavepointIndex = 0;

    public GameObject character;
    BoxCollider collider;

    public static CustomerMovement2 instance;

    // Start is called before the first frame update
    void Start()
    {
        target = Waypoints.points[0];
        collider = GetComponent<BoxCollider>();
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

        if (wavepointIndex == 1)
        {
            if (Products.instance.customerCount == 4)
            {
                gameObject.SetActive(false);
            }
            RandomCustomer.instance.ShowRandomSprite();
        }

        if (wavepointIndex == 0)
        {
            character.transform.eulerAngles = new Vector3(-0.703f, 0.307f, -4.734f);
            collider.isTrigger = true;
        }
    }

    void GetNextWaypoint()
    {
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
}
