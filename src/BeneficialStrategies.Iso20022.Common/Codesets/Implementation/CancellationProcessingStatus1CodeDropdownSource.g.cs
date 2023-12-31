﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancellationProcessingStatus1Code.  ISO2002 ID# _bXgo0tp-Ed-ak6NoX_4Aeg_2094579534.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a cancellation request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancellationProcessingStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bXgo0tp-Ed-ak6NoX_4Aeg_2094579534")]
public partial class CancellationProcessingStatus1CodeDropdownSource : EnumMetadataManager<CancellationProcessingStatus1Code,ICancellationProcessingStatus1CodeDropdownRow,CancellationProcessingStatus1CodeDropdownRow>
{
    public CancellationProcessingStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancellationProcessingStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
