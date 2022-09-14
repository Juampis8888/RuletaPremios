using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject GameObjectCircleRoulette;

    public GameObject GameObjectWin;

    public TextMeshProUGUI MessageText;

    public TextMeshProUGUI MessageTextPrice;

    public CosultManager CosultManager;

    public IndicatorPrace IndicatorPrace;

    public AudioSource AudioSource;

    public bool IsMovedRoulette = false;

    public bool IsStart = false;

    public TextMeshProUGUI UserName;

    public TextMeshProUGUI CandGiro;

    public Button ButtonPush;

    private float Seconds = 0.01f;

    private float TimeRest;

    private int MaxGiro;

    void Start()
    {
        UserName.text = CosultManager.User[0].name;
        CandGiro.text = "CANTIDAD DE GIROS:" + CosultManager.User[0].candGiro.ToString();
        MaxGiro = CosultManager.User[0].candGiro;
    }

    public void CallGiro()
    {
        if (MaxGiro > 0)
        {
            AudioSource.Play();
            StartCoroutine(GiroRoulette(8));
            TimeRest = 8;
            Seconds = 0.01f;
            InvokeRepeating("ResetTime", 1f, 1f);
            MaxGiro--;
            CosultManager.User[0].candGiro = MaxGiro;
            CandGiro.text = "CANTIDAD DE GIROS:" + CosultManager.User[0].candGiro.ToString();
            ButtonPush.interactable = false;
            IsStart = true;
        }
        else
        {
            ButtonPush.interactable = false;
            GameObjectWin.SetActive(true);
            IndicatorPrace.AnimatorWin.enabled = false;
            MessageText.fontSize = 170;
            MessageText.text = "Ya no te quedan giros";
            MessageTextPrice.text = "";

        }
    }

    private IEnumerator GiroRoulette(float duration)
    {
        float startTime = Time.time;
        Debug.Log(startTime);
        Debug.Log(Time.time);
        IsMovedRoulette = true;
        
        while (Time.time < startTime + duration)
        {
            GameObjectCircleRoulette.transform.localRotation = Quaternion.Lerp(GameObjectCircleRoulette.transform.localRotation, Quaternion.Euler(GameObjectCircleRoulette.transform.localRotation.eulerAngles.x, GameObjectCircleRoulette.transform.localRotation.eulerAngles.y, GameObjectCircleRoulette.transform.localRotation.eulerAngles.z + 10), (Time.time - startTime * 0.5f));
            if(TimeRest == 5)
            {
                Debug.Log("Entre Cambio 1");
                Seconds = 0.02f;
            }
            else if(TimeRest == 4)
            {
                Debug.Log("Entre Cambio 2");
                Seconds = 0.06f;
            }
            else if (TimeRest == 3)
            {
                Debug.Log("Entre Cambio 3");
                Seconds = 0.09f;
            }
            else if (TimeRest == 2)
            {
                Debug.Log("Entre Cambio 3");
                Seconds = 0.1f;
            }
            else if (TimeRest == 1)
            {
                Debug.Log("Entre Cambio 4");
                Seconds = 0.13f;
            }

            yield return new WaitForSeconds(Seconds);
        }
        IsMovedRoulette = false;
        
    }

    public void ContinueGame()
    {
        ButtonPush.interactable = true;
        GameObjectWin.SetActive(false);
        IsStart = false;
        IndicatorPrace.isEnter = false;
        IndicatorPrace.AnimatorWin.StopPlayback();
        IndicatorPrace.AnimatorWin.Rebind();
    }

    public void ResetTime()
    {
        TimeRest--;
    }

    public void UpdateGiro()
    {
        CosultManager.User[0].candGiro++;
        CandGiro.text = "CANTIDAD DE GIROS:" + CosultManager.User[0].candGiro.ToString();
    }
}

