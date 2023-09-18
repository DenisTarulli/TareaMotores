using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameManager gameManager;
    [SerializeField] SoundEffectPlayer soundPlayer;
    private const string IS_VOID = "Void";


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 moveDir = new Vector3 (horizontalInput, 0f , verticalInput);        

        rb.AddForce(moveDir.normalized * force, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag(IS_VOID)) return;
        soundPlayer.AudioDeathVoid();
        gameManager.GameOver();
    }
}
