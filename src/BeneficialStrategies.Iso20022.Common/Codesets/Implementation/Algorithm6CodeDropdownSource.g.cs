﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Algorithm6Code.  ISO2002 ID# _tw6sIAiuEeKn9O5oyej_zw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cryptographic algorithms for encryptions with a symmetric cryptographic key.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAlgorithm6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tw6sIAiuEeKn9O5oyej_zw")]
public partial class Algorithm6CodeDropdownSource : EnumMetadataManager<Algorithm6Code,IAlgorithm6CodeDropdownRow,Algorithm6CodeDropdownRow>
{
    public Algorithm6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Algorithm6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
