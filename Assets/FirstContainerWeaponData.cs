using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstContainerWeaponData : MonoBehaviour
{
    public string gunName;
    public string ammoName;
    public enum AttachMent { SIGHT,COMBATSIGHT,MUZZLE,MAG,GRIP,STOCK };

    public bool isSIGHT = false;
    public bool isCOMBATSIGHT = false;
    public bool isMUZZLE = false;
    public bool isMAG = false;
    public bool isGRIP = false;
    public bool isSTOCK = false;
}
