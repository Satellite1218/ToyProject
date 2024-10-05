using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform[] ballSpawnTr;

    public GameObject currentBall;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentBall == null)
        {
            for (int i = 0; i < 3; i++)
            {
                Spawner();
            }
        }
    }

    public void Spawner()
    {
        int RandomIndex = Random.Range(0, ballSpawnTr.Length);
        GameObject ball = Instantiate(ballPrefab, ballSpawnTr[RandomIndex]);
        currentBall = ball;
        Bell b_Script = ball.GetComponent<Bell>();
        b_Script.OnInitialized();
    }
}
