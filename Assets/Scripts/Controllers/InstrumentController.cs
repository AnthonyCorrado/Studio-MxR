using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Audio;

public class InstrumentController : StudioElement {
    
    private InstrumentModel model;
    private InstrumentView view;

    private AudioSource audioSource;

    // TODO for testing
    public Vector3 mixerDimensions;

    // Use this for initialization
    void Awake () {
        view = GetComponent<InstrumentView>();
        model = GetComponent<InstrumentModel>();

        audioSource = GetComponent<AudioSource>();

        mixerDimensions = new Vector3(1f, 0.5f, 2f);
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.hasChanged)
        {
            // just for testing purposes
            var pos = transform.position; // this all needs to happen elsewhere - HandDraggable?
            pos.x = Mathf.Clamp(transform.position.x, -0.5f, 0.5f);
            transform.position = pos;

            audioSource.volume -= transform.position.z;
            audioSource.panStereo += transform.position.x;
            transform.hasChanged = false;
            
        }
	}

    public void SetInstrumentProperties(Instrument properties)
    {
        audioSource.clip = properties.Clip;

        Transform instrumentTransform = transform;
        float scale = properties.Type.DefaultSize;
        // takes frequency mean and scales it to match mixer grid. Then applies half of the parent container to ensure proper placement
        float frequencyPosition = (properties.Type.FrequencyMean / 20000f) - 0.5f;

        Vector3 parentScale = transform.parent.localScale;

        // counters scaling issue when parented
        Vector3 adjustedScale = new Vector3((0.5f / parentScale.x) * scale, (0.5f / parentScale.y) * scale, (0.5f / parentScale.z * scale));

        instrumentTransform.localScale = adjustedScale;
        instrumentTransform.localPosition = new Vector3(transform.position.x, frequencyPosition, 0);

        UpdateView(instrumentTransform, properties);
    }

    public Color GetInstrumentColor()
    {
        Debug.Log("app instro: " + model.GetCurrentInstrumentValue());
        return model.GetCurrentInstrumentValue().Color;
    }

    private void UpdateView(Transform instrumentTransform, Instrument properties)
    {
        view.UpdateInstrumentProperties(instrumentTransform, properties);
    }
}
