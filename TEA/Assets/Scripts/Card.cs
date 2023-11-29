using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
  private readonly int id;
  private readonly CardType type;
  private readonly string description;

  public Card(int _id, CardType type, string _description)
  {
    id = _id;
    this.type = type;
    description = _description;
  }

  public string getType()
  {
    return CardInformation.NameOfCard(type);
  }

  public string getDescription() 
  { 
    return description;
  }

  public int getId() 
  { 
    return id;
  }

  void Start()
  {
        
  }

  void Update()
  {
        
  }
}
