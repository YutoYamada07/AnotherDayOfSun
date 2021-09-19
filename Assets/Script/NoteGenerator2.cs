using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGenerator2 : MonoBehaviour
{
    [SerializeField] Note notePrefab;

    private void Start()
    {
        SpawnNote();
    }
    public void SpawnNote()
    {
        Instantiate(notePrefab, new Vector3(-25, 10, 0), Quaternion.identity);

    }
}
