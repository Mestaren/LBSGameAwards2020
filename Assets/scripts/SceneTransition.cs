using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update

    public string sceneToLoad;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger) //ser till att bara en player kan trigga
        {
            SceneManager.LoadScene(sceneToLoad); // triggar scene byte
        }
    }
    
}
