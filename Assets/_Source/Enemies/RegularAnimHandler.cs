using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RegularAnimHandler : MonoBehaviour
{
    public static UnityEvent AnimationHappened = new UnityEvent();
    public void AnimEventHappened()
    {
        AnimationHappened.Invoke(); 
    }
}
