﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PINFormat2Code.  ISO2002 ID# _B3AosAvFEeKzJ69IWwzB9Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// PIN (Personal Identification Number) format used before encryption.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPINFormat2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_B3AosAvFEeKzJ69IWwzB9Q")]
public partial class PINFormat2CodeDropdownSource : EnumMetadataManager<PINFormat2Code,IPINFormat2CodeDropdownRow,PINFormat2CodeDropdownRow>
{
    public PINFormat2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PINFormat2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
