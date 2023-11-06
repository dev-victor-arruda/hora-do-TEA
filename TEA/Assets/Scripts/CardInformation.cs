using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public enum CardType
{
  CONCEPT,
  COMUNICATION,
  HABITS,
  ACCESSIBILITY,
  CURIOSITY,
  LUCK
}

public class CardInformation : MonoBehaviour
{
  public static string NameOfCard(CardType type)
  {
    switch (type)
    {
      case CardType.CONCEPT:
        return "Conceitos básicos";
      case CardType.COMUNICATION:
        return "Comunicação";
      case CardType.HABITS:
        return "Hábitos";
      case CardType.ACCESSIBILITY:
        return "Acessibilidade curricular";
      case CardType.CURIOSITY:
        return "Curiosidades";
      case CardType.LUCK:
        return "Sorte e azar";
    }

    throw InvalidCard();
  }

  public static CardType CardTypeByName(string name)
  {
    if (name.Equals("Conceitos básicos", StringComparison.OrdinalIgnoreCase))
    {
      return CardType.CONCEPT;
    }
    if (name.Equals("Comunicação", StringComparison.OrdinalIgnoreCase))
    {
      return CardType.COMUNICATION;
    }
    if (name.Equals("Hábitos", StringComparison.OrdinalIgnoreCase))
    {
      return CardType.HABITS;
    }
    if (name.Equals("Acessibilidade curricular", StringComparison.OrdinalIgnoreCase))
    {
      return CardType.ACCESSIBILITY;
    }
    if (name.Equals("Curiosidades", StringComparison.OrdinalIgnoreCase))
    {
      return CardType.CURIOSITY;
    }
    if (name.Equals("Sorte e azar", StringComparison.OrdinalIgnoreCase))
    {
      return CardType.LUCK;
    }

    throw InvalidCard();
  }

  public static Sprite BackgroundOfCardType(CardType type)
  {
    switch (type)
    {
      case CardType.CONCEPT:
        return Resources.Load<Sprite>("Cards/concept-background");
      case CardType.COMUNICATION:
        return Resources.Load<Sprite>("Cards/comunication-background");
      case CardType.CURIOSITY:
        return Resources.Load<Sprite>("Cards/curiosity-background");
      case CardType.LUCK:
        return Resources.Load<Sprite>("Cards/luck-background");
      case CardType.ACCESSIBILITY:
        return Resources.Load<Sprite>("Cards/accessibility-background");
      case CardType.HABITS:
        return Resources.Load<Sprite>("Cards/habits-background");
    }

    throw InvalidCard();
  }

  private static Exception InvalidCard() { return new Exception("Invalid card!"); }
}
