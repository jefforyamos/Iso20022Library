﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancellationStatusCode.  ISO2002 ID# _a0VqU9p-Ed-ak6NoX_4Aeg_453220269.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cancellation status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancellationStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a0VqU9p-Ed-ak6NoX_4Aeg_453220269")]
public partial class CancellationStatusCodeDropdownSource : EnumMetadataManager<CancellationStatusCode,ICancellationStatusCodeDropdownRow,CancellationStatusCodeDropdownRow>
{
    public CancellationStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancellationStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
