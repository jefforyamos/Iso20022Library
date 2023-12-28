﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalPaymentCompensationReason1Code.  ISO2002 ID# _CHK8YIjYEeeDW7_wB-eK_g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for compensation for the processing of a payment, as published in an external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalPaymentCompensationReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CHK8YIjYEeeDW7_wB-eK_g")]
public partial class ExternalPaymentCompensationReason1CodeDropdownSource : EnumMetadataManager<ExternalPaymentCompensationReason1Code,IExternalPaymentCompensationReason1CodeDropdownRow,ExternalPaymentCompensationReason1CodeDropdownRow>
{
    public ExternalPaymentCompensationReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalPaymentCompensationReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
