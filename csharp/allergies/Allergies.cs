using System;
using System.Collections.Generic;

[Flags]
public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    public int mask;
    public Allergies(int mask) => this.mask = mask;
    
    public bool IsAllergicTo(Allergen allergen) 
    {
        return (mask & (int)allergen) == (int) allergen;
    }
    public Allergen[] List()
    {
        var result = new List<Allergen>();
        foreach(Allergen x in Enum.GetValues(typeof(Allergen)))
        {
            if(IsAllergicTo(x))
            {
               result.Add(x); 
            }
        }
        return result.ToArray();
    }

}