using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public Transform posTop;
    public Transform posBottom;
    public Transform posLeft;
    public Transform posRight;
    void Start()
    {
        InvokeRepeating("SpawnVerticalRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnHorizontalRandomAnimal", startDelay, spawnInterval);
    }
    private void SpawnVerticalRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float xPos = Random.Range(posLeft.position.x + 1, posRight.position.x - 1);
        float zPos = posTop.position.z;
        Vector3 spawnPos = new Vector3(xPos, 0, zPos);
        Instantiate(animalPrefabs[animalIndex],
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }

    private void SpawnHorizontalRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float xPos = posLeft.position.x;
        float zPos = Random.Range(posTop.position.z - 1, posBottom.position.z + 1);
        Quaternion rotationAnimal = Quaternion.Euler(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex],
            new Vector3(xPos, 0, zPos),
            rotationAnimal);
    }
}
