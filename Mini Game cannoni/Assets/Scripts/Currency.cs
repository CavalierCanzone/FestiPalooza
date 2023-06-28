using UnityEngine;
using TMPro;

public class Currency : MonoBehaviour
{
    [SerializeField] private int currentCurrency;
    public TextMeshProUGUI currencyText;

    private void Awake()
    {
        currentCurrency = PlayerPrefs.GetInt("prefCurrency");
        OnCurrencyAmountChange();
    }

    public void AddCurrency(int currencyAmountToAdd)
    {
        currentCurrency += currencyAmountToAdd;
        OnCurrencyAmountChange();
    }

    public bool TryRemoveCurrency(int currencyToRemove)
    {
        if (currentCurrency >= currencyToRemove)
        {
            currentCurrency -= currencyToRemove;
            OnCurrencyAmountChange();
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnCurrencyAmountChange()
    {
        PlayerPrefs.SetInt("prefCurrency", currentCurrency);
        currencyText.text = currentCurrency + "";
    }

    public void ChangeCurrencyTextReference(TextMeshProUGUI newTextReference)
    {
        currencyText = newTextReference;
        currencyText.text = currentCurrency + " ";
    }
}
