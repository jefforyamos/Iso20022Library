﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalPaymentModificationRejectionCode.  ISO2002 ID# _VSTREYlzEeePr-EGJjGYzQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the rejection of a modification, as published in an external payment modification rejection code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalPaymentModificationRejectionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VSTREYlzEeePr-EGJjGYzQ")]
public partial class ExternalPaymentModificationRejectionCodeDropdownSource : EnumMetadataManager<ExternalPaymentModificationRejectionCode,IExternalPaymentModificationRejectionCodeDropdownRow,ExternalPaymentModificationRejectionCodeDropdownRow>
{
    public ExternalPaymentModificationRejectionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalPaymentModificationRejectionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
