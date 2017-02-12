using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer3DModel : MonoBehaviour {

    public float width;
    public float height;
    public float depth;
    public float forwardPosition;
    public bool flipped;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Mixer3D GetMixerProperties()
    {
        return new Mixer3D(width, height, depth, forwardPosition, flipped);
    }
}
