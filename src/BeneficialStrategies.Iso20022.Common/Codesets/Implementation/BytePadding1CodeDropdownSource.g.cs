﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BytePadding1Code.  ISO2002 ID# _zBfYoGi9EeS87LmvcA55sg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBytePadding1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zBfYoGi9EeS87LmvcA55sg")]
public partial class BytePadding1CodeDropdownSource : EnumMetadataManager<BytePadding1Code,IBytePadding1CodeDropdownRow,BytePadding1CodeDropdownRow>
{
    public BytePadding1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BytePadding1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
