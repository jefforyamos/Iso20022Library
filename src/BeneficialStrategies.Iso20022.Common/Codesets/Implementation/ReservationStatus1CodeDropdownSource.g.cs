﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReservationStatus1Code.  ISO2002 ID# _8J5r8KMgEeCJ6YNENx4h-w_-308307214.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the current status of a limit.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReservationStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8J5r8KMgEeCJ6YNENx4h-w_-308307214")]
public partial class ReservationStatus1CodeDropdownSource : EnumMetadataManager<ReservationStatus1Code,IReservationStatus1CodeDropdownRow,ReservationStatus1CodeDropdownRow>
{
    public ReservationStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReservationStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
