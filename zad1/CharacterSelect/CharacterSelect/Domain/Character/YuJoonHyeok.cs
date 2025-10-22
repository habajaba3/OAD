using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class YuJoonHyeok: Entity.Character
{
    public YuJoonHyeok(string name) : base(name, CharacterClass.YuJoonHyeok)
    {
        Health = 90;
        Strength = 145;
        Intelligence = 256;
        Agility = 245;
        Atack = 542;
        Look = 425;

    }
}