﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level003SpeedManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = this.gameObject.transform.localPosition;
        pos.z += -0.30f;
        this.gameObject.transform.localPosition = pos;
    }
}
