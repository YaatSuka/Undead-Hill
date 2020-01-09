using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySteer.Behaviors;

public class SpawnZombie : MonoBehaviour
{
    public GameObject zombiePrefab;
    public float spawnRatio = 10f;
    private GameObject player;
    private IEnumerator coroutine;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        coroutine = Spawn();
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 60f && spawnRatio > 3f) {
            spawnRatio -= 0.5f;
            timer = 0;
        }
    }

    private IEnumerator Spawn()
    {
        while (true) {
            yield return new WaitForSeconds(spawnRatio);
            GameObject zombie = Instantiate(zombiePrefab, transform.position, Quaternion.identity);
            zombie.GetComponent<SteerToFollow>().Target = player.transform;
        }
    }
}
