using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    //速度：判定場所までの距離/一小節の長さ
    //BPM126 一回あたり0.4761904761904762
    //一小節のながさ1.904761904761905

    //判定場所までの距離：60

    //速さ
    float speed;

    private void Start()
    {
        speed = 31.5f;

    }
    //下に落とす
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-speed*Time.deltaTime,0);
        
    }
}
