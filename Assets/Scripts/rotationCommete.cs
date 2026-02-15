using UnityEngine;

public class rotationCommete : MonoBehaviour
{
    float randomRotation;
        
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomRotation = Random.Range(1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(randomRotation > 1.5)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 45f);
        }
        
    }
}
