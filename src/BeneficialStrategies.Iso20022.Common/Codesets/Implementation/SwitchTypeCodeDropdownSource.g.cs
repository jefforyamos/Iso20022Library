﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SwitchTypeCode.  ISO2002 ID# _RQTCAQ2XEeStB9HSJRk0Qw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the switch either full or part for a given account.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISwitchTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_RQTCAQ2XEeStB9HSJRk0Qw")]
public partial class SwitchTypeCodeDropdownSource : EnumMetadataManager<SwitchTypeCode,ISwitchTypeCodeDropdownRow,SwitchTypeCodeDropdownRow>
{
    public SwitchTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SwitchTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
