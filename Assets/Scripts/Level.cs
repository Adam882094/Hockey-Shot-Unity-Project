using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public int lev = 1;
    public int leftCnt = 0;
    public int rightCnt = 0;
    void OnTriggerEnter2D(Collider2D check)
    {
        if (check.CompareTag("puckLeft"))
        {
            leftCnt = 1;
            Debug.Log(leftCnt);
        }
        if (check.CompareTag("puckRight"))
        {
            rightCnt = 1;
            Debug.Log(rightCnt);
        }
    }

    public void Update()
    {
        if (leftCnt == 1) // && rightCnt == 1
        {
            Debug.Log("test");
            leftCnt = 0;
            rightCnt = 0;
            SceneManager.LoadScene(lev);
        }
    }
}
