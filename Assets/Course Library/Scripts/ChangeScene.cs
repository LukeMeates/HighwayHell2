using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int iLevelToLoad;
    public string sLevelToLoad;

    public bool useIntToLoadLevel = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
 
    }

    private void OnTriggerEnter(Collider collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if(collisionGameObject.name == "Player")
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        if(useIntToLoadLevel)
        {
            SceneManager.LoadScene(iLevelToLoad);
        }
        else
        {
            SceneManager.LoadScene(sLevelToLoad);
        }
    }
}