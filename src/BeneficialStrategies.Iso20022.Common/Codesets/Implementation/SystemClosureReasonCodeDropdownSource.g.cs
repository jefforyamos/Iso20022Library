﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SystemClosureReasonCode.  ISO2002 ID# _ZRQG-Np-Ed-ak6NoX_4Aeg_2007403378.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for system inactivity.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISystemClosureReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZRQG-Np-Ed-ak6NoX_4Aeg_2007403378")]
public partial class SystemClosureReasonCodeDropdownSource : EnumMetadataManager<SystemClosureReasonCode,ISystemClosureReasonCodeDropdownRow,SystemClosureReasonCodeDropdownRow>
{
    public SystemClosureReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SystemClosureReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
