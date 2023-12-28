﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecurityCharacteristicsCode.  ISO2002 ID# _X8tNUEqzEeenp6hmNprBHg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Security characteristics of the communication link between a cardholder and a card acceptor.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecurityCharacteristicsCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_X8tNUEqzEeenp6hmNprBHg")]
public partial class SecurityCharacteristicsCodeDropdownSource : EnumMetadataManager<SecurityCharacteristicsCode,ISecurityCharacteristicsCodeDropdownRow,SecurityCharacteristicsCodeDropdownRow>
{
    public SecurityCharacteristicsCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecurityCharacteristicsCodeDropdownRow(enumValue, memberInfo))
    {
    }
}