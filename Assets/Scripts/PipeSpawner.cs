using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float SpawnSpeed = 1;
    public GameObject placePrefabHere;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PS() {
        GameObject pipe = Instantiate(placePrefabHere);
        pipe.transform.position = new Vector2(gameObject.transform.position.x, Random.Range(-1f,3f));
    }

    IEnumerator SpawnPipe() {
        while (true) {
            yield return new WaitForSeconds(SpawnSpeed);
            PS();

        }
    }
}
