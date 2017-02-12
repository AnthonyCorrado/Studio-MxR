using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer3DView : StudioElement {

    private Mixer3D mixerProperties;

	// Use this for initialization
	void Start () {
        mixerProperties = app.mixer3DModel.GetMixerProperties();
        setMixerProperties(mixerProperties);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void setMixerProperties(Mixer3D properties)
    {
        transform.localScale = new Vector3(properties.Width, properties.Height, properties.Depth);
        transform.position = new Vector3(0, 0, properties.ForwardPosition);

        if (properties.Flipped)
        {
            transform.Rotate(Vector3.right, 90);
        }
    }
}
