using UnityEngine;
using System.Collections;

public class NegotiationActivator : MonoBehaviour {

    public GameObject panelA;
    public GameObject panelB;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void toStateA()
    {
        panelB.SetActive(false);
        panelA.SetActive(true);
    }

    public void toStateB()
    {
        panelB.SetActive(true);
        panelA.SetActive(false);
    }
}
