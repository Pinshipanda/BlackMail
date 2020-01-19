using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NextLevel());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(17);
        SceneManager.LoadScene(1);
    }
}
