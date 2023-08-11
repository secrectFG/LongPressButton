using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LongPressButton3D : Button3D
{
    public float longPressTime = 1f;
    public UnityEvent OnLongPress;
    public UnityEvent<float> OnProgres;
    Coroutine longPressDectectCo = null;


    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        longPressDectectCo = StartCoroutine(LongPressDectectCo());
    }

    protected override void OnMouseUp()
    {
        base.OnMouseUp();
        if (longPressDectectCo != null)
        {
            StopCoroutine(longPressDectectCo);
            longPressDectectCo = null;
        }
    }

    IEnumerator LongPressDectectCo()
    {
        float time = 0;
        while (true)
        {
            time += Time.deltaTime;

            if(time >= longPressTime)
            {
                OnLongPress?.Invoke();
                break;
            }

            OnProgres?.Invoke(time / longPressTime);

            yield return null;
        }
    }
}
