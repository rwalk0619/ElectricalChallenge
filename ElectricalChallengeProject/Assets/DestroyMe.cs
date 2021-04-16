using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DestroyMe : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.transform.Rotate(new Vector3(0,0,45));
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }
    }
}
