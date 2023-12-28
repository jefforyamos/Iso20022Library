﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Algorithm16Code.  ISO2002 ID# _na6Hods1Eee9e6xduATmQg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of a digest algorithm.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAlgorithm16CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_na6Hods1Eee9e6xduATmQg")]
public partial class Algorithm16CodeDropdownSource : EnumMetadataManager<Algorithm16Code,IAlgorithm16CodeDropdownRow,Algorithm16CodeDropdownRow>
{
    public Algorithm16CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Algorithm16CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
