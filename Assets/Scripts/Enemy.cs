using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private const string IS_PLAYER = "Player";
    [SerializeField] private GameManager gameManager;
    [SerializeField] SoundEffectPlayer soundPlayer;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag(IS_PLAYER)) return;
        soundPlayer.AudioDeathEnemy();
        gameManager.GameOver();
    }
}
