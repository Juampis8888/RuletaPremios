using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IndicatorPrace : MonoBehaviour
{
    public GameManager GameManager;

    public GameObject WinGameObject;

    public TextMeshProUGUI MessageText;

    public TextMeshProUGUI MessageTextPrice;

    public PriceManager PriceManager;

    public Animator AnimatorWin;

    public bool isEnter = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "500" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & PriceManager.IsActivePrice("$500"))
        {
            WinGameObject.SetActive(true);
            MessageText.fontSize = 190;
            AnimatorWin.Play("Win");
            MessageText.text = "GANASTE";
            MessageTextPrice.text = "$500";
            PriceManager.UpdatePrice("$500");
            isEnter = true;
        }
        else if (collision.gameObject.tag == "500" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & !PriceManager.IsActivePrice("$500"))
        {
            WinGameObject.SetActive(true);
            GameManager.UpdateGiro();
            MessageText.text = "VUELVE A GIRAR";
            isEnter = true;
        }
        else if (collision.gameObject.tag == "30 FREEBETS" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & PriceManager.IsActivePrice("30 FREEBETS"))
        {
            WinGameObject.SetActive(true);
            MessageText.fontSize = 190;
            AnimatorWin.Play("Win");
            MessageText.text = "GANASTE";
            MessageTextPrice.text = "30 FREEBETS";
            PriceManager.UpdatePrice("30 FREEBETS");
            isEnter = true;
        }
        else if (collision.gameObject.tag == "30 FREEBETS" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & !PriceManager.IsActivePrice("30 FREEBETS"))
        {
            WinGameObject.SetActive(true);
            GameManager.UpdateGiro();
            MessageText.text = "VUELVE A GIRAR";
            isEnter = true;
        }
        else if (collision.gameObject.tag == "Vuelve a girar" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & PriceManager.IsActivePrice("VUELVE A GIRAR"))
        {
            WinGameObject.SetActive(true);
            MessageText.fontSize = 170;
            MessageText.text = "VUELVE A GIRAR";
            MessageTextPrice.text = ""; 
            PriceManager.UpdatePrice("VUELVE A GIRAR");
            isEnter = true;
        }
        else if (collision.gameObject.tag == "Vuelve a girar" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & !PriceManager.IsActivePrice("VUELVE A GIRAR"))
        {
            WinGameObject.SetActive(true);
            GameManager.UpdateGiro();
            MessageText.text = "VUELVE A GIRAR";
            isEnter = true;
        }
        else if (collision.gameObject.tag == "100" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & PriceManager.IsActivePrice("$100"))
        {
            WinGameObject.SetActive(true);
            MessageText.fontSize = 190;
            AnimatorWin.Play("Win");
            MessageText.text = "GANASTE";
            MessageTextPrice.text = "$100";
            PriceManager.UpdatePrice("$100");
            isEnter = true;
        }
        else if (collision.gameObject.tag == "100" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & !PriceManager.IsActivePrice("$100"))
        {
            WinGameObject.SetActive(true);
            GameManager.UpdateGiro();
            MessageText.text = "VUELVE A GIRAR";
            isEnter = true;
        }
        else if (collision.gameObject.tag == "Bono 100" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & PriceManager.IsActivePrice("BONO $100"))
        {
            WinGameObject.SetActive(true);
            MessageText.fontSize = 190;
            AnimatorWin.Play("Win");
            MessageText.text = "GANASTE";
            MessageTextPrice.text = "BONO $100";
            PriceManager.UpdatePrice("BONO $100");
            isEnter = true;
        }
        else if (collision.gameObject.tag == "Bono 100" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & !PriceManager.IsActivePrice("BONO $100"))
        {
            WinGameObject.SetActive(true);
            GameManager.UpdateGiro();
            MessageText.text = "VUELVE A GIRAR";
            isEnter = true;
        }
        else if (collision.gameObject.tag == "Sigue recargando" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & PriceManager.IsActivePrice("SIGUE RECARGANDO"))
        {
            WinGameObject.SetActive(true);
            MessageText.text = "SIGUE RECARGANDO";
            MessageText.fontSize = 170;
            MessageTextPrice.text = "";
            PriceManager.UpdatePrice("SIGUE RECARGANDO");
            isEnter = true;
        }
        else if (collision.gameObject.tag == "Sigue recargando" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & !PriceManager.IsActivePrice("SIGUE RECARGANDO"))
        {
            WinGameObject.SetActive(true);
            GameManager.UpdateGiro();
            MessageText.text = "VUELVE A GIRAR";
            isEnter = true;
        }
        else if (collision.gameObject.tag == "20 FREEBETS" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & PriceManager.IsActivePrice("20 FREEBETS"))
        {
            WinGameObject.SetActive(true);
            MessageText.fontSize = 190;
            AnimatorWin.Play("Win");
            MessageText.text = "GANASTE";
            MessageTextPrice.text = "20 FREEBETS";
            PriceManager.UpdatePrice("20 FREEBETS");
            isEnter = true;
        }
        else if (collision.gameObject.tag == "20 FREEBETS" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & !PriceManager.IsActivePrice("20 FREEBETS"))
        {
            WinGameObject.SetActive(true);
            GameManager.UpdateGiro();
            MessageText.text = "VUELVE A GIRAR";
            isEnter = true;
        }
        else if (collision.gameObject.tag == "Bono 20" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & PriceManager.IsActivePrice("BONO $20"))
        {
            WinGameObject.SetActive(true);
            MessageText.fontSize = 190;
            AnimatorWin.Play("Win");
            MessageText.text = "GANASTE";
            MessageTextPrice.text = "BONO $20";
            PriceManager.UpdatePrice("BONO $20");
            isEnter = true;
        }
        else if (collision.gameObject.tag == "Bono 20" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & !PriceManager.IsActivePrice("BONO $20"))
        {
            WinGameObject.SetActive(true);
            GameManager.UpdateGiro();
            MessageText.text = "VUELVE A GIRAR";
            isEnter = true;
        }
        else if (collision.gameObject.tag == "250" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & PriceManager.IsActivePrice("$250"))
        {
            WinGameObject.SetActive(true);
            MessageText.fontSize = 190;
            AnimatorWin.Play("Win");
            MessageText.text = "GANASTE";
            MessageTextPrice.text = "$250";
            PriceManager.UpdatePrice("$250");
            isEnter = true;
        }
        else if (collision.gameObject.tag == "250" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & !PriceManager.IsActivePrice("$250"))
        {
            WinGameObject.SetActive(true);
            GameManager.UpdateGiro();
            MessageText.text = "VUELVE A GIRAR";
            isEnter = true;
        }
        else if (collision.gameObject.tag == "10 FREEBETS" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & PriceManager.IsActivePrice("10 FREEBETS"))
        {
            WinGameObject.SetActive(true);
            MessageText.fontSize = 190;
            AnimatorWin.Play("Win");
            MessageText.text = "GANASTE";
            MessageTextPrice.text = "10 FREEBETS";
            PriceManager.UpdatePrice("10 FREEBETS");
            isEnter = true;
        }
        else if (collision.gameObject.tag == "10 FREEBETS" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & !PriceManager.IsActivePrice("10 FREEBETS"))
        {
            WinGameObject.SetActive(true);
            GameManager.UpdateGiro();
            MessageText.text = "VUELVE A GIRAR";
            isEnter = true;
        }
        else if (collision.gameObject.tag == "Bono 50" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & PriceManager.IsActivePrice("BONO $50"))
        {
            WinGameObject.SetActive(true);
            MessageText.fontSize = 190;
            AnimatorWin.Play("Win");
            MessageText.text = "GANASTE";
            MessageTextPrice.text = "BONO $50"; 
            PriceManager.UpdatePrice("BONO $50");
            isEnter = true;
        }
        else if (collision.gameObject.tag == "Bono 50" & GameManager.IsMovedRoulette == false & GameManager.IsStart == true & !isEnter & !PriceManager.IsActivePrice("BONO $50"))
        {
            WinGameObject.SetActive(true);
            GameManager.UpdateGiro();
            MessageText.text = "VUELVE A GIRAR";
            isEnter = true;
        }
    }

}
