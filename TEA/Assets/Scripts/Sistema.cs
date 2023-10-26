using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sistema : MonoBehaviour
{
    public Transform[] casas; // Array de posicoes das casas.
    public int casaAtual = 0; // Numero da casa atual.
    public int dado; // Valor do dado.
    public Transform[] dados; // Array de modelos de dados.
    public Transform spawn; // Ponto de spawn para o dado.
    public GameObject dadoAtual; // Dado atual no jogo.
    private bool isMoving = false; // Variavel de controle para o movimento do personagem.

    void Start()
    {
        // Inicializacao aqui, se necessario.
    }

    void Update()
    {
        // Verifica se a tecla "R" foi pressionada e nao esta ocorrendo um movimento.
        if (Input.GetKeyDown(KeyCode.R) && !isMoving)
        {
            dado = ObterResultadoDoDado(); // Obtem o resultado do dado.
            StartCoroutine(MoverPersonagem(dado)); // Move o personagem com base no resultado do dado.
        }

        if (casaAtual == 37)
        {
            // Lógica específica quando a casaAtual  37.
        }
    }

    int ObterResultadoDoDado()
    {
        return Random.Range(1, 6); // Gera um número aleatório entre 1 e 6 (exemplo).
    }

    IEnumerator MoverPersonagem(int numeroDeCasas)
    {
        isMoving = true;

        for (int i = 0; i < numeroDeCasas; i++)
        {
            if (casaAtual < casas.Length - 1)
            {
                casaAtual++;
                transform.position = casas[casaAtual].position; // Move o personagem para a próxima casa.
                yield return new WaitForSeconds(1f); // Pausa para simular o movimento. Ajuste conforme necessário.
            }
        }

        isMoving = false; // Finaliza o movimento.
    }

    void Jogar()
    {
        dado = Random.Range(1, 6); // Gera um valor aleatório para o dado.
        casaAtual = casaAtual + dado; // Atualiza a posição do personagem com base no resultado do dado.

        if (casaAtual < casas.Length)
        {
            transform.position = casas[casaAtual].position; // Move o personagem para a próxima casa.
            Spawn();
        }
        else
        {
            casaAtual = 37; // Define a casa atual como 37 (outra lógica específica).
            transform.position = casas[casaAtual].position; // Move o personagem para a casa 37.
            Spawn();
        }
    }

    void Spawn()
    {
        if (dadoAtual != null)
        {
            Destroy(dadoAtual); // Destroi o dado atual, se existir.
        }

        dadoAtual = Instantiate(dados[dado].gameObject, spawn.position, dados[dado].rotation); // Instancia um novo dado no spawn.
    }
}
