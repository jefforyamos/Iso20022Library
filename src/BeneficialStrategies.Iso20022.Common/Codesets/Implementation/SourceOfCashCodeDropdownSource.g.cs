﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SourceOfCashCode.  ISO2002 ID# _2DXCYDlEEealR6-8aQ15BA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the origin of cash.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISourceOfCashCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2DXCYDlEEealR6-8aQ15BA")]
public partial class SourceOfCashCodeDropdownSource : EnumMetadataManager<SourceOfCashCode,ISourceOfCashCodeDropdownRow,SourceOfCashCodeDropdownRow>
{
    public SourceOfCashCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SourceOfCashCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
