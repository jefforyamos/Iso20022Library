﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Frequency4Code.  ISO2002 ID# _TTG0YQEcEeCQm6a_G2yO_w_924003917.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Period unit between consecutive payments (for example day, month, year).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFrequency4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TTG0YQEcEeCQm6a_G2yO_w_924003917")]
public partial class Frequency4CodeDropdownSource : EnumMetadataManager<Frequency4Code,IFrequency4CodeDropdownRow,Frequency4CodeDropdownRow>
{
    public Frequency4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Frequency4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
