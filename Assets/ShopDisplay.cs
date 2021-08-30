using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

/* A script to create prefabs that display all of the Equipment available in the shop. 
 * A list is retrieved of all the EquipmentType assets found in the Assets/SOAssets/EquipmentType folder.
 * Then, for each asset found, an instance of the listItemPrefab is made and placed as a child of the 
 * listItemViewport. The viewport object has a Vertical Layout Group component which automatically handles
 * the position of the instances.
 */

public class ShopDisplay : MonoBehaviour
{
    public ListSO equipList;
    public Text nameBox;
    public Text descBox;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void DisplayListItem(EquipmentType e, int n)
    {
        nameBox.text = e.displayName;
        descBox.text = e.description;

    }

}
