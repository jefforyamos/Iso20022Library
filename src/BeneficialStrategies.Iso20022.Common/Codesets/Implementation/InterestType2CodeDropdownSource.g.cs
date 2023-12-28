﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InterestType2Code.  ISO2002 ID# __215cNojEeC60axPepSq7g_96023160.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates if the deal price is excluding or including the accrued interest.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInterestType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__215cNojEeC60axPepSq7g_96023160")]
public partial class InterestType2CodeDropdownSource : EnumMetadataManager<InterestType2Code,IInterestType2CodeDropdownRow,InterestType2CodeDropdownRow>
{
    public InterestType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InterestType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
