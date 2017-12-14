using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour {

    // Use this for initialization
    void Start() {
        int[] array = new int[5];

        array [0] = 10;
        array [1] = 20;
        array [2] = 30;
        array [3] = 40;
        array [4] = 50;

        for (int R = 0; R < 5; R++) {
            Debug.Log(array[R]);
        }
    }

	
	// Update is called once per frame
	void Update() {
		
	}
}