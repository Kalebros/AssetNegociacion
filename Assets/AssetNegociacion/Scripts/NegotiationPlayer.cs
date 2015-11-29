using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NegotiationPlayer : MonoBehaviour {


    public GameObject panel;
    private bool _isDialogOn = false;

	// Use this for initialization
	void Start () {
        panel.SetActive(false);
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
            panel.SetActive(true);
        }
    }

}
