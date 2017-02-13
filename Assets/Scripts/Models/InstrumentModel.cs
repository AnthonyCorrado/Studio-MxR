using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentModel : StudioElement {

    public string instrumentName;

    public enum InstroTypes
    {
        LeadVocal, BackupVocal, AcousticGuitar, ElectricGuitar, 
        Piano, Violin, Saxophone, Flute, Cello, Clarinet, Trumpet, Harp,
        Drums, Kick, Snare, Tom, HiHat, Cymbal

    }
    public InstroTypes type;

    public Color color;
    public AudioClip clip;

    private InstrumentType instrumentType;

    // Use this for initialization
    void Start () {
        instrumentType = new InstrumentType(type.ToString());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public Instrument GetInstrumentProperties ()
    {
        return new Instrument(instrumentName, instrumentType, color, clip);
    }
}
