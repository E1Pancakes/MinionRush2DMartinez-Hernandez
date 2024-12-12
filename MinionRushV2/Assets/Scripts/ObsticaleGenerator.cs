using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticaleGenerator : MonoBehaviour
{
    public GameObject Bench;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;

    public float SpeedMultiplier;
    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = MinSpeed;
        generateBench(); 
    }
    public void GenerateNextBenchWithGap()
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateBench", randomWait);
    }
    // Update is called once per frame
    public void generateBench()
    {
        GameObject BenchIns = Instantiate(Bench, transform.position, transform.rotation);

        BenchIns.GetComponent<BenchScript>().obsticaleGenerator = this;
    }

    void Update()
    {
        if(currentSpeed< MaxSpeed)
        {
            currentSpeed += SpeedMultiplier;
        }
    }
}
