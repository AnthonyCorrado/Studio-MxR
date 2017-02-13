using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InstrumentType
{
    public InstrumentType(string name, float frequencyMean, float defaultSize, Color defaultColor)
    {
        this.name = name;
    }

    public InstrumentType(string name)
    {
        Debug.Log("made it create");
        this.name = name;
        frequencyMean = getFreqMean(name);
        defaultSize = getDefaultSize(name);
        defaultColor = getDefaultColor(name);
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
        //set
        //{
        //    frequencyMean = value;
        //}
    }

    public float DefaultSize
    {
        get
        {
            return defaultSize;
        }
        //set
        //{
        //    frequencyMean = value;
        //}
    }

    public Color DefaultColor
    {
        get
        {
            return defaultColor;
        }
        //set
        //{
        //    defaultColor = value;
        //}
    }

    private string name;
    private float frequencyMean;
    private float defaultSize;
    private Color defaultColor;

    private float getFreqMean(string instrumentType)
    {
        if (instrumentType == "AcousticGuitar")
        {
            return 5000;
        }
        else
        {
            return 0;
        }
    }

    // refers to the percentage of gameObject's height in relation to parent mixer height
    private float getDefaultSize(string instrumentType)
    {
        if (instrumentType == "AcousticGuitar")
        {
            return 0.2f;
        }
        else
        {
            return 0;
        }
    }

    private Color getDefaultColor(string instrumentType)
    {
        Debug.Log("made it default color with a value of: " + instrumentType);
        if (instrumentType == "AcousticGuitar")
        {
            Debug.Log("i returned red");
            return Color.red;
        }
        else
        {
            return Color.gray;
        }
    }
}
