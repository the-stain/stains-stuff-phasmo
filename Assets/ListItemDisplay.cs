using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListItemDisplay : MonoBehaviour
{
    public Text itemName;
    public Text itemCost;

    public GameObject listItemPrefab;
    public Transform listItemViewport;

    // Start is called before the first frame update
    void Start()
    {  
                
    }

    void CreateListItem(EquipmentType t)
    {
        GameObject itemSlot = Instantiate(listItemPrefab, listItemViewport);
        itemSlot.GetComponent<Button>().onClick.AddListener(delegate {FindObjectOfType<ShopDisplay>().DisplayListItem(t, });

    }
}
