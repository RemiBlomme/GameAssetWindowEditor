using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameAsset.Runtime
{
    public class TraitsGabor
    {
        public ArmorTypeData[] _armorTypes;
        public ElementTypeData[] _elementTypes;
        public EquipmentTypeData[] _equipmentTypes;
        public SkillTypeData[] _skillTypes;
        public WeaponTypeData[] _weaponTypes;
        
       public enum States
        {
            Assom�,
            Garde,
            Immortel,
            Empoisonn�,
            Aveugl�,
            Muet,
            Enrag�,
            Confus,
            Fascin�,
            Endormi
        }
    }
}
