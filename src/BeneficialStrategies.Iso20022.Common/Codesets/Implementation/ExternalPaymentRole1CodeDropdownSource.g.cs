﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalPaymentRole1Code.  ISO2002 ID# _ONNMYnhiEeidzqjNEfehPg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role associated with a specific party in a payment instruction, as published in an external payment role code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalPaymentRole1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ONNMYnhiEeidzqjNEfehPg")]
public partial class ExternalPaymentRole1CodeDropdownSource : EnumMetadataManager<ExternalPaymentRole1Code,IExternalPaymentRole1CodeDropdownRow,ExternalPaymentRole1CodeDropdownRow>
{
    public ExternalPaymentRole1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalPaymentRole1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}