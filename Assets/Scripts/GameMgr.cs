using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public int curLV = 1;
    public int curEnemyHp = 1;
    public float curEnemySpeed = 1;
    public int stageEnemyCnt = 2;
    public int killCnt = 0;
    public GameObject nextBtn;
    public GameObject enemy;

    public void StageLvUp()
    {
        curEnemyHp *= 2;
        curEnemySpeed *= 1.1f;
        stageEnemyCnt *= 2;
    }

    private void Start()
    {
        nextBtn = GameObject.Find("NextBtn");
    }

    private void Update()
    {
        enemy = GameObject.FindWithTag("Enemy");
        if (enemy == null)
        {
            nextBtn.SetActive(true);
        }
        else
        {
            nextBtn.SetActive(false);
        }
    }
}
