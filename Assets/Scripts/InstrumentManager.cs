using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;

public class InstrumentManager : Singleton<InstrumentManager> {

    private List<Instrument> instrumentList = new List<Instrument>();

    public List<Instrument> InstrumentList
    {
        get
        {
            //Some other code
            return instrumentList;
        }
        set
        {
            //Some other code
            instrumentList = value;
        }
    }

}
