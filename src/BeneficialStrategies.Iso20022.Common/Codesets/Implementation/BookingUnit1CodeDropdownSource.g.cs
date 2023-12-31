﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BookingUnit1Code.  ISO2002 ID# _VuwQktp-Ed-ak6NoX_4Aeg_-2003409419.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Description of the method used to book single or grouped executions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBookingUnit1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VuwQktp-Ed-ak6NoX_4Aeg_-2003409419")]
public partial class BookingUnit1CodeDropdownSource : EnumMetadataManager<BookingUnit1Code,IBookingUnit1CodeDropdownRow,BookingUnit1CodeDropdownRow>
{
    public BookingUnit1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BookingUnit1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
