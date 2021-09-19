using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgementArea2 : MonoBehaviour
{
    [SerializeField] float radius;

    [SerializeField] GameManager gameManager = default;
    //ノーツが落ちてきたときにキーボードを押したら判定する（キーボード入力、どれくらいの近くにノーツがあるのか（評価））

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Aを入力");
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, new Vector3(-25,0,0));
            if (hit2D)
            {

                Debug.Log("ノーツがぶつかった");
                float distance = Mathf.Abs(hit2D.transform.position.y - transform.position.y);
                if (distance < 3)
                {

                    gameManager.AddScore(50);
                }
                else if (distance < 5)
                {

                    gameManager.AddScore(25);
                }
                else
                {

                    gameManager.AddScore(10);
                }
                Destroy(hit2D.collider.gameObject);
            }
        }

    }

    //可視化ツール
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
