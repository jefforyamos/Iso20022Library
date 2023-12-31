﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReturnExcessCash1Code.  ISO2002 ID# _tL3U4ALoEeutW5-TpeYJhA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies information about excess cash.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReturnExcessCash1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tL3U4ALoEeutW5-TpeYJhA")]
public partial class ReturnExcessCash1CodeDropdownSource : EnumMetadataManager<ReturnExcessCash1Code,IReturnExcessCash1CodeDropdownRow,ReturnExcessCash1CodeDropdownRow>
{
    public ReturnExcessCash1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReturnExcessCash1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
