using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentController : StudioElement {

    private InstrumentModel model;
    private InstrumentView view;

    // Use this for initialization
    void Awake () {
        view = GetComponent<InstrumentView>();
        model = GetComponent<InstrumentModel>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetInstrumentProperties(Instrument properties)
    {
        Debug.Log("controller SIP");
        Transform instrumentTransform = transform;
        float scale = properties.Type.DefaultSize;
        // takes frequency mean and scales it to match mixer grid. Then applies half of the parent container to ensure proper placement
        float frequencyPosition = (properties.Type.FrequencyMean / 20000f) - 0.5f;

        Vector3 parentScale = transform.parent.localScale;

        // counters scaling issue when parented
        Vector3 adjustedScale = new Vector3((0.5f / parentScale.x) * scale, 0.5f / parentScale.y * scale, 0.5f / parentScale.z * scale);

        instrumentTransform.localScale = adjustedScale;
        instrumentTransform.localPosition = new Vector3(transform.position.x, frequencyPosition, 0);
        Debug.Log("WTF???: " + view);
        view.UpdateInstrumentProperties(instrumentTransform, properties);
    }

    public Color GetInstrumentColor()
    {
        Debug.Log("app instro: " + model.GetCurrentInstrumentValue());
        return model.GetCurrentInstrumentValue().Color;
    }
}
