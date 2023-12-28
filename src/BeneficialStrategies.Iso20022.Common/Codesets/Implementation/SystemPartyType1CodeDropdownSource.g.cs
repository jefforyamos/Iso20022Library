﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SystemPartyType1Code.  ISO2002 ID# _kp6thO5NEeCisYr99QEiWA_-1109986721.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the party within a system.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISystemPartyType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kp6thO5NEeCisYr99QEiWA_-1109986721")]
public partial class SystemPartyType1CodeDropdownSource : EnumMetadataManager<SystemPartyType1Code,ISystemPartyType1CodeDropdownRow,SystemPartyType1CodeDropdownRow>
{
    public SystemPartyType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SystemPartyType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
