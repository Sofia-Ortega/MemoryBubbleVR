using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class of timer
public class FunctionTimer : MonoBehaviour
{
    private Action action; // action to be executed in 'timer' seconds
    private float timer; // amount of time in between each 'action' execution
    private float timeSum; 
    public FunctionTimer(Action action, float timer) {

        this.action = action;
        this.timer = timer; // 3.00
        this.timeSum = 0f;

    }


    // executes 'action' each 'timer' seconds
    public void Update() { 
        timeSum += Time.deltaTime;

        if (timeSum > timer) {
            // trigger the actiona
            timeSum = 0;
            action();
        }
    }
}
