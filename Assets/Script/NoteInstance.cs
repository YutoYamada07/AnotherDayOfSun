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
        //Debug.Log("‰¹‚ª‚È‚é‚æ");
        noteGenerator.SpawnNote();
    }
    public void NoteEvent2()
    {
        //Debug.Log("‰¹‚ª‚È‚é‚æ");
        noteGenerator2.SpawnNote();
    }
    public void NoteEvent3()
    {
        //Debug.Log("‰¹‚ª‚È‚é‚æ");
        noteGenerator3.SpawnNote();
    }
}
