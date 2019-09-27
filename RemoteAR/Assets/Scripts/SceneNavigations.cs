using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigations : MonoBehaviour
{

    public Transform Loader;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LaunchSceneSelectUserType()
    {
        StartCoroutine(LoadYourAsyncScene("SelectUserType"));
    }

    public void LaunchSceneExpert()
    {
        StartCoroutine(LoadYourAsyncScene("ExpertScene"));
    }

    public void LaunchSceneTraineeScene()
    {
        StartCoroutine(LoadYourAsyncScene("TraineeScene"));
    }


    IEnumerator LoadYourAsyncScene( string SceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneName);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            Debug.Log("pp");
            Loader.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
            yield return null;
        }
    }
}
