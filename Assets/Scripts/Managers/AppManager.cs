using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudioElement : MonoBehaviour
{
    public AppManager app
    {
        get
        {
            return GameObject.FindObjectOfType<AppManager>();
        }
    }
}

public class AppManager : MonoBehaviour
{

    public Mixer3DModel mixer3DModel;
    public Mixer3DView mixer3DView;
    public Mixer3DController mixer3DController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
