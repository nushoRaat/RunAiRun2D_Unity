using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class followEnemy : MonoBehaviour
{
   public float speed ;
   public Transform target;
   public float minDistance;



   void Update()
   {


        if(Vector2.Distance(transform.position, target.position) > minDistance)
        {
            
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed* Time.deltaTime);

        }
      


   }
}
