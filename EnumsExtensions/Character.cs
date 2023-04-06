namespace EnumsExtensions
{
    class Character
    {
       
        public string Nickname { get; set; }
        public CharacterType CharType { get; set; }

        void Check()
        {
            switch (CharType)
            {
                case CharacterType.Warrior:
                    break;
                case CharacterType.Mage:
                    break;
                case CharacterType.Archer:
                    break;
                case CharacterType.Monach:
                    break;
                case CharacterType.Shaman:
                    break;
                case CharacterType.Paladin:
                    break;
                case CharacterType.Rogue:
                    break;
                case CharacterType.Druid:
                    break;
                default:
                    break;
            }
        }
    }

    
}
