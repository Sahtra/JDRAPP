using System;
using System.Collections.Generic;
using System.Text;

namespace JDRApplication.data.Entities
{
    public class CharacterEntity : CharacterData
    {
        public CharacterType EnumType { get; set; }
    }
    

    public class CharacterData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Pv { get; set; }
        public int Mana { get; set; }
        public string Race { get; set; }
        public string Extraction { get; set; }
        public int Physique { get; set; }
        public int Force { get; set; }
        public int Dexterite { get; set; }
        public int Mental { get; set; }
        public int Savoir { get; set; }
        public int Instinct { get; set; }
        public int Social { get; set; }
        public int Relations { get; set; }
        public int Aura { get; set; }
        public string Description { get; set; }
    }

    public enum CharacterType
    {
        ForcePure, // Guerrier barabar
        DexPure, // Archer lancier
        SavoirPure, // Mage citadin
        InstinctPure, // Shaman
        RelationPure, // compte electeur manipulateur Orateur
        AuraPure, // Général Capitaine Agitateur
        DexteriteInstinct, // Chasseur vagabond archer grand pied
        ForceInstinct, // nomade, héraut élémentaire 
        ForceSavoir, // Mage de bataille 
        SavoirRelation, // Mage de la cour
        AuraInstinct, // Mage de soutiens 
        ForceAura, // Champion
        DexteriteRelation // voleur
    }
}
