using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer3DController : StudioElement {

    private Mixer3D mixerProperties;
    private Mixer3DModel model;
    private Mixer3DView view;

    // Use this for initialization
    void Awake () {
        model = GetComponent<Mixer3DModel>();
        view = GetComponent<Mixer3DView>();

        mixerProperties = model.GetMixerProperties();
        setMixerProperties(mixerProperties);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // Passes along the transform and if flipped for the view to render
    private void setMixerProperties(Mixer3D properties)
    {
        Transform mixerTransform = transform;

        mixerTransform.localScale = new Vector3(properties.Width, properties.Height, properties.Depth);
        mixerTransform.position = new Vector3(0, 0, properties.ForwardPosition);
        bool flipped = properties.Flipped;

        view.UpdateMixer3DProperties(mixerTransform, flipped);
    }
}
