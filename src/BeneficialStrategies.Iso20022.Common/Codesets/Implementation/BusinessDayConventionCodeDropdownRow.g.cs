﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BusinessDayConventionCode.  ISO2002 ID# _bVIDONp-Ed-ak6NoX_4Aeg_627416389.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates how a date is adjusted when it falls on a non-business day.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BusinessDayConventionCodeDropdownSource"/>.
/// Implements <seealso cref="IBusinessDayConventionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bVIDONp-Ed-ak6NoX_4Aeg_627416389")]
public partial class BusinessDayConventionCodeDropdownRow : EnumMetadataItem<BusinessDayConventionCode>, IBusinessDayConventionCodeDropdownRow
{
    /// <summary>
    /// Indicates how a date is adjusted when it falls on a non-business day.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BusinessDayConventionCodeDropdownRow(BusinessDayConventionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
