using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidbody;

    [SerializeField]
    private float velocidadeMovimento;

    void Update()
    {
        float horizontal = 0f;
        float vertical = 0f;

        // Verifica diretamente as teclas de movimento
        if (Input.GetKey(KeyCode.A))
            horizontal = -1f;
        else if (Input.GetKey(KeyCode.D))
            horizontal = 1f;

        if (Input.GetKey(KeyCode.W))
            vertical = 1f;
        else if (Input.GetKey(KeyCode.S))
            vertical = -1f;

        Vector2 direcao = new Vector2(horizontal, vertical);
        this.rigidbody.velocity = direcao.normalized * this.velocidadeMovimento;
    }
}