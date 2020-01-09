using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySteer.Behaviors;

public class SpawnZombie : MonoBehaviour
{
    public GameObject zombiePrefab;
    private GameObject player;
    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        coroutine = Spawn(5.0f);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Spawn(float waitTime)
    {
        while (true) {
            yield return new WaitForSeconds(waitTime);
            GameObject zombie = Instantiate(zombiePrefab, transform.position, Quaternion.identity);
            zombie.GetComponent<SteerToFollow>().Target = player.transform;
        }
    }
}
