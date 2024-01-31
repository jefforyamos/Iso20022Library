﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TriggerPriceType1Code.  ISO2002 ID# _Yv34Ntp-Ed-ak6NoX_4Aeg_-1635338287.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price that the trigger is compared to.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TriggerPriceType1CodeDropdownSource"/>.
/// Implements <seealso cref="ITriggerPriceType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yv34Ntp-Ed-ak6NoX_4Aeg_-1635338287")]
public partial class TriggerPriceType1CodeDropdownRow : EnumMetadataItem<TriggerPriceType1Code>, ITriggerPriceType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of price that the trigger is compared to.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TriggerPriceType1CodeDropdownRow(TriggerPriceType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
