﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keluar : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Escape)) {
            Application.Quit();//Script ini berfungsi ketika keyboard menekan escape atau device mobile menekan tombol back maka Ap

        }
	}
}
