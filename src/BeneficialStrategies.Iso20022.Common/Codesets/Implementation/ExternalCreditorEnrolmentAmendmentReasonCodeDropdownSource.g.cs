﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalCreditorEnrolmentAmendmentReasonCode.  ISO2002 ID# _S1ANk_DCEemsS_0xy2XRug.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the creditor enrolment amendment reason code, as published in an external creditor enrolment amendment reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalCreditorEnrolmentAmendmentReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_S1ANk_DCEemsS_0xy2XRug")]
public partial class ExternalCreditorEnrolmentAmendmentReasonCodeDropdownSource : EnumMetadataManager<ExternalCreditorEnrolmentAmendmentReasonCode,IExternalCreditorEnrolmentAmendmentReasonCodeDropdownRow,ExternalCreditorEnrolmentAmendmentReasonCodeDropdownRow>
{
    public ExternalCreditorEnrolmentAmendmentReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalCreditorEnrolmentAmendmentReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}