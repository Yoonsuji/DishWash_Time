using UnityEngine;

public class SceneTrigger : MonoBehaviour
{
    public float loadProbability = 0.5f;
    public GameObject sceneLoader;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Random.value < loadProbability)
            {
                sceneLoader.SetActive(true);
            }
        }
    }
}
