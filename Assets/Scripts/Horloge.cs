using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horloge : MonoBehaviour
{
    public Transform hourObject;
    public Transform minuteObject;
    public Transform secondObject;
    
    private void Update()
    {
        DateTime current = DateTime.Now;
        secondObject.transform.localEulerAngles = new Vector3(360/60*current.Second,0,0);
        minuteObject.transform.localEulerAngles = new Vector3(0,360/60*current.Minute,0);
        hourObject.transform.localEulerAngles = new Vector3(0,0,360/60*(current.Hour%12));
    }

}
