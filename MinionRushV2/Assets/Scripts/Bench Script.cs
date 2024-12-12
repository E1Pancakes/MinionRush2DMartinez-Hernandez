using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenchScript : MonoBehaviour
{
    public ObsticaleGenerator obsticaleGenerator;
   
    void Update()
    {
        transform.Translate(Vector2.left * obsticaleGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("nextLine"))
        {
            obsticaleGenerator.GenerateNextBenchWithGap();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}
