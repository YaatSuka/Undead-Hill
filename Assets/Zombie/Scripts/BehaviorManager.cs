using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySteer.Behaviors;

public class BehaviorManager : MonoBehaviour
{
    public float runDistance = 15f;
    public float hitDistance = 2f;
    private float distance;
    private GameObject player;
    private Animator animator;
    private Biped bipedComponent;
    private float hitTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        animator = gameObject.GetComponent<Animator>();
        bipedComponent = gameObject.GetComponent<Biped>();
        if (player) {
            distance = Vector3.Distance(player.transform.position, transform.position);
        }
    }

    // Update is called once per frame
 void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= runDistance && distance > hitDistance) {
            animator.Play("Z_Run_InPlace");
            bipedComponent.MaxSpeed = 3;
        } else if (distance <= hitDistance) {
            animator.Play("Z_Attack");
            hitTimer -= Time.deltaTime;
            if(hitTimer <= 0){
            DealDamage();
            hitTimer = 1f;}
        } else {
            animator.Play("Z_Walk_InPlace");
            bipedComponent.MaxSpeed = 1;
        }

        //Debug.Log(distance);
    }

    private void DealDamage(){
        player.GetComponent<LifeManager>().hit = true;
    }
}
