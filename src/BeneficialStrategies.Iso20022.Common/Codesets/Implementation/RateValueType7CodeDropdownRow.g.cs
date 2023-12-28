﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RateValueType7Code.  ISO2002 ID# _jWIcIeGYEd-1Ktb5rVaajw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the value of a rate.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RateValueType7CodeDropdownSource"/>.
/// Implements <seealso cref="IRateValueType7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jWIcIeGYEd-1Ktb5rVaajw")]
public partial class RateValueType7CodeDropdownRow : EnumMetadataItem<RateValueType7Code>, IRateValueType7CodeDropdownRow
{
    /// <summary>
    /// Specifies the value of a rate.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RateValueType7CodeDropdownRow(RateValueType7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}