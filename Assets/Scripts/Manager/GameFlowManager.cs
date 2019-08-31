using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlowManager : Singleton<GameFlowManager>
{

    #region ------------------------------------------Private Variables--------------------------------------------------------

    #endregion ----------------------------------------------------------------------------------------------------------------

    #region ------------------------------------------Public Variables---------------------------------------------------------
    public int currentScene = 0;
    #endregion ----------------------------------------------------------------------------------------------------------------

    #region ------------------------------------------Private Methods----------------------------------------------------------

    private void Start()
    {
        TriggerNextScene();
    }

    private void Update()
    {

    }

    private void Scene1Triggered()
    {
        //triggre these from the end point gameobject 2d cllision trigger
        //change cam postion fade in fade out , start things in scene etc
        Debug.Log("this is level 1");
        TriggerNextScene();
    }

    private void Scene2Triggered()
    {
        //for dialoge you can just add bubble game obj on hero and villan and pass a string to show and trigger bubble
        Debug.Log("this is level 2");
    }
    private void Scene3Triggered()
    {

    }
    private void Scene4Triggered()
    {

    }
    private void Scene5Triggered()
    {

    }
    private void Scene6Triggered()
    {

    }
    private void Scene7Triggered()
    {

    }

    #endregion ----------------------------------------------------------------------------------------------------------------

    #region ------------------------------------------Public Methods-----------------------------------------------------------    

    public void TriggerNextScene()
    {
        currentScene++;
        switch (currentScene)
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


    #endregion ----------------------------------------------------------------------------------------------------------------

}
