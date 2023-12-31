﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Algorithm4Code.  ISO2002 ID# _wCmXsAiqEeKn9O5oyej_zw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cryptographic algorithms for digital signatures.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAlgorithm4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_wCmXsAiqEeKn9O5oyej_zw")]
public partial class Algorithm4CodeDropdownSource : EnumMetadataManager<Algorithm4Code,IAlgorithm4CodeDropdownRow,Algorithm4CodeDropdownRow>
{
    public Algorithm4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Algorithm4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
