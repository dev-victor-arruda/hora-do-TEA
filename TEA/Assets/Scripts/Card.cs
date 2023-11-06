using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
  private readonly CardType type;
  private readonly string subtype;
  private readonly string question;
  private readonly string description;

  public Card(CardType _type, string _subtype, string _question, string _description)
  {
    type = _type;
    subtype = _subtype;
    question = _question;
    description = _description;
  }

  public CardType getType()
  {
    return type;
  }

  public string getSubtype()
  {
    return subtype;
  }

  public string getQuestion()
  {
    return question;
  }

  public string getDescription() 
  { 
    return description;
  }

  void Start()
  {
        
  }

  void Update()
  {
        
  }
}
