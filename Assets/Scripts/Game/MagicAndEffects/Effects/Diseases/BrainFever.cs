// Project:         Daggerfall Unity
// Copyright:       Copyright (C) 2009-2023 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using DaggerfallConnect.Arena2;

namespace DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects
{
    public class BrainFever : DiseaseEffect
    {
        Diseases diseaseType = Diseases.BrainFever;

        public override void SetProperties()
        {
            properties.Key = GetClassicDiseaseEffectKey(diseaseType);
            properties.ShowSpellIcon = false;
            classicDiseaseType = diseaseType;
            diseaseData = GetClassicDiseaseData(diseaseType);
        }

        public override TextFile.Token[] ContractedMessageTokens => GetClassicContractedMessageTokens(diseaseType);
    }
}
