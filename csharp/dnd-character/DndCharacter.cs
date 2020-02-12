using System;
using System.Linq;
using System.Collections.Generic;

public class DndCharacter
{
    public DndCharacter(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
    {
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
        Hitpoints = 10 + Modifier(constitution);
    }

    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public int Hitpoints { get; }

    public static int Modifier(int score)
    {
        return (int)Math.Floor((double)(score - 10) / 2);
    }

    public static int Ability() 
    {
        var rolls = new List<int>();
        var random = new Random();
        for(int i = 0; i < 4; i++)
        {
            rolls.Add(random.Next(1, 7));
        }
        rolls.Remove(rolls.Min());
        return rolls.Sum();
    }

    public static DndCharacter Generate()
    {
        return new DndCharacter(Ability(), Ability(), Ability(), Ability(), Ability(), Ability());
    }
}
