using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveObject : MonoBehaviour
{
    private static SaveObject saveObject;

    private void Awake()
    {
        if(saveObject == null)
        {
            saveObject = this;
            DontDestroyOnLoad(saveObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
