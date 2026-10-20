using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public float spawnInterval = 3.0f;

    // This keeps track of which item in the list is next
    private int currentIndex = 0;

    void Start()
    {
        InvokeRepeating("Spawn", 1.0f, spawnInterval);
    }

    void Spawn()
    {
        // Spawns the current object
        Instantiate(objectsToSpawn[currentIndex], transform.position, transform.rotation);

        // Moves to the next item, and loops back to 0 if it reaches the end of the list
        currentIndex++;
        if (currentIndex >= objectsToSpawn.Length)
        {
            currentIndex = 0;
        }
    }
}