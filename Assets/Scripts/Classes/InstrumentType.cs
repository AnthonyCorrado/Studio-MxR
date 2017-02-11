using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InstrumentType
{
    public InstrumentType(string name, float frequencyMean, Color defaultColor)
    {
        this.name = name;
        this.frequencyMean = frequencyMean;
        this.defaultColor = defaultColor;
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

    public float FrequencyMean
    {
        get
        {
            return frequencyMean;
        }
        set
        {
            frequencyMean = value;
        }
    }

    public Color DefaultColor
    {
        get
        {
            return defaultColor;
        }
        set
        {
            defaultColor = value;
        }
    }

    private string name;
    private float frequencyMean;
    private Color defaultColor;
}
