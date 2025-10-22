using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Biyoo : Entity.Character
{
    public Biyoo(string name) : base(name, CharacterClass.Biyoo)
    {
        Health = 95;
        Strength = 327;
        Intelligence = 224;
        Agility = 15;
        Atack = 454;
        Look = 643;
    }
}