using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public float timeBetweenSpawns;
    public float spawnDistance;
    public Particle[] particlePrefabs;
    float timeSinceLastSpawn;

    void FixedUpdate() {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= timeBetweenSpawns) {
            timeSinceLastSpawn -= timeBetweenSpawns;
            SpawnParticle();
        }
    }
    void SpawnParticle() {
        Particle prefab = particlePrefabs[Random.Range(0, particlePrefabs.Length)];
        Particle spawn = Instantiate<Particle>(prefab);
        spawn.transform.localPosition = Random.onUnitSphere * spawnDistance;
    }


}
