using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] SoundEffectPlayer soundPlayer;
    private const string IS_PLAYER = "Player";
    //private const string IS_GAMECONTROLLER = "Player";
    
    private void Start()
    {
        //gameManager = GameObject.FindGameObjectWithTag(IS_GAMECONTROLLER).GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {       
        if (!other.gameObject.CompareTag(IS_PLAYER)) return;
        soundPlayer.AudioCoin();
        gameManager.AddScore();
        Destroy(gameObject);
    }
}
