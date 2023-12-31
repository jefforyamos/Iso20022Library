﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SystemClosureReason1Code.  ISO2002 ID# _ZRQG8tp-Ed-ak6NoX_4Aeg_2007403394.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for system inactivity.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISystemClosureReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZRQG8tp-Ed-ak6NoX_4Aeg_2007403394")]
public partial class SystemClosureReason1CodeDropdownSource : EnumMetadataManager<SystemClosureReason1Code,ISystemClosureReason1CodeDropdownRow,SystemClosureReason1CodeDropdownRow>
{
    public SystemClosureReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SystemClosureReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
