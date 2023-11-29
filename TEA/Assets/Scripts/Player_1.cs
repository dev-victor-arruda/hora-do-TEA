using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
  public Transform[] casas; //Array de posições das casas no tabuleiro.
  public int casaAtual = 0; //Índice da casa atual em que o jogador está.


  public void MoverPersonagem(int diceNumber) //Método público chamado para mover o personagem com base no valor do dado.
  {
    StartCoroutine(MovimentoPorCasas(diceNumber));  //Inicia uma coroutine para realizar o movimento do personagem.
  }

  
  private IEnumerator MovimentoPorCasas(int numeroDeCasas) //Coroutine que controla o movimento do personagem através das casas.
  {
    
    for (int i = 0; i < numeroDeCasas; i++) //Loop para percorrer o número de casas especificado pelo dado.
    {
     
      if (casaAtual < casas.Length - 1) //Verifica se o jogador não atingiu o final do tabuleiro.
      {
        
        casaAtual++;// Incrementa o índice da casa atual, movendo o jogador para a próxima casa.
        transform.position = casas[casaAtual].position; // Move o personagem para a próxima casa.
        yield return new WaitForSeconds(1f); // Pausa para simular o movimento. Ajustar conforme necessário.
      }
    }

    // Tratamento para quando o jogador atinge o fim do tabuleiro.
    if (casaAtual >= casas.Length - 1)
    {
      casaAtual = casas.Length - 1;
    }
  }
}
