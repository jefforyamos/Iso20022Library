﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BookingUnitCode.  ISO2002 ID# _bU-SNtp-Ed-ak6NoX_4Aeg_335335556.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Description of the method used to book single or grouped executions.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BookingUnitCodeDropdownSource"/>.
/// Implements <seealso cref="IBookingUnitCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bU-SNtp-Ed-ak6NoX_4Aeg_335335556")]
public partial class BookingUnitCodeDropdownRow : EnumMetadataItem<BookingUnitCode>, IBookingUnitCodeDropdownRow
{
    /// <summary>
    /// Description of the method used to book single or grouped executions.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BookingUnitCodeDropdownRow(BookingUnitCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
