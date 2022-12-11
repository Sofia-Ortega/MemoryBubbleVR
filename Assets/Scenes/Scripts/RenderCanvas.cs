using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Renders image slide show arter *timer* amount of time
public class RenderCanvas : MonoBehaviour
{
    public Image panel;
    public Image image;
    

    private float timer = 10f; // Amount of time before pictures appear
    private bool activated = false;

    void Start()
    {
        panel.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
    }


    // when timer finishes, enable view to image slide shows
    void Update()
    {
        timer -= Time.deltaTime; 
        if (timer < 0 && !activated) { 
            panel.gameObject.SetActive(true);
            image.gameObject.SetActive(true);
            activated = true;
        }
        
    }
}
