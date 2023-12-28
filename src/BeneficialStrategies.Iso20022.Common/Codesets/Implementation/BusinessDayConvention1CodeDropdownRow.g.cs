﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BusinessDayConvention1Code.  ISO2002 ID# _bVIDNdp-Ed-ak6NoX_4Aeg_1684551992.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates how a date is adjusted when it falls on a non-business day.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BusinessDayConvention1CodeDropdownSource"/>.
/// Implements <seealso cref="IBusinessDayConvention1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bVIDNdp-Ed-ak6NoX_4Aeg_1684551992")]
public partial class BusinessDayConvention1CodeDropdownRow : EnumMetadataItem<BusinessDayConvention1Code>, IBusinessDayConvention1CodeDropdownRow
{
    /// <summary>
    /// Indicates how a date is adjusted when it falls on a non-business day.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BusinessDayConvention1CodeDropdownRow(BusinessDayConvention1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}