using System.Runtime.InteropServices;

using static Character;



var warriorBuilder = new WarriorBuilder();
var warriorDirector = new CharacterDirector(warriorBuilder);
warriorDirector.ConstructCharacter("Conan");
Character warrior = warriorBuilder.GetCharacter();
Console.WriteLine(warrior);


var HunterBuilder = new HunterBuilder();
var HunterDirector = new CharacterDirector(HunterBuilder);
HunterDirector.ConstructCharacter("Legolas");
Character hunter = HunterBuilder.GetCharacter();
Console.WriteLine(hunter);


var mageBuilder = new MageBuilder();
var mageDirector = new CharacterDirector(mageBuilder);
mageDirector.ConstructCharacter("Gandalf");
Character mage = mageBuilder.GetCharacter();
Console.WriteLine(mage);


public abstract class Character
{
    string? Name { get; set; }

    string? Class { get; set; }
    int Health { get; set; }

    int Attack { get; set; }

    public string? Equip { get; set; }
    public override string ToString()
    {
        return $"Name: {Name}, Class: {Class}, Health: {Health}, Attack: {Attack}, Equip: {Equip}";
    }




    public class Warrior : Character
    {
        public Warrior()
        {
            Class = "Warrior";
            Health = 150;
            Attack = 20;
            Equip = "Axe,Shield";

        }
    }
    public class Mage : Character
    {
        public Mage()
        {
            Class = "Mage";
            Health = 100;
            Attack = 700;
            Equip = "Staff";

        }
    }
    public class Hunter : Character
    {
        public Hunter()
        {
            Class = "Hunter";
            Health = 120;
            Attack = 70;
            Equip = "Bow";

        }
    }
    public interface ICharacterBuilder
    {
        void SetName(string name);
        Character GetCharacter();
    }


    public class WarriorBuilder : ICharacterBuilder
    {
        private Warrior warrior;

        public WarriorBuilder()
        {
            warrior = new Warrior();
        }

        public void SetName(string name)
        {
            warrior.Name = name;
        }

        public Character GetCharacter()
        {
            return warrior;
        }
    }

    public class HunterBuilder : ICharacterBuilder
    {
        private Hunter hunter;

        public HunterBuilder()
        {
            hunter = new Hunter();
        }

        public void SetName(string name)
        {
            hunter.Name = name;
        }

        public Character GetCharacter()
        {
            return hunter;
        }
    }

    public class MageBuilder : ICharacterBuilder
    {
        private Mage mage;

        public MageBuilder()
        {
            mage = new Mage();
        }

        public void SetName(string name)
        {
            mage.Name = name;
        }

        public Character GetCharacter()
        {
            return mage;
        }
    }


    public class CharacterDirector
    {
        private readonly ICharacterBuilder _builder;

        public CharacterDirector(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructCharacter(string name)
        {
            _builder.SetName(name);

        }
    }
}