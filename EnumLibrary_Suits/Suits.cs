using System;

namespace EnumLibrary_Suits
{
    [Flags]
    public enum Suits
    {
        Spades = 1,
        Clubs = 2,
        Diamonds = 4,
        Hearts = 8,

        Red = Diamonds | Hearts,
        Black = Spades | Clubs
    }

    public enum Cards
    {
        
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Eleven = 11,
        Twelve = 12,
        King = 13,

        Ace = One | Eleven,
        
    }
    public enum Card_S
    {
        O = 1,
        X = 2, //cant use T for 2 as I want T to represent 10
        Y = 3,
        F = 4,
        I = 5,
        S = 6,
        V = 7,
        G = 8,
        N = 9,
        T = 10,
        E = 11,
        L = 12,
        K = 13,

        A = 1|11
    }
    public enum Suits2
    {
        S = 1,
        C = 2,
        D = 4,
        H = 8,
    }

    public enum Colours
    {
        Red = 1,
        Yellow = 2,
        Blue = 4,
        Indigo = 8,
        

        Purple = Red | Blue,
        Orange = Yellow | Red,
        Violet = Red | Blue,
        Green = Yellow | Blue
    }
}
