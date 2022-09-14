using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceManagerUI : MonoBehaviour
{
    public PriceAdapter AdapterPrice;

    public CosultManager cosultManager;

    public RectTransform Content;

    private void Start()
    {
        int Count = 0;
        var Position = 0;
        var AwardsRectTransform = AdapterPrice.GetComponent<RectTransform>();
        float templateHeight = AwardsRectTransform.rect.height;
        cosultManager.PriceRoulette.ForEach(price =>
        {
            float top = (((Position * templateHeight))) * -1;
            var item = Instantiate(AdapterPrice);
            item.gameObject.SetActive(true);
            item.name = "Price" + (Position + 1);
            item.Parent(Content);
            item.Location(top);
            item.Price.text = price.price;
            item.CandPrime.text = price.candPrice.ToString();

            item.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            Position++;
            Count++;
        });
        var height = Count * templateHeight;
        //Content.localPosition = new Vector3(Content.localPosition.x, 0, Content.localPosition.z);
        Content.sizeDelta = new Vector2(Content.rect.width, height);
        
    }

    public void UpdatePriceUI()
    {

        int CountChild = Content.childCount;
        int Count = 0;
        var Position = 0;
        var AwardsRectTransform = AdapterPrice.GetComponent<RectTransform>();
        float templateHeight = AwardsRectTransform.rect.height;

        if (CountChild > 0)
        {
            for(int i= 0; i < CountChild; i++)
            {
                Destroy(Content.GetChild(i).gameObject);
            }
        }
        cosultManager.PriceRoulette.ForEach(price =>
        {
            float top = (((Position * templateHeight))) * -1;
            var item = Instantiate(AdapterPrice);
            item.gameObject.SetActive(true);
            item.name = "Price" + (Position + 1);
            item.Parent(Content);
            item.Location(top);
            item.Price.text = price.price;
            item.CandPrime.text = price.candPrice.ToString();

            item.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            Position++;
            Count++;
        });
        var height = Count * templateHeight;
        //Content.localPosition = new Vector3(Content.localPosition.x, 0, Content.localPosition.z);
        Content.sizeDelta = new Vector2(Content.rect.width, height);

    }
}
