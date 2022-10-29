using UnityEngine;

public class Explosioncontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 1F);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
