using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefab;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;

    [SerializeField] private float spawnInterval = 2.0f; // Интервал спавна в секундах

    private void Start()
    {
        // Запускаем корутину для автоматического спавна
        StartCoroutine(SpawnAnimals());
    }

    private IEnumerator SpawnAnimals()
    {
        while (true) // Бесконечный цикл для постоянного спавна
        {
            SpawnAnimal();
            yield return new WaitForSeconds(spawnInterval); // Ждём заданный интервал
        }
    }

    private void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(randomX, 0, spawnPosZ);

        Instantiate(animalPrefab[animalIndex], 
            spawnPos,
            animalPrefab[animalIndex].transform.rotation);
    }
}
