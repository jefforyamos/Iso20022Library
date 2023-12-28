﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancellationReason7Code.  ISO2002 ID# _nyEroB06EeiYoZGjIMHr2A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the possible reasons why a payment is to be cancelled.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancellationReason7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nyEroB06EeiYoZGjIMHr2A")]
public partial class CancellationReason7CodeDropdownSource : EnumMetadataManager<CancellationReason7Code,ICancellationReason7CodeDropdownRow,CancellationReason7CodeDropdownRow>
{
    public CancellationReason7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancellationReason7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}