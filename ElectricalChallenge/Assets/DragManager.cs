using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using FreeDraw;
public class DragManager : MonoBehaviour
{
    [SerializeField] ComponentSpawner componentSpawner;

    private void Start()
    {
        GameObject.Find("Background").GetComponent<Drawable>().enabled = false;
    }
    public void DisableDrawing() 
    {
        GameObject.Find("Background").GetComponent<Drawable>().enabled = false;
    }
}
