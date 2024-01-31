﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AmountType2Code.  ISO2002 ID# _sPnN4H03EeGlwNeVP9egyg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the amount type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAmountType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_sPnN4H03EeGlwNeVP9egyg")]
public partial class AmountType2CodeDropdownSource : EnumMetadataManager<AmountType2Code,IAmountType2CodeDropdownRow,AmountType2CodeDropdownRow>
{
    public AmountType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AmountType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
