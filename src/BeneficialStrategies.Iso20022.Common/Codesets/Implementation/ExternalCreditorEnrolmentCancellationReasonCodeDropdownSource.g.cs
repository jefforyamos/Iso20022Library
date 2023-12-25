﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalCreditorEnrolmentCancellationReasonCode.  ISO2002 ID# _EvdPM_DCEemsS_0xy2XRug.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the creditor enrolment cancellation reason code, as published in an external creditor enrolment cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalCreditorEnrolmentCancellationReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EvdPM_DCEemsS_0xy2XRug")]
public partial class ExternalCreditorEnrolmentCancellationReasonCodeDropdownSource : EnumMetadataManager<ExternalCreditorEnrolmentCancellationReasonCode,IExternalCreditorEnrolmentCancellationReasonCodeDropdownRow,ExternalCreditorEnrolmentCancellationReasonCodeDropdownRow>
{
    public ExternalCreditorEnrolmentCancellationReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalCreditorEnrolmentCancellationReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
