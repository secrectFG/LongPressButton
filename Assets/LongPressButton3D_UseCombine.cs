using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LongPressButton3D_UseCombine : MonoBehaviour
{
    public GameObject text;
    public Image progress;

    ButtonAnim buttonAnim;
    ButtonEvent buttonEvent;
    Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        buttonAnim = GetComponentInChildren<ButtonAnim>();
        buttonEvent = GetComponent<ButtonEvent>();
        timer = GetComponent<Timer>();

        timer.OnComplete.AddListener(() => { text.SetActive(true); });
        timer.OnProgress.AddListener((ratio) => { progress.fillAmount = ratio; });

        buttonEvent.OnPress.AddListener(() => { 
            buttonAnim.PlayPress();
            timer.StartTimer();
            progress.gameObject.SetActive(true);
        });

        buttonEvent.OnRelease.AddListener(() =>
        {
            buttonAnim.PlayRelease();
            timer.StopTimer();
            progress.gameObject.SetActive(false);
            text.SetActive(false);
            progress.fillAmount = 0;
        });
    }
}
