using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using System;

public class CardsContainer : MonoBehaviour
{
  private static List<Card> cards = new List<Card>();
  private int numberOfCardsRead = 0;

  void Awake()
  {
    TextAsset cardFile = Resources.Load<TextAsset>("Cards/database");
    foreach (string card in cardFile.text.Split('\n'))
    {
      string[] data = card.Split('|');

      numberOfCardsRead++;
      cards.Add(ProcessNewCard(data));
    }
  }

  private Card ProcessNewCard(string[] dataOfNewCard)
  {
    if (dataOfNewCard.Length != 4)
    {
      throw new Exception("Invalid card was read in 'cards.txt'");
    }

    CardType type = CardInformation.CardTypeByName(dataOfNewCard[0].Trim());
    string subtype = dataOfNewCard[1].Trim();
    string question = dataOfNewCard[2].Trim();
    string description = dataOfNewCard[3].Trim();

    return new Card(type, subtype, question, description);
  }

  public static Card At(int position)
  {
    return cards[position - 1];
  }

  public static int Length()
  {
    return cards.Count;
  }

}
