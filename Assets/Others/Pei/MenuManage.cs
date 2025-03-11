using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuManage : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mMainCamera;
    public static MenuManage sMenuManage=new MenuManage();

    public SelectManage sSelectManage;
    void Awake()
    {
        sMenuManage = this;
        sSelectManage.Activate(false);

    }

    // Update is called once per frame


    void Update()
    {
        
    }

    public void EnterSelect()
    {

        Debug.Log("EnterSelect");
        GameObject smain = GameObject.Find("MainMenu");

        smain.SetActive(false);
        sSelectManage.Activate(true);
    }

    
}

