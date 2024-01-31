﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalCreditorEnrolmentCancellationReason1Code.  ISO2002 ID# _EvdPMvDCEemsS_0xy2XRug.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the creditor enrolment cancellation reason code, as published in an external creditor enrolment cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalCreditorEnrolmentCancellationReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EvdPMvDCEemsS_0xy2XRug")]
public partial class ExternalCreditorEnrolmentCancellationReason1CodeDropdownSource : EnumMetadataManager<ExternalCreditorEnrolmentCancellationReason1Code,IExternalCreditorEnrolmentCancellationReason1CodeDropdownRow,ExternalCreditorEnrolmentCancellationReason1CodeDropdownRow>
{
    public ExternalCreditorEnrolmentCancellationReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalCreditorEnrolmentCancellationReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
