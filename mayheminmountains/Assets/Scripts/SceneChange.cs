using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int sceneBuildIndex;
    public bool isNextScene = true;

    [SerializeField]
    public SceneInfo sceneInfo;

    private void OnTriggerEnter2D(Collider2D col)
    {
        sceneInfo.isNextScene = isNextScene;
        print("Trigger Entered");

        if(col.tag == "Player")
        {
            print("Switching Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
