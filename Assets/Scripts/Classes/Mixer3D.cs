using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Mixer3D
{
    public Mixer3D(float width, float height, float depth, float forwardPosition, bool flipped)
    {
        this.width = width;
        this.height = height;
        this.depth = depth;
        this.forwardPosition = forwardPosition;
        this.flipped = flipped;
    }

    //Accessor Functions
    public float Width
    {
        get
        {
            return width;
        }
        set
        {
            width = value;
        }
    }

    public float Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
        }
    }

    public float Depth
    {
        get
        {
            return depth;
        }
        set
        {
            depth = value;
        }
    }

    public float ForwardPosition
    {
        get
        {
            return forwardPosition;
        }
        set
        {
            forwardPosition = value;
        }
    }

    public bool Flipped
    {
        get
        {
            return flipped;
        }
        set
        {
            flipped = value;
        }
    }

    private float width;
    private float height;
    private float depth;
    private float forwardPosition;
    private bool flipped;
}
