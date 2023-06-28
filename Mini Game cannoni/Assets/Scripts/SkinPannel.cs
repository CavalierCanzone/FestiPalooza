using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SkinPannel : MonoBehaviour
{
    public GameObject skinToEquip;
    public RawImage iconImage;
    public TextMeshProUGUI buttonText;
    public enum SkinsIDs {defaultMan, dapperHat, plantHead, blueDevil}
    public SkinsIDs skinID;
    public int skinCost = 1;
    private bool isSkinUnlocked;

    private void Awake()
    {
        if (PlayerPrefs.GetInt(skinID.ToString()) == 1)
        {
            isSkinUnlocked = true;
            buttonText.text = "SELECT";
        }
    }

    

    public void EquipSkin()
    {
        
        SkinLoader.skinToLoad = skinToEquip;
        
        
    }

    public void OnSkinButtonPress()
    {
        if (isSkinUnlocked)
        {
            EquipSkin();
            buttonText.text = "SELECT";
        }
        else
        {
            if (FindObjectOfType<Currency>().TryRemoveCurrency(skinCost))
            {
                isSkinUnlocked = true;
                PlayerPrefs.SetInt(skinID.ToString(), 1);
                buttonText.text = "SELECT";
                Destroy(iconImage);
                
            }
            
        }
    }
}
