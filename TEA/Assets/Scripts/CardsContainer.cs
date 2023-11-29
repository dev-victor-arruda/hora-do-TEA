using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsContainer : MonoBehaviour
{
  private static List<Card> cards = new List<Card>();  

  public static Card At(int position)
  {
    return cards[position];
  }

  void Awake()
  {
    AddConceptCards();
    AddComunicationCards();
    AddBehaviorCards();
    AddResourcesCards();
    AddStrategyCards();
    AddLuckCards();
  }

  private void AddConceptCards()
  {
    cards.Add(new Card(1, CardType.CONCEPT, "NULL"));
  }

  private void AddComunicationCards()
  {
    cards.Add(new Card(2, CardType.COMUNICATION, "NULL"));
  }

  private void AddBehaviorCards()
  {
    cards.Add(new Card(3, CardType.BEHAVIOR, "NULL"));
  }

  private void AddResourcesCards()
  {
    cards.Add(new Card(4, CardType.RESOURCES, "NULL"));
  }

  private void AddStrategyCards()
  {
    cards.Add(new Card(5, CardType.STRATEGY, "NULL"));
  }

  private void AddLuckCards()
  {
    cards.Add(new Card(6, CardType.CURIOSITY, "NULL"));
  }
}
