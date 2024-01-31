﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancellationStatus2Code.  ISO2002 ID# _bYs7p9p-Ed-ak6NoX_4Aeg_-1025146236.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cancellation status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancellationStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bYs7p9p-Ed-ak6NoX_4Aeg_-1025146236")]
public partial class CancellationStatus2CodeDropdownSource : EnumMetadataManager<CancellationStatus2Code,ICancellationStatus2CodeDropdownRow,CancellationStatus2CodeDropdownRow>
{
    public CancellationStatus2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancellationStatus2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
