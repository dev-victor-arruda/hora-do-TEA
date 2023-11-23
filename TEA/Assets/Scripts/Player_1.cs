using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
    public Transform[] casas; // Array de posições das casas.
    public int casaAtual = 0; // Índice da casa atual.
    private bool isMoving = false; // Variável de controle para evitar movimentos simultâneos.

    void Update()
    {
        if (!isMoving && DiceScript.diceNumber > 0)
        {
            MoverPersonagem(DiceScript.diceNumber); // Move o personagem com base no resultado do dado.
        }
    }  

    // Este método é chamado externamente para mover o personagem com base no valor do dado.
    private void MoverPersonagem(int diceNumber)
    {
        StartCoroutine(MovimentoPorCasas(diceNumber));
    }

    private IEnumerator MovimentoPorCasas(int numeroDeCasas)
    {
        isMoving = true;
        for (int i = 0; i < numeroDeCasas; i++)
        {
            if (casaAtual < casas.Length - 1)
            {
                casaAtual++; //Faz ele se movimentar pelo Tabuleiro
                transform.position = casas[casaAtual].position; // Move o personagem para a próxima casa.
                yield return new WaitForSeconds(1f); // Pausa para simular o movimento. Ajuste conforme necessário.
            }
        }

        // Tratamento para quando o jogador atinge o fim do tabuleiro.
        if (casaAtual >= casas.Length - 1)
        {
            casaAtual = casas.Length - 1;
        }

        //DiceScript.diceNumber = 0;
    }
}
