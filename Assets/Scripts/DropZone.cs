using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler ,IPointerEnterHandler ,IPointerExitHandler
{
    public Draggable.Slot typeOfItem = Draggable.Slot.WEAPON;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name+" was dropped on "+gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            if (typeOfItem == d.typeOfItem) {
                
                foreach (Transform eachChild in transform)
                {
                    if (eachChild.name == "weapon1" || eachChild.name == "weapon2")
                    {
                        eachChild.transform.parent = d.parentToReturnTo;
                        d.parentToReturnTo = this.transform;
                        
                    }
                }
            }
            
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("OnPointerExit");
    }
}
 