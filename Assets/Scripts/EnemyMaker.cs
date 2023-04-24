using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float curTime;
    public float coolTime = 1f;
    public int enemyCnt = 0;
    public int enemyMaxCnt = 0;
    public GameMgr gameMgr;
    public bool isRunning = false;

    void Start()
    {
        gameMgr = GameObject.Find("GameMgr").GetComponent<GameMgr>();
        isRunning = true;
    }

    void Update()
    {
        if (enemyCnt > enemyMaxCnt)
            isRunning = false;

        if (isRunning == true)
        {
            curTime += Time.deltaTime;
            if (curTime > coolTime)
            {
                curTime = 0;
                GameObject enemy = Instantiate(enemyPrefab,
                    transform.position, transform.rotation); 
                enemy.name = "Enemy_" + enemyCnt;
                enemy.GetComponent<EnemyController>().enemyHp = gameMgr.curEnemyHp;
                enemy.GetComponent<EnemyController>().moveSpeed = gameMgr.curEnemySpeed;
                enemyMaxCnt = gameMgr.stageEnemyCnt;
                enemyCnt++;
            }
        }
    }

    public void InitEnemyMaker()
    {
        enemyCnt = 0;
        isRunning = true;
        gameMgr.curLV++;
        gameMgr.StageLvUp();
    }

}
