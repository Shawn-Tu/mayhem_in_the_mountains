using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentChildCheck : MonoBehaviour
{
    [SerializeField] GameObject item;

    private void Update()
    {
        if(transform.childCount <= 0)
        {
            item.SetActive(true);
        }
    }

}
