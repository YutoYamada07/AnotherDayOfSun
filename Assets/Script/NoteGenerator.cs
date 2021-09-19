using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGenerator : MonoBehaviour
{
    [SerializeField] Note notePrefab;

    private void Start()
    {
        SpawnNote();
    }
    public void SpawnNote()
    {
        Instantiate(notePrefab,new Vector3(0,10,0),Quaternion.identity);
    
    }
}
