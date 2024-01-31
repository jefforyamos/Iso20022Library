﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StayOnSideType1Code.  ISO2002 ID# _wn8Z4A93EeGeV5vP7Mvdig_-1370869444.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that an order is pegged against the offer/bid at the time of the order submission.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StayOnSideType1CodeDropdownSource"/>.
/// Implements <seealso cref="IStayOnSideType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_wn8Z4A93EeGeV5vP7Mvdig_-1370869444")]
public partial class StayOnSideType1CodeDropdownRow : EnumMetadataItem<StayOnSideType1Code>, IStayOnSideType1CodeDropdownRow
{
    /// <summary>
    /// Indicates that an order is pegged against the offer/bid at the time of the order submission.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StayOnSideType1CodeDropdownRow(StayOnSideType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
