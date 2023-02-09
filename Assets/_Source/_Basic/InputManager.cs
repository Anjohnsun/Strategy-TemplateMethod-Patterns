using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent OnAttackInvoked = new UnityEvent();
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            OnAttackInvoked.Invoke();
        }
    }
}
