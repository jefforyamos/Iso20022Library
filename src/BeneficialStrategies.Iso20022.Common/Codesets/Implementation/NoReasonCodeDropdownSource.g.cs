﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NoReasonCode.  ISO2002 ID# _aNmad9p-Ed-ak6NoX_4Aeg_1937897714.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies that there is no reason available.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INoReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aNmad9p-Ed-ak6NoX_4Aeg_1937897714")]
public partial class NoReasonCodeDropdownSource : EnumMetadataManager<NoReasonCode,INoReasonCodeDropdownRow,NoReasonCodeDropdownRow>
{
    public NoReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new NoReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}