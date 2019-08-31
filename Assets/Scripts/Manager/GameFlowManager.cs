using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlowManager : Singleton<GameFlowManager>
{

    #region ------------------------------------------Private Variables--------------------------------------------------------

    #endregion ----------------------------------------------------------------------------------------------------------------

    #region ------------------------------------------Public Variables---------------------------------------------------------
    public int currentScene = 0;
    public bool freezeInput = false;
    public float cameraLerpTime = 2f;
    #endregion ----------------------------------------------------------------------------------------------------------------

    #region ------------------------------------------Private Methods----------------------------------------------------------

    private void Start()
    {
        Scene0Triggered();
    }


    public void Scene0Triggered()
    {
        //triggre these from the end point gameobject 2d cllision trigger
        //change cam postion fade in fade out , start things in scene etc
        Debug.Log("this is level 0");
        SceneManager.LoadScene(0);
    }

    public void Scene1Triggered()
    {
        //triggre these from the end point gameobject 2d cllision trigger
        //change cam postion fade in fade out , start things in scene etc
        Debug.Log("this is level 1");
        SceneManager.LoadScene(1);
    }
    private void Scene2Triggered()
    {
        //for dialoge you can just add bubble game obj on hero and villan and pass a string to show and trigger bubble
        Debug.Log("this is level 2");

        
        // Camera.main.transform.position += new Vector3(13f, 0, 0);
        ////
    }
    private void Scene3Triggered()
    {
        Debug.Log("this is level 3");
        SceneManager.LoadScene(2);

        //////////
    }
    private void Scene4Triggered()
    {
        StartCoroutine(CameraLerp(Camera.main.transform.position, new Vector3(13f, 0, -10)));

    }
    private void Scene5Triggered()
    {

    }
    private void Scene6Triggered()
    {
        SceneManager.LoadScene(3);

    }
    private void Scene7Triggered()
    {

    }

    private IEnumerator CameraLerp(Vector3 posA, Vector3 posB)
    {
        GameFlowManager.Instance.freezeInput = true;
        float delta = 1f / cameraLerpTime;
        float quad = 0;
        while (quad < 1)
        {
            quad += delta;
            Camera.main.transform.position = Vector3.Lerp(posA, posB, quad);
            Debug.Log("Quad = "+quad);
            yield return new WaitForFixedUpdate();
        }
        Debug.Log("Exit");
        GameFlowManager.Instance.freezeInput = false;
    }

    #endregion ----------------------------------------------------------------------------------------------------------------

    #region ------------------------------------------Public Methods-----------------------------------------------------------    

    public void TriggerNextScene()
    {
        GameFlowManager.Instance.currentScene++;
        switch (GameFlowManager.Instance.currentScene)
        {
            case 1:
                {
                    Scene1Triggered();
                }
                break;
            case 2:
                {
                    Scene2Triggered();
                }
                break;
            case 3:
                {
                    Scene3Triggered();
                }
                break;
            case 4:
                {
                    Scene4Triggered();
                }
                break;

        }

    }

}


#endregion ----------------------------------------------------------------------------------------------------------------