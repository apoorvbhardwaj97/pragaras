using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    #region ------------------------------------------Private Variables--------------------------------------------------------
    [SerializeField] private Transform player = null;
    [SerializeField] private Transform nextSpawn = null;
    #endregion ----------------------------------------------------------------------------------------------------------------

    #region ------------------------------------------Public Variables---------------------------------------------------------

    #endregion ----------------------------------------------------------------------------------------------------------------

    #region ------------------------------------------Private Methods----------------------------------------------------------

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            GameFlowManager.Instance.TriggerNextScene();
            gameObject.SetActive(false);
        }
        if (player != null)
        {
            player.transform.position = nextSpawn.position;
        }
    }

    #endregion ----------------------------------------------------------------------------------------------------------------

    #region ------------------------------------------Public Methods-----------------------------------------------------------    

    #endregion ----------------------------------------------------------------------------------------------------------------

}
