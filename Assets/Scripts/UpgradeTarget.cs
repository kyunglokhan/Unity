using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTarget : MonoBehaviour
{
    public GameObject target;
    public GameObject popUp;
    public Transform targetTf;

    void Start()
    {
        popUp = GameObject.Find("UpGradePopUp");
    }
}
