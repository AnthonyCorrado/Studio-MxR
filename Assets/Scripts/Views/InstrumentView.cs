using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentView : StudioElement {

    private Instrument instrumentProperties;

	// Use this for initialization
	void Start () {
        instrumentProperties = app.instrumentModel.GetInstrumentProperties();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void setInstrumentProperties(Instrument properties)
    {
        
        //transform.localScale = new Vector3(properties.Width, properties.Height, properties.Depth);
        //transform.position = new Vector3(0, 0, properties.ForwardPosition);

        //if (properties.Flipped)
        //{
        //    transform.Rotate(Vector3.right, 90);
        //}
    }
}
