using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button3D : MonoBehaviour
{

    public float animMoveDistance = 0.1f;
    public Transform animTarget;

    public UnityEvent OnPress;
    public UnityEvent OnRelease;

    protected Vector3 animOriginPos;

    private void Awake()
    {
        animOriginPos = animTarget.position;
    }

    protected virtual void PlayPress()
    {
        animTarget.localPosition += Vector3.down * animMoveDistance;
    }

    protected virtual void PlayRelease()
    {
        animTarget.position = animOriginPos;
    }

    protected virtual void OnMouseDown()
    {
        OnPress?.Invoke();
        PlayPress();
    }
    protected virtual void OnMouseUp()
    {
        OnRelease?.Invoke();
        PlayRelease();
    }
}
