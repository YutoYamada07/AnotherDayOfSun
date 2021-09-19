using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{
    [SerializeField] NoteGenerator noteGenerator = default;
    [SerializeField] NoteGenerator2 noteGenerator2 = default;
    [SerializeField] NoteGenerator3 noteGenerator3 = default;
    public void NoteEvent()
    {
        //Debug.Log("音がなるよ");
        noteGenerator.SpawnNote();
    }
    public void NoteEvent2()
    {
        //Debug.Log("音がなるよ");
        noteGenerator2.SpawnNote();
    }
    public void NoteEvent3()
    {
        //Debug.Log("音がなるよ");
        noteGenerator3.SpawnNote();
    }
}
