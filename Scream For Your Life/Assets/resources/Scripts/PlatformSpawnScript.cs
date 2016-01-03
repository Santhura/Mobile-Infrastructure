using UnityEngine;
using System.Collections;

public class PlatformSpawnScript : MonoBehaviour {

    public GameObject platformPrefab;               // prefab of a platform
    public Transform playerPos;                     // players position

    private float minX = -6, maxX = 7;

    private Vector2 playerOldPos;

    public bool canSpawn;

    private int amountSpawn;
    private float speed = 2;
    public float spawnTimer = 5;

    GameObject platform;
	// Use this for initialization
	void Start () {
        canSpawn = false;
        amountSpawn = 0;
        playerPos = GameObject.FindWithTag("Player").transform;
        
	}
	
	// Update is called once per frame
	void Update () {

        spawnTimer -= Time.deltaTime;
        if (!canSpawn)
        {
            amountSpawn = 0;
            if (spawnTimer > 0 && amountSpawn == 0)
            {
                canSpawn = true;
            }
        }
        else
        {
            if (amountSpawn < 1 && spawnTimer < 1 && canSpawn)
            {
                amountSpawn++;
                spawnTimer = 5;
                platform = Instantiate(platformPrefab, new Vector3(Random.Range(minX, maxX), playerPos.position.y + 15, 0), Quaternion.identity) as GameObject;
                canSpawn = false;
            }
        }
        if (platform != null)
        {
            platform.transform.Translate(Vector2.down * speed* Time.deltaTime);
            
        }
	}
}
