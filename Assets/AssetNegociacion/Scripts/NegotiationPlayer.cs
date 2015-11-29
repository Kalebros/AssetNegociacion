using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NegotiationPlayer : MonoBehaviour {


    public GameObject panelA;
    public GameObject panelB;

    private bool _isDialogOn = false;

	// Use this for initialization
	void Start () {
        panelA.SetActive(false);
        panelB.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DialogObject"))
        {
            initDialog();
        }
    }

    void initDialog()
    {
        if (!_isDialogOn)
        {
            _isDialogOn = true;
            print("Hola!");
            panelA.SetActive(true);
        }
    }

    public void toStateA()
    {
        panelB.SetActive(false);
        panelA.SetActive(true);
    }

    public void toStateB()
    {
        panelA.SetActive(true);
        panelB.SetActive(false);
    }

}
