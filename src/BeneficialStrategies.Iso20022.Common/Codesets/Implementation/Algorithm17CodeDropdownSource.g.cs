﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Algorithm17Code.  ISO2002 ID# _2ZJ5sdtjEee9e6xduATmQg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cryptographic algorithms for the MAC (Message Authentication Code).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAlgorithm17CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2ZJ5sdtjEee9e6xduATmQg")]
public partial class Algorithm17CodeDropdownSource : EnumMetadataManager<Algorithm17Code,IAlgorithm17CodeDropdownRow,Algorithm17CodeDropdownRow>
{
    public Algorithm17CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Algorithm17CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
