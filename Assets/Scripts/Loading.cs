using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public GameObject loadingUI;
    public int sceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadScene_Coroutine(sceneNumber));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator LoadScene_Coroutine(int index)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);
        asyncOperation.allowSceneActivation = false;
        float progress = 0;
        while (!asyncOperation.isDone)
        {
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
            if(progress >=  0.9f) 
            {
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
