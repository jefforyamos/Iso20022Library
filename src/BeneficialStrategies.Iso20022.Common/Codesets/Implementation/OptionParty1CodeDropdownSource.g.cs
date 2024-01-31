﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionParty1Code.  ISO2002 ID# _aP_AEtp-Ed-ak6NoX_4Aeg_2105414994.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if a trade party is a buyer or a seller.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionParty1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aP_AEtp-Ed-ak6NoX_4Aeg_2105414994")]
public partial class OptionParty1CodeDropdownSource : EnumMetadataManager<OptionParty1Code,IOptionParty1CodeDropdownRow,OptionParty1CodeDropdownRow>
{
    public OptionParty1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionParty1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
