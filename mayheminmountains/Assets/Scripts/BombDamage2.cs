using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDamage2 : MonoBehaviour
{
    public float damage = 20;
    public float splashRange = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(splashRange > 0)
        {
            var hitColliders = Physics2D.OverlapCircleAll(transform.position, splashRange);
            foreach (var hitCollide in hitColliders)
            {
                var enemy = hitCollide.GetComponent<Health>();
                if (enemy)
                {
                    var closestPoint = hitCollide.ClosestPoint(transform.position);
                    var distance = Vector3.Distance(closestPoint, transform.position);

                    var damagePercent = Mathf.InverseLerp(splashRange, 0, distance);
                    enemy.Damage((int)(damagePercent * damage));
                }
            }
        }
    }
}
