﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    

    
    void LateUpdate()
    {
        transform.position = target.position;
        transform.rotation = target.rotation;

        //transform.rotation = Vector3.Lerp(transform.rotation, target.rotation, 1f);
    }
}
