using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Instrument
{
	public Instrument(string name, InstrumentType type, Color color, AudioClip clip)
    {
        this.name = name;
        this.type = type;
        this.color = color;
        this.clip = clip;
    }

    //Accessor Functions
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public InstrumentType Type
    {
        get
        {
            return type;
        }
        set
        {
            type = value;
        }
    }

    public Color Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
        }
    }

    public AudioClip Clip
    {
        get
        {
            return clip;
        }
        set
        {
            clip = value;
        }
    }

    private string name;
    private InstrumentType type;
    private Color color;
    private AudioClip clip;
}
