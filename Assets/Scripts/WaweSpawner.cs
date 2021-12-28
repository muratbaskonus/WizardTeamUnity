using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class WaweSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWawes = 2f;
    private float countdown = 3f;
    private int waveIndex = 0;

    public Text waveCountdownText;

    void Update()
    {
        if(countdown <= 0f && PlayerStats.lives > 0)
        {
            StartCoroutine(SpawnWawe());
            countdown = waveIndex + 2;
        }
        if(countdown >= 0)
        {
            countdown -= Time.deltaTime;
            waveCountdownText.text = Mathf.Round(countdown).ToString();
        }
        
    }

    IEnumerator SpawnWawe()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        } 
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab,spawnPoint.position,spawnPoint.rotation);
    }


}
