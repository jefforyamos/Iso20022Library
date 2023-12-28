﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Algorithm1Code.  ISO2002 ID# _TR6hjAEcEeCQm6a_G2yO_w_11890629.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of a cryptographic algorithm.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAlgorithm1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TR6hjAEcEeCQm6a_G2yO_w_11890629")]
public partial class Algorithm1CodeDropdownSource : EnumMetadataManager<Algorithm1Code,IAlgorithm1CodeDropdownRow,Algorithm1CodeDropdownRow>
{
    public Algorithm1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Algorithm1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
