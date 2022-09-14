using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceManager : MonoBehaviour
{
    public CosultManager cosultManager;

    public PriceManagerUI PriceManagerUI;

    public List<Button> ButtonsPrice;

    private List<Price> Prices;

    private void Start()
    {
        Prices = cosultManager.PriceRoulette;
    }

    public void UpdatePrice(string Price)
    {           
        Prices.ForEach(price =>
        {
            if (price.price.Equals(Price))
            {
                price.candPrice--;
                if(price.candPrice == 0)
                {
                    ButtonsPrice.ForEach(button =>
                    {
                        if(Price == button.name)
                        {
                            button.interactable = false;
                        }
                    });
                }
            }
        });

        PriceManagerUI.UpdatePriceUI();
    }

    public bool IsActivePrice(string Price)
    {
        bool isActive = false; ;
        ButtonsPrice.ForEach(button =>
        {
            if (Price == button.name)
            {
               isActive = button.interactable;
            }
        });

        return isActive;
    }
}
