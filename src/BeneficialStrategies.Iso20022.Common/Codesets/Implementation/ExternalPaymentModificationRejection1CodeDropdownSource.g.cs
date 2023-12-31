﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalPaymentModificationRejection1Code.  ISO2002 ID# _eDCG4IlzEeePr-EGJjGYzQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the rejection of a modification, as published in an external payment modification rejection code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalPaymentModificationRejection1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_eDCG4IlzEeePr-EGJjGYzQ")]
public partial class ExternalPaymentModificationRejection1CodeDropdownSource : EnumMetadataManager<ExternalPaymentModificationRejection1Code,IExternalPaymentModificationRejection1CodeDropdownRow,ExternalPaymentModificationRejection1CodeDropdownRow>
{
    public ExternalPaymentModificationRejection1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalPaymentModificationRejection1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
