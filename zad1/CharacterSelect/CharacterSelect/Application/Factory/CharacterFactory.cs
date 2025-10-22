using CharacterSelect.Domain.Character;
using CharacterSelect.Domain.Entity;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Application.Factory;

public static class CharacterFactory
{
    public static Character Create(CharacterClass cls, string? name)
    {
        return cls switch
        {
            CharacterClass.HanSuYeon => new HanSuYeon(name ?? "HanSuYeon"),
            CharacterClass.YuJoonHyeok    => new YuJoonHyeok(name ?? "YuJoonHyeok"),
            CharacterClass.Biyoo   => new Biyoo(name ?? "Biyoo"),
            CharacterClass.KimDokJa   => new KimDokJa(name ?? "KimDokJa"),
            _ => throw new ArgumentOutOfRangeException(nameof(cls), "Nieznana klasa postaci.")
        };
    }
}