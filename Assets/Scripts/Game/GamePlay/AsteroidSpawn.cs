using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour {

	// Use this for initialization
    public GameObject asteroidPrefab;
    public Transform[] bounds;
    public float spawnTime;
    private List<GameObject> _listAsteroid;

	void Start () {
        _listAsteroid = new List<GameObject>();
        StartSpawn();
    }
	
	// Update is called once per frame
	void Update () {
	}

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            Vector2 vo = new Vector2(Random.Range(bounds[0].position.x, bounds[2].position.x), Random.Range(bounds[0].position.y, bounds[2].position.y));
            GameObject newAsteroid = Instantiate(asteroidPrefab, vo, Quaternion.identity);
            _listAsteroid.Add(newAsteroid);
        }
    }

    public void StartSpawn()
    {
        StartCoroutine("Spawn");
    }

    public void StopSpawn()
    {
        StopCoroutine("Spawn");
    }
    public void DestroyAllAsteroid()
    {
        foreach ( GameObject ast in _listAsteroid)
        {
            Destroy(ast);
        }
        PurgeList();
    }

    public void PurgeList()
    {
        _listAsteroid = _listAsteroid.Where(item => item != null).ToList();
    }
}
