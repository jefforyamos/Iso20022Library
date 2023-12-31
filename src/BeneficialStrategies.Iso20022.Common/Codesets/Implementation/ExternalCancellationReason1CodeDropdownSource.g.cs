﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalCancellationReason1Code.  ISO2002 ID# _8DT3MUgtEeaGKYpLDboHPQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cancellation reason, as published in an external cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalCancellationReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8DT3MUgtEeaGKYpLDboHPQ")]
public partial class ExternalCancellationReason1CodeDropdownSource : EnumMetadataManager<ExternalCancellationReason1Code,IExternalCancellationReason1CodeDropdownRow,ExternalCancellationReason1CodeDropdownRow>
{
    public ExternalCancellationReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalCancellationReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
