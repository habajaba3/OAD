using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class HanSuYeon : Entity.Character
{
    public HanSuYeon(string name) : base(name, CharacterClass.HanSuYeon)
    {
        Health = 120;
        Strength = 90;
        Intelligence = 123;
        Agility = 465;
        Atack = 463;
        Look = 322;
    }
}