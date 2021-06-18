using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Again : MonoBehaviour
{
    public GameObject again, selection;

    public void AgainYes()
    {
        again.SetActive(false);
        selection.SetActive(true);
    }

    public void AgainNo()
    {
        Debug.Log("User leaved from game");
    }
}
