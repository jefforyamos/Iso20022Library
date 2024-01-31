﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionType1Code.  ISO2002 ID# _aQbsAdp-Ed-ak6NoX_4Aeg_-835357153.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aQbsAdp-Ed-ak6NoX_4Aeg_-835357153")]
public partial class OptionType1CodeDropdownSource : EnumMetadataManager<OptionType1Code,IOptionType1CodeDropdownRow,OptionType1CodeDropdownRow>
{
    public OptionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
