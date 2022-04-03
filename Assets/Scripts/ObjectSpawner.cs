
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    private PlacementIndicator placementIndicator;

    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            _ = Instantiate(objectToSpawn,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

        }

    }

    public void Activate() {
        _ = Instantiate(objectToSpawn,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    
   
}
