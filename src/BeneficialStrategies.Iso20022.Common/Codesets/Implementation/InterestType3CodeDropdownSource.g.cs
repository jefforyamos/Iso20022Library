﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InterestType3Code.  ISO2002 ID# _ha_Uu2liEeGaMcKyqKNRfQ_-331678715.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether interest rate is fixed, variable or other.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInterestType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ha_Uu2liEeGaMcKyqKNRfQ_-331678715")]
public partial class InterestType3CodeDropdownSource : EnumMetadataManager<InterestType3Code,IInterestType3CodeDropdownRow,InterestType3CodeDropdownRow>
{
    public InterestType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InterestType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
