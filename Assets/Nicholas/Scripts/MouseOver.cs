using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour
{
    private bool cououtineAllowed;
    public GameObject test;

    private void Start()
    {
        cououtineAllowed = true;
        test.SetActive(false);
    }

    private void OnMouseOver()
    {
        Debug.Log("moused over " + gameObject.name);
        if (cououtineAllowed)
        {
            test.SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        if (cououtineAllowed)
        {
            test.SetActive(false);
        }
    }
}
