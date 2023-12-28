﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalCreditorEnrolmentStatusReason1Code.  ISO2002 ID# _gtemoeIwEeqbls7Gk4-ckA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the  creditor enrolment status reason code, as published in an external  creditor enrolment status reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalCreditorEnrolmentStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_gtemoeIwEeqbls7Gk4-ckA")]
public partial class ExternalCreditorEnrolmentStatusReason1CodeDropdownSource : EnumMetadataManager<ExternalCreditorEnrolmentStatusReason1Code,IExternalCreditorEnrolmentStatusReason1CodeDropdownRow,ExternalCreditorEnrolmentStatusReason1CodeDropdownRow>
{
    public ExternalCreditorEnrolmentStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalCreditorEnrolmentStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}