using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    public GameSettings settings;
    public int maxAsteroids;
    public GameObject asteroidParent;
    public float timeToStart;
    public float delay;
    public List<GameObject> asteroidPrefabs;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        maxAsteroids = settings.maxAsteroids;
        timeToStart = settings.delay;
        delay = settings.asteroidDelay;
        distance = settings.spawnDistance;
        Invoke("Delay", timeToStart);
    }

    public void Delay()
    {
        StartCoroutine(SpawnAsteroid());
    }

    public IEnumerator SpawnAsteroid()
    {
        while(SessionInfo.playing)
        {
            if(asteroidParent.transform.childCount < maxAsteroids)
            {
                Instantiate(asteroidPrefabs[(int)Random.Range(0, asteroidPrefabs.Count - 0.01f)], transform.position + (Random.onUnitSphere * distance), Quaternion.identity, asteroidParent.transform);
            }
            yield return new WaitForSecondsRealtime(delay);
        }
        
    }
}
