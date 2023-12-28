﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalCancellationReasonCode.  ISO2002 ID# _6EBKgJF4EeeMPMycDdDCGw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cancellation reason, as published in an external cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalCancellationReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6EBKgJF4EeeMPMycDdDCGw")]
public partial class ExternalCancellationReasonCodeDropdownSource : EnumMetadataManager<ExternalCancellationReasonCode,IExternalCancellationReasonCodeDropdownRow,ExternalCancellationReasonCodeDropdownRow>
{
    public ExternalCancellationReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalCancellationReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}