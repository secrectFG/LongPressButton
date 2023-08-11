using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Toggle3D : Button3D
{
    bool isOn = false;

    public UnityEvent<bool> OnToggle;

    override protected void OnMouseDown()
    {
        base.OnMouseDown();
        isOn = !isOn;
        OnToggle?.Invoke(isOn);
        if(isOn)
            animTarget.localPosition += Vector3.right * animMoveDistance;
        else
            animTarget.position = animOriginPos;

    }

    override protected void PlayPress()
    {
        
    }

    override protected void PlayRelease()
    {
        
    }
}
