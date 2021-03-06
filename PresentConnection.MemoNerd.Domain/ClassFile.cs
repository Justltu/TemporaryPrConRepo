﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentConnection.MemoNerd.Domain
{
    enum CardListType { Language, History, Picture, Formulas }; //TODO: Add more types if required

    public class Card
    {
        Word frontSide, backSide;
    }

    public class Word
    {
        string word;
        string language; //ISO codes
    }

    public class CardList
    {
        List<string> category;
        List<Card> cards;
    }

    public class User
    {
        string username;
        string password; //hashed password
        List<CardList> cardLists; //created or downloaded card lists
        List<Cart> carts; //active carts
    }

    public class Section
    {
        int size;
        List<Card> cards; //current cards
    }

    public class UserGroup 
    {
        string groupName;
        List<User> userList;
    }

    public class Cart
    {
        string cartName;
        CardListType cartType;
        List<CardList> activeCardLists; // Can use multiple CardLists in one cart if required
        Section level1, level2, level3, level4, memorized;
    }
}
