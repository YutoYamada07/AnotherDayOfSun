using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    //���x�F����ꏊ�܂ł̋���/�ꏬ�߂̒���
    //BPM126 ��񂠂���0.4761904761904762
    //�ꏬ�߂̂Ȃ���1.904761904761905

    //����ꏊ�܂ł̋����F60

    //����
    float speed;

    private void Start()
    {
        speed = 31.5f;

    }
    //���ɗ��Ƃ�
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-speed*Time.deltaTime,0);
        
    }
}
