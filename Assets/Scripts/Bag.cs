using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    void Start()
    {

        if (BagInventory.instance == null)
        {
            Debug.Log("bagobject null");
            return;
        }
        BagInventory.instance.SetActive(BagConstant.instance.tooglebagInventoryObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (BagInventory.instance == null)
            {
                Debug.Log("bagobject null");
                return;
            }
            BagConstant.instance.tooglebagInventoryObject = !BagConstant.instance.tooglebagInventoryObject;
            BagInventory.instance.SetActive(BagConstant.instance.tooglebagInventoryObject);
            Debug.Log("Pressed primary button.");
        }
    }
}
