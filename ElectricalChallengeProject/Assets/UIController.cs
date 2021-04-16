using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject button;
    private bool _isActive = false;
    public void MenuButton() 
    {
        Debug.Log("I clicked menu button");
        _isActive = !_isActive;
        panel.SetActive(_isActive);
        if (!_isActive)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
        }
        else button.GetComponent<SpriteRenderer>().color = new Color32(230, 230, 230, 255);
    }

    public void ResetScene() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CaptureScreenShot() 
    {
        //Put code for WebGl screenshots.
        //For web programmer he needs to do that for WebGL
    }
}
