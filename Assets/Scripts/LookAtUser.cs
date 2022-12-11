using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ensures GameObject `user` is facing the user at all times
public class LookAtUser : MonoBehaviour
{
    public GameObject user;

    void Update()
    {
        transform.LookAt(user.transform);
    }
}
