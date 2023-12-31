﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecurityCharacteristics1Code.  ISO2002 ID# _5upy8Eq1Eeenp6hmNprBHg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Security characteristics of the communication link.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecurityCharacteristics1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_5upy8Eq1Eeenp6hmNprBHg")]
public partial class SecurityCharacteristics1CodeDropdownSource : EnumMetadataManager<SecurityCharacteristics1Code,ISecurityCharacteristics1CodeDropdownRow,SecurityCharacteristics1CodeDropdownRow>
{
    public SecurityCharacteristics1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecurityCharacteristics1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
