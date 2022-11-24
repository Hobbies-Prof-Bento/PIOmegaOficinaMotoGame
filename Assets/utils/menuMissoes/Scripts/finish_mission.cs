using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class finish_mission : MonoBehaviour
{

    [SerializeField] private GameObject painelFinishMissions;

    

    public void finishMission(){
        painelFinishMissions.SetActive(false);
    }   
}
