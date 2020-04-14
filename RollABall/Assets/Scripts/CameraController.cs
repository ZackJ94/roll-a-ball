﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
 
    Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // "use late update to ensure the player has moved before we set camera position"
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
