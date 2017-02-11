using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TrackState
{
    public TrackState(float volume, float pan, bool muted, bool soloed)
    {
        this.volume = volume;
        this.pan = pan;
        this.muted = muted;
        this.soloed = soloed;
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

    public bool Muted
    {
        get
        {
            return muted;
        }
        set
        {
            muted = value;
        }
    }

    public bool Soloed
    {
        get
        {
            return soloed;
        }
        set
        {
            soloed = value;
        }
    }

    private float volume;
    private float pan;
    private bool muted;
    private bool soloed;
}
