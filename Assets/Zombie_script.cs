using UnityEngine;
using System.Collections;

public class Zombie_script : MonoBehaviour {
	Transform Player;
    SphereCollider sphere;
	NavMeshAgent nav;
    Animator zombie;
	// Use this for initialization
	void Awake () 
	{
		Player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent<NavMeshAgent> ();
        sphere = GetComponent<SphereCollider>();
        zombie = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		nav.SetDestination (Player.position);
      
	}
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            zombie.Play("attack", -1);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            zombie.Play("walk", -1);
        }
    }
}
