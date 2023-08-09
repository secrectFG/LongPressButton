using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnim : MonoBehaviour
{
    public float moveDistance = 0.1f;

    private Vector3 originPos;

    private void Awake()
    {
        originPos = transform.position;
    }

    public void PlayPress()
    {
        transform.localPosition += Vector3.down * moveDistance;
    }

    public void PlayRelease()
    {
        transform.position = originPos;
    }
}
