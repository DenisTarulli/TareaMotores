using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] SoundEffectPlayer soundPlayer;
    private const string IS_PLAYER = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag(IS_PLAYER)) return;
        soundPlayer.AudioWin();
        gameManager.GameWin();
    }
}
