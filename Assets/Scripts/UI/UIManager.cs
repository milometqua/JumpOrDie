using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : Singleton<UIManager>
{
    public GameObject perfect;
    public GameObject taptap;
    public GameObject countdown;

    private Animator animatorCountdown;

    private void Start()
    {
        OffCountdown();
        OffPerfect();
        animatorCountdown = countdown.GetComponent<Animator>();
    }

    public void ContinueGame()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        OnCountdown();
        animatorCountdown.updateMode = AnimatorUpdateMode.UnscaledTime;
        animatorCountdown.Play("Countdown");
        yield return new WaitForSecondsRealtime(3f);
        Time.timeScale = 1.0f;
        OffCountdown();
    }

    public void OnPerfect()
    {
        perfect.SetActive(true);
    }

    public void OffPerfect()
    {
        perfect.SetActive(false);
    }

    public void OnTap()
    {
        taptap.SetActive(true);
    }

    public void OffTap()
    {
        taptap.SetActive(false);
    }

    public void OnCountdown()
    {
        countdown.SetActive(true);
    }

    public void OffCountdown()
    {
        countdown.SetActive(false);
    }
}
