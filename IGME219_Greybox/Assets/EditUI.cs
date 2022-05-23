using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EditUI : MonoBehaviour
{
    
public GameObject myUI;

    // Start is called before the first frame update
    void Start()
    {
        myUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey){
            myUI.SetActive(false);
        }
    }
}
