using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// loop through images[] in canvas - slide show of images
public class ChangeImages : MonoBehaviour
{
    public Image currImage; // object of the Image object which contains images
    public Sprite[] images; // array of sprites of images that want to rotate through

    private float waitTime = 5; // amount of seconds viewing picture before rotation

    private int index; // tracks index of images
    private FunctionTimer functionTimer; // timer to track time between images


    private float a;

    void Start()
    {
        functionTimer = new FunctionTimer(ImageChange, waitTime);
    }

    void Update()
    {
        functionTimer.Update();
    }

    public void ImageChange() {
        if (index + 1 >= images.Length) index = 0;
        else index++;

        currImage.sprite = images[index];

    }
}
