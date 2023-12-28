﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StayOnSideTypeCode.  ISO2002 ID# _ZQpqANp-Ed-ak6NoX_4Aeg_1097083970.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates that an order is pegged against the offer/bid at the time of the order submission.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StayOnSideTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IStayOnSideTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZQpqANp-Ed-ak6NoX_4Aeg_1097083970")]
public partial class StayOnSideTypeCodeDropdownRow : EnumMetadataItem<StayOnSideTypeCode>, IStayOnSideTypeCodeDropdownRow
{
    /// <summary>
    /// Indicates that an order is pegged against the offer/bid at the time of the order submission.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StayOnSideTypeCodeDropdownRow(StayOnSideTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}