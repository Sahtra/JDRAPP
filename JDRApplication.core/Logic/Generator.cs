using JDRApplication.data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDRApplication.core.Logic
{
    public static class Generator
    {

        public static CharacterEntity GenerateNew()
        {
            Random diceRoller = new Random();


            int TypeResult = diceRoller.Next(1, 20);
            int RaceResult = diceRoller.Next(1, 20);
            int ExtractionResult = diceRoller.Next(1, 20);
            int SecondTypeRoll = diceRoller.Next(1, 20);

            CharacterEntity ret = new CharacterEntity();
            // gestion du type
            if (TypeResult >= 12)
            {
                if (TypeResult >= 18)
                {
                    if (SecondTypeRoll >= 13)
                    {
                        ret.EnumType = CharacterType.DexteriteRelation;
                    }
                    else
                    {
                        ret.EnumType = CharacterType.ForceAura;
                    }
                }
                else
                {
                    if (TypeResult >= 15)
                    {
                        if (SecondTypeRoll >= 11)
                        {
                            ret.EnumType = CharacterType.AuraInstinct;
                        }
                        else
                        {
                            ret.EnumType = CharacterType.SavoirRelation;
                        }
                    }
                    else
                    {
                        if (SecondTypeRoll >= 18)
                        {
                            ret.EnumType = CharacterType.ForceSavoir;
                        }
                        else
                        {
                            ret.EnumType = CharacterType.DexteriteInstinct;
                        }
                    }
                }
            }
            else
            {
                if (TypeResult >= 9)
                {
                    if (SecondTypeRoll >= 11)
                    {
                        ret.EnumType = CharacterType.AuraPure;
                    }
                    else
                    {
                        ret.EnumType = CharacterType.RelationPure;
                    }
                }
                else if (TypeResult >= 5)
                {
                    if (SecondTypeRoll >= 11)
                    {
                        ret.EnumType = CharacterType.InstinctPure;
                    }
                    else
                    {
                        ret.EnumType = CharacterType.SavoirPure;
                    }
                }
                else
                {
                    if (SecondTypeRoll >= 11)
                    {
                        ret.EnumType = CharacterType.DexPure;
                    }
                    else
                    {
                        ret.EnumType = CharacterType.ForcePure;
                    }
                }
            }

            // stat
            switch (ret.EnumType)
            {
                case CharacterType.AuraInstinct:
                    ret.Physique = 30;
                    ret.Force = 1;
                    ret.Dexterite = 2;
                    ret.Mental = 60;
                    ret.Instinct = 4;
                    ret.Savoir = 2;
                    ret.Social = 60;
                    ret.Aura = 4;
                    ret.Relations = 2;
                    ret.Type = "Mage de soutiens";
                    break;
                case CharacterType.AuraPure:
                    ret.Social = 70;
                    ret.Aura = 5;
                    ret.Relations = 2;
                    ret.Physique = 40;
                    ret.Force = 2;
                    ret.Dexterite = 2;
                    ret.Mental = 40;
                    ret.Savoir = 2;
                    ret.Instinct = 2;
                    ret.Type = "Général / Capitaine / Agitateur";
                    break;
                case CharacterType.DexPure:
                    ret.Force = 70;
                    ret.Dexterite = 5;
                    ret.Force = 2;
                    ret.Mental = 40;
                    ret.Savoir = 2;
                    ret.Instinct = 2;
                    ret.Social = 40;
                    ret.Relations = 2;
                    ret.Aura = 2;
                    ret.Type = "Archer / lancier";
                    break;
                case CharacterType.DexteriteInstinct:
                    ret.Physique = 60;
                    ret.Dexterite = 4;
                    ret.Force = 2;
                    ret.Mental = 60;
                    ret.Instinct = 4;
                    ret.Savoir = 2;
                    ret.Social = 30;
                    ret.Aura = 2;
                    ret.Relations = 1;
                    ret.Type = "Chasseur / Vagabond / ranger / grand pieds ";
                    break;
                case CharacterType.DexteriteRelation:
                    ret.Physique = 60;
                    ret.Dexterite = 4;
                    ret.Force = 2;
                    ret.Mental = 30;
                    ret.Instinct = 2;
                    ret.Savoir = 1;
                    ret.Social = 60;
                    ret.Relations = 4;
                    ret.Aura = 2;
                    ret.Type = "Voleur";
                    break;
                case CharacterType.ForceAura:
                    ret.Physique = 60;
                    ret.Force = 4;
                    ret.Dexterite = 2;
                    ret.Mental = 30;
                    ret.Instinct = 2;
                    ret.Savoir = 1;
                    ret.Social = 60;
                    ret.Aura = 4;
                    ret.Relations = 2;
                    ret.Description = "Champion";
                    break;
                case CharacterType.ForceInstinct:
                    ret.Physique = 60;
                    ret.Force = 4;
                    ret.Dexterite = 2;
                    ret.Mental = 60;
                    ret.Instinct = 4;
                    ret.Savoir = 2;
                    ret.Social = 30;
                    ret.Relations = 1;
                    ret.Aura = 2;
                    ret.Relations = 1;
                    ret.Type = "Nomade / Héraut élémentaire";
                    break;
                case CharacterType.ForcePure:
                    ret.Physique = 70;
                    ret.Force = 5;
                    ret.Dexterite = 2;
                    ret.Mental = 40;
                    ret.Instinct = 3;
                    ret.Savoir = 1;
                    ret.Social = 40;
                    ret.Aura = 3;
                    ret.Relations = 1;
                    ret.Type = "Guerrier / Barbare";
                    break;
                case CharacterType.ForceSavoir:
                    ret.Physique = 60;
                    ret.Force = 4;
                    ret.Dexterite = 2;
                    ret.Mental = 60;
                    ret.Savoir = 4;
                    ret.Instinct = 2;
                    ret.Social = 30;
                    ret.Relations = 2;
                    ret.Aura = 1;
                    ret.Type = "Mage de bataille";
                    break;
                case CharacterType.InstinctPure:
                    ret.Physique = 40;
                    ret.Dexterite = 2;
                    ret.Force = 2;
                    ret.Mental = 70;
                    ret.Instinct = 5;
                    ret.Savoir = 2;
                    ret.Social = 40;
                    ret.Relations = 1;
                    ret.Aura = 3;
                    ret.Description = "Shaman";
                    break;
                case CharacterType.RelationPure:
                    ret.Physique = 40;
                    ret.Dexterite = 2;
                    ret.Force = 2;
                    ret.Mental = 40;
                    ret.Savoir = 3;
                    ret.Instinct = 1;
                    ret.Social = 70;
                    ret.Relations = 5;
                    ret.Aura = 2;
                    ret.Type = "Compte électeur / Manipulateur / Orateur";
                    break;
                case CharacterType.SavoirPure:
                    ret.Physique = 40;
                    ret.Dexterite = 3;
                    ret.Force = 1;
                    ret.Mental = 70;
                    ret.Savoir = 5;
                    ret.Instinct = 2;
                    ret.Social = 40;
                    ret.Aura = 2;
                    ret.Relations = 2;
                    ret.Type = "Mage citadin";
                    break;
                case CharacterType.SavoirRelation:
                    ret.Physique = 30;
                    ret.Dexterite = 2;
                    ret.Force = 1;
                    ret.Mental = 60;
                    ret.Savoir = 4;
                    ret.Instinct = 2;
                    ret.Social = 60;
                    ret.Aura = 2;
                    ret.Relations = 4;
                    ret.Type = "Mage de la cour";
                    break;
            }

            // Race 
            SetRaceFromDice(ref ret, RaceResult);

            // extraction
            if (ret.EnumType == CharacterType.SavoirPure
                || ret.EnumType == CharacterType.SavoirRelation
                || ret.EnumType == CharacterType.ForceSavoir)
            {
                if(ret.EnumRace == Race.HommeLezart)
                {
                    ret.EnumExtraction = Extraction.PrêtreMage;
                }
                else
                    ret.EnumExtraction = Extraction.Noble;
            }
            else
            {

                switch (ret.EnumRace)
                {
                    case Race.Citéslibre:
                    case Race.Empire:
                    case Race.Kislev:
                        if (ExtractionResult <= 10)
                        {
                            ret.EnumExtraction = Extraction.Citoyen;
                        }
                        else if (ExtractionResult <= 16)
                        {
                            ret.EnumExtraction = Extraction.Marchand;
                        }
                        else if (ExtractionResult <= 18)
                        {
                            ret.EnumExtraction = Extraction.Bourgeoisie;
                        }
                        else
                        {
                            ret.EnumExtraction = Extraction.Noble;
                        }
                        break;
                    case Race.Bretonien:
                        if (ExtractionResult >= 18)
                        {
                            ret.EnumExtraction = Extraction.Noble;
                        }
                        else
                        {
                            ret.EnumExtraction = Extraction.Paysans;
                        }
                        break;
                    case Race.NaindeClanIsolé:
                    case Race.NainKarakaKaraz:
                        if (ExtractionResult <= 10)
                        {
                            ret.EnumExtraction = Extraction.Citoyen;
                        }
                        else if (ExtractionResult <= 13)
                        {
                            ret.EnumExtraction = Extraction.Guerrier;
                        }
                        else if (ExtractionResult <= 16)
                        {
                            ret.EnumExtraction = Extraction.Ingénieur;
                        }
                        else if (ExtractionResult <= 18)
                        {
                            ret.EnumExtraction = Extraction.MaitreDesRunes;
                        }
                        else
                        {
                            ret.EnumExtraction = Extraction.Noble;
                        }
                        break;
                    case Race.ElfNnoir:
                        if (ExtractionResult <= 5)
                        {
                            ret.EnumExtraction = Extraction.Esclave;
                            if (ExtractionResult == 1)
                            {
                                SetRaceFromDice(ref ret, diceRoller.Next(1, 20), true);
                            }
                        }
                        else if (ExtractionResult <= 10)
                        {
                            ret.EnumExtraction = Extraction.Citoyen;
                        }
                        else if (ExtractionResult == 11)
                        {
                            ret.EnumExtraction = Extraction.MarchandDesclave;
                        }
                        else if (ExtractionResult == 12)
                        {
                            ret.EnumExtraction = Extraction.AdorateurDeSlanesh;
                        }
                        else if (ExtractionResult <= 14)
                        {
                            ret.EnumExtraction = Extraction.Corsaire;
                        }
                        else if (ExtractionResult <= 19)
                        {
                            ret.EnumExtraction = Extraction.SoldatArméeRégulière;
                        }
                        else
                        {
                            ret.EnumExtraction = Extraction.Noble;
                        }
                        break;
                    case Race.ElfSylvain:
                    case Race.HautElf:
                        if (ExtractionResult <= 10)
                        {
                            ret.EnumExtraction = Extraction.Citoyen;
                        }
                        else if (ExtractionResult <= 15)
                        {
                            ret.EnumExtraction = Extraction.SoldatArméeRégulière;
                        }
                        else if (ExtractionResult <= 17)
                        {
                            ret.EnumExtraction = Extraction.SoldatArméeIrrégulière;
                        }
                        else if (ExtractionResult <= 19)
                        {
                            if (ret.EnumRace == Race.HautElf)
                                ret.EnumExtraction = Extraction.Marchand;
                            else
                                ret.EnumExtraction = Extraction.Vagabond;
                        }
                        else
                        {
                            ret.EnumExtraction = Extraction.Noble;
                        }
                        break;
                    case Race.HommeLezart:
                        int rollCouve = diceRoller.Next(1, 20);
                        if (ret.EnumType == CharacterType.ForceAura || ret.EnumType == CharacterType.ForceInstinct || ret.EnumType == CharacterType.ForcePure || ret.EnumType == CharacterType.ForceSavoir)
                        {
                            if (rollCouve >= 18)
                            {
                                ret.EnumExtraction = Extraction.GuerrierSaurusSacré;
                            }
                            else
                            {
                                ret.EnumExtraction = Extraction.GuerrierSaurus;
                            }
                        }
                        else if (ret.EnumType == CharacterType.DexPure || ret.EnumType == CharacterType.DexteriteInstinct || ret.EnumType == CharacterType.DexteriteRelation)
                        {
                            if (rollCouve >= 18)
                            {
                                ret.EnumExtraction = Extraction.SkinkSacré;
                            }
                            else
                            {
                                ret.EnumExtraction = Extraction.Skink;
                            }
                        }
                        else if (ret.EnumType == CharacterType.SavoirPure || ret.EnumType == CharacterType.SavoirRelation)
                        {
                            ret.EnumExtraction = Extraction.PrêtreMage;
                        }
                        else
                        {
                            ret.EnumExtraction = Extraction.Skink;
                        }
                        break;
                    case Race.CompteVampire:
                        if(ExtractionResult <= 10)
                        {
                            ret.EnumExtraction = Extraction.SousFifre;
                        }else if(ExtractionResult <= 17)
                        {
                            ret.EnumExtraction = Extraction.Baron;
                        }else if (ExtractionResult <= 19)
                        {
                            ret.EnumExtraction = Extraction.ViCompte;
                        }
                        else
                        {
                            ret.EnumExtraction = Extraction.Compte;
                        } 
                        break;
                }
            }



            return ret;
        }


        private static void SetRaceFromDice(ref CharacterEntity ret, int dice, bool IsSlave = false)
        {
            Random diceRoller = new Random();
            switch (dice)
            {
                case 1:
                case 2:
                    ret.EnumRace = Race.Empire;
                    if (IsSlave)
                    {
                        ret.Race = "Esclave Impérial";
                    }
                    break;
                case 3:
                case 4:
                    ret.EnumRace = Race.Bretonien;
                    if (IsSlave)
                    {
                        ret.Race = "Esclave Bretonien";
                    }
                    break;
                case 5:
                    ret.EnumRace = Race.Kislev;
                    if (IsSlave)
                    {
                        ret.Race = "Esclave Kislev";
                    }
                    break;
                case 6:
                    ret.EnumRace = Race.Citéslibre;
                    int rollCitéLibre = diceRoller.Next(1, 3);

                    switch (rollCitéLibre)
                    {
                        case 1:
                            ret.Race = data.Data.CitésLibres.Estalie.ToString();
                            break;
                        case 2:
                            ret.Race = data.Data.CitésLibres.RoyaumesDuSud.ToString();
                            break;
                        case 3:
                            ret.Race = data.Data.CitésLibres.Thylée.ToString();
                            break;
                    }
                    if (IsSlave)
                        ret.Race = "Esclave" + ret.Race;
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                    ret.EnumRace = Race.NainKarakaKaraz;
                    if (IsSlave)
                        ret.Race = "Esclave Nain";
                    break;
                case 11:
                case 12:
                    ret.EnumRace = Race.NaindeClanIsolé;
                    if (IsSlave)
                        ret.Race = "Esclave Nain";
                    break;
                case 13:
                case 14:
                case 15:
                    ret.EnumRace = Race.HautElf;
                    int ElfRealmResult = diceRoller.Next(1, 10);
                    switch (ElfRealmResult)
                    {
                        case 1:
                            ret.Race = "Haut elf : " + data.Data.RoyaumesElf.Avelorn.ToString();
                            break;
                        case 2:
                            ret.Race = "Haut elf : " + data.Data.RoyaumesElf.Caledor.ToString();
                            break;
                        case 3:
                            ret.Race = "Haut elf : " + data.Data.RoyaumesElf.Chrace.ToString();
                            break;
                        case 4:
                            ret.Race = "Haut elf : " + data.Data.RoyaumesElf.Cothique.ToString();
                            break;
                        case 5:
                            ret.Race = "Haut elf : " + data.Data.RoyaumesElf.Eataine.ToString();
                            break;
                        case 6:
                            ret.Race = "Haut elf : " + data.Data.RoyaumesElf.Ellyrion.ToString();
                            break;
                        case 7:
                            ret.Race = "Haut elf : " + data.Data.RoyaumesElf.Nagarythe.ToString();
                            break;
                        case 8:
                            ret.Race = "Haut elf : " + data.Data.RoyaumesElf.Saphery.ToString();
                            break;
                        case 9:
                            ret.Race = "Haut elf : " + data.Data.RoyaumesElf.Tiranoc.ToString();
                            break;
                        case 10:
                            ret.Race = "Haut elf : " + data.Data.RoyaumesElf.Yvresse.ToString();
                            break;
                    }

                    if (IsSlave)
                        ret.Race = "Esclave" + ret.Race;
                    break;
                case 16:
                case 17:
                    ret.EnumRace = Race.ElfSylvain;
                    if (IsSlave)
                    {
                        ret.Race = "Esclave Elf Sylvain";
                    }
                    break;
                case 18:
                    ret.EnumRace = Race.HommeLezart;
                    if (IsSlave)
                        ret.Race = "Esclave Home-Lézard";
                    break;
                case 19:
                    ret.EnumRace = Race.CompteVampire;
                    if (IsSlave)
                        ret.Race = "Esclave Compte Vampire";
                    break;
                case 20:
                    ret.EnumRace = Race.ElfNnoir;
                    if (IsSlave)
                        ret.Race = "Esclave Elf noir";
                    break;
            }
        }


    }


}
