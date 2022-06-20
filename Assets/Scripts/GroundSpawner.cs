using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject placeGroundHere; 

    [SerializeField]
    public float waitsecond = 0.638f;   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnGround());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GS() {
        GameObject ground = Instantiate(placeGroundHere);
    }


    IEnumerator SpawnGround() {
        while (true) {
            yield return new WaitForSeconds(waitsecond);
            GS();
        }
    }
}
