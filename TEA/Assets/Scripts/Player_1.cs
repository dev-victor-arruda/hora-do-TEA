using System.Collections;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
    // public Transform[] casas; // Removido, agora as posições das casas estão no GameManager.
    public int casaAtual = 0; // Índice da casa atual.
    public bool isMoving = false; // Agora público para que o GameManager possa acessá-lo.

   void Update()
{
    if (!isMoving && DiceScript.diceNumber > 0)
    {
        GameManager.Instance.MoverJogador(transform, DiceScript.diceNumber);
    }
}
    // Este método é chamado externamente para mover o personagem com base no valor do dado.
    public void MoverPersonagem(int diceNumber, Transform[] casas)
    {
        StartCoroutine(MovimentoPorCasas(diceNumber, casas));
    }

    private IEnumerator MovimentoPorCasas(int numeroDeCasas, Transform[] casas)
    {
        isMoving = true;
        for (int i = 0; i < numeroDeCasas; i++)
        {
            if (casaAtual < casas.Length - 1)
            {
                casaAtual++;
                transform.position = casas[casaAtual].position;
                yield return new WaitForSeconds(1f);
            }
        }

        if (casaAtual >= casas.Length - 1)
        {
            casaAtual = casas.Length - 1;
        }

        isMoving = false;
    }
}
