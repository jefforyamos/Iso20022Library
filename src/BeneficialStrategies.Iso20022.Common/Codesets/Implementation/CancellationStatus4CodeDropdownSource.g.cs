﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancellationStatus4Code.  ISO2002 ID# _a0VqUNp-Ed-ak6NoX_4Aeg_434017571.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the cancellation request of an invoice financing request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancellationStatus4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a0VqUNp-Ed-ak6NoX_4Aeg_434017571")]
public partial class CancellationStatus4CodeDropdownSource : EnumMetadataManager<CancellationStatus4Code,ICancellationStatus4CodeDropdownRow,CancellationStatus4CodeDropdownRow>
{
    public CancellationStatus4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancellationStatus4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
