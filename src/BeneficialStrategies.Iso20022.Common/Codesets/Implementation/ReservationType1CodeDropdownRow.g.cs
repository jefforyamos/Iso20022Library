﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReservationType1Code.  ISO2002 ID# _ZUiEdNp-Ed-ak6NoX_4Aeg_865240256.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the precise type of reservation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReservationType1CodeDropdownSource"/>.
/// Implements <seealso cref="IReservationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZUiEdNp-Ed-ak6NoX_4Aeg_865240256")]
public partial class ReservationType1CodeDropdownRow : EnumMetadataItem<ReservationType1Code>, IReservationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the precise type of reservation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReservationType1CodeDropdownRow(ReservationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
