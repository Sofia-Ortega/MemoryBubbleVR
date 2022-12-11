using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// loop through images[] in canvas - slide show of images
public class ChangeImages : MonoBehaviour
{
    public Image currImage;
    public Sprite[] images;

    private float waitTime = 5; // 5 seconds between pictures
    private int index;
    private FunctionTimer functionTimer;


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
