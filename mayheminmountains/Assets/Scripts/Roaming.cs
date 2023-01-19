using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roaming : MonoBehaviour
{
    [SerializeField]float speed;
    [SerializeField]float range;
    [SerializeField] float maxDistance;

    GameObject ai;

    Vector2 wayPoint;

    // Start is called before the first frame update
    void Start()
    {
        SetNewDistination();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint) < range)
        {
            SetNewDistination();
        }
    }

    void SetNewDistination()
    {
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }
}
