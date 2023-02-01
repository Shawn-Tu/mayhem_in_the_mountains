using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ProjectileEnemy : MonoBehaviour
{
    public float speed;
    public float stopDistance;
    public float fallbackDistance;
    public float distanceBT;

    [SerializeField] float range;
    [SerializeField] float maxDistance;

    public Transform player1;
    public GameObject player;

    private float distance;

    Vector2 wayPoint;

    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player1.position) > stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player1.position, speed * Time.deltaTime);
        } 
        else if (Vector2.Distance(transform.position, player1.position) < stopDistance && Vector2.Distance(transform.position, player1.position) > fallbackDistance)
        {
            transform.position = this.transform.position;
        }

        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        if (distance > distanceBT)
        {
            Roam();
        }
    }

    void Roam()
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
