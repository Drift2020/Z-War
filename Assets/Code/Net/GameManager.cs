using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Loby_meneger : MonoBehaviourPunCallbacks
{
    public GameObject PlayerPrefab;


    void Start()
    {
      PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(0,0,0),Quaternion.identity);
    }

    public void Leave()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        //when current user left game server
        ScreneManager.LoadScene(0);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.LogFormat("Player {0} entered room", newPlayer.NickName);
    }

     public override void OnPlayerLeftRoom(Player newPlayer)
    {
         Debug.LogFormat("Player {0} left room", newPlayer.NickName);
    }
   
}
