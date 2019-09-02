using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    public bool playing;
    public int maxAsteroids;
    public GameObject asteroidParent;
    public float delay;
    public List<GameObject> asteroidPrefabs;
    public int distance;

    // Start is called before the first frame update
    void Start()
    {
        playing = true;
        StartCoroutine(SpawnAsteroid());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnAsteroid()
    {
        while(playing)
        {
            if(asteroidParent.transform.childCount < maxAsteroids)
            {
                Instantiate(asteroidPrefabs[(int)Random.Range(0, asteroidPrefabs.Count - 0.01f)], transform.position + (Random.onUnitSphere * distance), Quaternion.identity, asteroidParent.transform);
            }
            yield return new WaitForSecondsRealtime(delay);
        }
        
    }
}
