using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTargetCam : MonoBehaviour
{
    public GameObject target;
    public GameObject popUp;
    public Transform targetTf;
    public Camera mainCam;


    void Start()
    {
        popUp = GameObject.Find("UpGradePopUp");
    }

    void Update()
    {
        
    }
}
