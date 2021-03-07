using JDRApplication.data.Entities;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JDRApplication.core.viewmodels
{
    public class GenerateViewModel : BaseViewModel
    {
        public string LabelCreateCharacter => "Création d'un nouveau personnage";
        public string LabelNom => "Nom";
        CharacterEntity newCharacter = null;


        public bool VisibilityGenerated => newCharacter == null;



        private bool keepRace, keepType, keepExtraction;
        public bool KeepRace
        {
            get => keepRace;
            set => SetProperty(ref keepRace, value);
        }
        public bool KeepType
        {
            get => keepType;
            set => SetProperty(ref keepType, value);
        }
        public bool KeepExtraction
        {
            get => keepExtraction;
            set => SetProperty(ref keepExtraction, value);
        }

        public string Nom
        {
            get => nom;
            set => SetProperty(ref nom, value);
        }
        private string nom;
        public string LabelRace
        {
            get => labelRace;
            set => SetProperty(ref labelRace, value);
        }
        private string labelRace;
        public string LabelType
        {
            get => labelType;
            set => SetProperty(ref labelType, value);
        }
        private string labelType;
        public string LabelExtraction
        {
            get => labelExtraction;
            set => SetProperty(ref labelExtraction, value);
        }
        private string labelExtraction;

        public string DisplayPhysique => Physique.ToString();
        private int Physique
        {
            get
            {
                return newCharacter == null ? 0 : newCharacter.Physique;
            }
        }
        public string DisplayForce => Force.ToString();
        private int Force
        {
            get
            {
                return newCharacter == null ? 0 : newCharacter.Force;
            }
        }
        public string DisplayAgilite => Agilite.ToString();
        private int Agilite
        {
            get
            {
                return newCharacter == null ? 0 : newCharacter.Dexterite;
            }
        }
        public string DisplayMental => Mental.ToString();
        private int Mental
        {
            get
            {
                return newCharacter == null ? 0 : newCharacter.Mental;
            }
        }
        public string DisplaySavoir => Savoir.ToString();
        private int Savoir
        {
            get
            {
                return newCharacter == null ? 0 : newCharacter.Savoir;
            }
        }
        public string DisplayInstinct => Instinct.ToString();
        private int Instinct
        {
            get
            {
                return newCharacter == null ? 0 : newCharacter.Instinct;
            }
        }
        public string DisplaySocial => Social.ToString();
        private int Social
        {
            get
            {
                return newCharacter == null ? 0 : newCharacter.Social;
            }
        }
        public string DisplayRelation => Relation.ToString();
        private int Relation
        {
            get
            {
                return newCharacter == null ? 0 : newCharacter.Relations;
            }
        }
        public string DisplayAura => Aura.ToString();
        private int Aura
        {
            get
            {
                return newCharacter == null ? 0 : newCharacter.Aura;
            }
        }
        private int pv
        {
            get
            {
                return newCharacter == null ? 0 : newCharacter.Pv;
            }
        }
        public string DisplayPV => pv.ToString();
        public string DisplayMana => mana.ToString();
        private int mana
        {
            get
            {
                return newCharacter == null ? 0 : newCharacter.Mana;
            }
        }
        public string LabelDescription => "Description";
        private string description;
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }



        private MvxAsyncCommand generateCommand, saveCharacterCommand, backCommand, switchPvManaCommand;
        public MvxAsyncCommand GenerateCommand => generateCommand ?? (generateCommand = new MvxAsyncCommand(GenerateTask));
        public MvxAsyncCommand SaveCharacterCommand => saveCharacterCommand ?? (saveCharacterCommand = new MvxAsyncCommand(SaveTask));
        public MvxAsyncCommand BackCommand => backCommand ?? (backCommand = new MvxAsyncCommand(BackTask));
        public MvxAsyncCommand SwitchPvManaCommand => switchPvManaCommand ?? (switchPvManaCommand = new MvxAsyncCommand(SwitchPvManaTask));

        private Task SwitchPvManaTask()
        {
            if (newCharacter == null)
                return Task.CompletedTask;
            else
            {
                int i = newCharacter.Pv;
                newCharacter.Pv = newCharacter.Mana;
                newCharacter.Mana = i;
                RaisePropertyChanged(nameof(DisplayPV));
                RaisePropertyChanged(nameof(DisplayMana));
                return Task.CompletedTask;
            }
        }
        private async Task SaveTask()
        {

        }
        private async Task BackTask()
        {
            await navigationService.Close(this);
        }
        private Task GenerateTask()
        {
            if(newCharacter == null)
                newCharacter = Logic.Generator.GenerateNew();
            else
            {
                var rerol = Logic.Generator.GenerateNew();
                if (!KeepExtraction)
                {
                    LabelExtraction = "Extraction : " + rerol.Extraction;
                }
                if (!KeepRace)
                {
                    LabelRace = "Race : " + rerol.Race;
                }
                if (!KeepType)
                {
                    newCharacter.Type = rerol.Type;
                    newCharacter.EnumType = rerol.EnumType;
                    newCharacter.Physique = rerol.Physique;
                    newCharacter.Force = rerol.Force;
                    newCharacter.Dexterite = rerol.Dexterite;
                    newCharacter.Mental = rerol.Mental;
                    newCharacter.Savoir = rerol.Savoir;
                    newCharacter.Instinct = rerol.Instinct;
                    newCharacter.Social = rerol.Social;
                    newCharacter.Relations = rerol.Relations;
                    newCharacter.Aura = rerol.Aura;
                }
            }
            return Task.CompletedTask;
        }

        public GenerateViewModel(IMvxNavigationService nav) : base(nav)
        {
            labelRace = "Race : ";
            labelType = "Type : ";
            labelExtraction = "Extraction : ";
        }
    }
}
