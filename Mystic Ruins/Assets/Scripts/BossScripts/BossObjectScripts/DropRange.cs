using UnityEngine;

public class DropRange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        gameObject.GetComponent<ParticleSystem>().Play();
    }
}
