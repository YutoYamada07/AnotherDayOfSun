using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgementArea2 : MonoBehaviour
{
    [SerializeField] float radius;

    [SerializeField] GameManager gameManager = default;
    //�m�[�c�������Ă����Ƃ��ɃL�[�{�[�h���������画�肷��i�L�[�{�[�h���́A�ǂꂭ�炢�̋߂��Ƀm�[�c������̂��i�]���j�j

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A�����");
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, new Vector3(-25,0,0));
            if (hit2D)
            {

                Debug.Log("�m�[�c���Ԃ�����");
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

    //�����c�[��
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
