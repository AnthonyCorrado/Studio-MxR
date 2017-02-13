using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer3DView : StudioElement {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateMixer3DProperties(Transform mixerTransform, bool flipped)
    {
        transform.localScale = mixerTransform.localScale;
        transform.position = mixerTransform.position;

        if (flipped)
        {
            transform.Rotate(Vector3.right, 90);
        }
    }
}
