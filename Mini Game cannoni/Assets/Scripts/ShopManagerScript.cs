using UnityEngine;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    public static ShopManagerScript instance;
    public int currency = 300;
    public Outfit[] outfits;
    public Text currencyText;
    public GameObject shopUI;
    public Transform shopContent;
    public GameObject itemPrefab;

    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        foreach (Outfit outfit in outfits) 
        {
            GameObject item = Instantiate(itemPrefab, shopContent);

            outfit.itemRef = item;

            foreach (Transform child in item.transform)
            {
                if (child.gameObject.name == "Cost")
                {
                    child.gameObject.GetComponent<Text>().text = outfit.cost.ToString();
                }
                else if (child.gameObject.name == "Name")
                {
                    child.gameObject.GetComponent<Text>().text = outfit.name;
                }
                else if (child.gameObject.name == "Image")
                {
                    child.gameObject.GetComponent<Image>().sprite = outfit.image;
                }
            }

            item.GetComponent<Button>().onClick.AddListener(() => {
                BuyOutfit(outfit);
                
            });
        }
    }

    public void BuyOutfit (Outfit outfit)
    {
        if (currency >= outfit.cost)
        {
            currency -= outfit.cost;
            
        }
    }

    public void ToggleShop()
    {
    shopUI.SetActive(!shopUI.activeSelf);
    }
    private void OnGUI()
    {
        currencyText.text = "" + currency.ToString();

    }
}

[System.Serializable]
public class Outfit
    {
        public string name;
        public int cost;
        public Sprite image;
        public bool isUnlocked;
        [HideInInspector] public GameObject itemRef;
    }