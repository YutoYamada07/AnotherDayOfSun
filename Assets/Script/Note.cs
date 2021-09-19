using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    //‘¬“xF”»’èêŠ‚Ü‚Å‚Ì‹——£/ˆê¬ß‚Ì’·‚³
    //BPM126 ˆê‰ñ‚ ‚½‚è0.4761904761904762
    //ˆê¬ß‚Ì‚È‚ª‚³1.904761904761905

    //”»’èêŠ‚Ü‚Å‚Ì‹——£F60

    //‘¬‚³
    float speed;

    private void Start()
    {
        speed = 31.5f;

    }
    //‰º‚É—‚Æ‚·
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-speed*Time.deltaTime,0);
        
    }
}
