using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectbutton : MonoBehaviour
{
    // Start is called before the first frame update

    public int buttonNum;
    public ButtonCtrl startred;
    public EnterSelect enterselect;

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.white;
        GetComponent<Renderer>().material.color *= 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("ButtonNum: " + buttonNum);
    }

}
