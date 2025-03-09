using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    private float s;
    private float f;
    public float timeCircle;
    public UnityEngine.Vector3 startPosition;
    public UnityEngine.Vector3 endPosition;
    // Start is called before the first frame update
    void Start()
    {
        s=0;
        transform.localPosition=startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        s+=2.0f*Time.smoothDeltaTime/timeCircle;
        if(s>2.0f) s-=2.0f;
        if(s>1.0f) f=2.0f-s;
        else f=s;
        transform.localPosition=startPosition*(1-f)+f*endPosition;
        
    }
}
