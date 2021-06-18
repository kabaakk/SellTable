using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour
{
    public GameObject title, selection;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Ui");
    }

    IEnumerator Ui()
    {
        title.SetActive(true);
        selection.SetActive(false);
        yield return new WaitForSeconds(2);
        title.SetActive(false);
        selection.SetActive(true);
    }
}
