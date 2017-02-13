using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentController : StudioElement {

    private Instrument instrumentProperties;

    // Use this for initialization
    void Start () {
        instrumentProperties = app.instrumentModel.GetInstrumentProperties();
        SetInstrumentProperties(instrumentProperties);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SetInstrumentProperties(Instrument properties)
    {

    }
}
