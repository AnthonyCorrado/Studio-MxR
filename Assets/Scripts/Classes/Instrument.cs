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

    public State State
    {
        get
        {
            return state;
        }
        set
        {
            state = value;
        }
    }

    private string name;
    private InstrumentType type;
    private Color color;
    private AudioClip clip;

    private State state;
}

[System.Serializable]
public class State
{
    public State()
    {
        volume = 1;
        pan = 0;
        mute = false;
        spatialize = false;
        spatialBlend = 0;
    }

    public State(float volume, float pan, bool mute, bool spatialize, float spatialBlend)
    {
        this.volume = volume;
        this.pan = pan;
        this.mute = mute;
        this.spatialize = spatialize;
        this.spatialBlend = spatialBlend;
    }

    //Accessor Functions
    public float Volume
    {
        get
        {
            return volume;
        }
        set
        {
            volume = value;
        }
    }

    public float Pan
    {
        get
        {
            return pan;
        }
        set
        {
            pan = value;
        }
    }

    public bool Mute
    {
        get
        {
            return mute;
        }
        set
        {
            mute = value;
        }
    }

    public bool Spatialize
    {
        get
        {
            return spatialize;
        }
        set
        {
            spatialize = value;
        }
    }

    public float SpatialBlend
    {
        get
        {
            return spatialBlend;
        }
        set
        {
            spatialBlend = value;
        }
    }

    private float volume;
    private float pan;
    private bool mute;
    private bool spatialize;
    private float spatialBlend;
}
