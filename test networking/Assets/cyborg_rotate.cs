﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyborg_rotate : MonoBehaviour {

    public Transform vcam_rotations;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(vcam_rotations.rotation.x, vcam_rotations.rotation.y));
	}
}
