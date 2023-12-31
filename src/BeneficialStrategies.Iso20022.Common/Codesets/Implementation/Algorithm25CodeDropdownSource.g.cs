﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Algorithm25Code.  ISO2002 ID# _qQf90S_IEeugIJ3Gvoevmg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cryptographic algorithms for digital signatures.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAlgorithm25CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qQf90S_IEeugIJ3Gvoevmg")]
public partial class Algorithm25CodeDropdownSource : EnumMetadataManager<Algorithm25Code,IAlgorithm25CodeDropdownRow,Algorithm25CodeDropdownRow>
{
    public Algorithm25CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Algorithm25CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
