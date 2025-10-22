using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class KimDokJa : Entity.Character
{
    public KimDokJa(string name) : base(name, CharacterClass.KimDokJa)
    {
        Health = 100;
        Strength = 286;
        Intelligence = 100;
        Agility = 457;
        Atack = 356;
        Look = 458;
    }
}