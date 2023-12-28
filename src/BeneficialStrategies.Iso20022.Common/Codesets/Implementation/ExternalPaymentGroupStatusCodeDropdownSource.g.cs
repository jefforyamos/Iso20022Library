﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalPaymentGroupStatusCode.  ISO2002 ID# _5z1UgLf7Eee9KIDjEHK7ZQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of payment instructions, as published in an external payment group status code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalPaymentGroupStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_5z1UgLf7Eee9KIDjEHK7ZQ")]
public partial class ExternalPaymentGroupStatusCodeDropdownSource : EnumMetadataManager<ExternalPaymentGroupStatusCode,IExternalPaymentGroupStatusCodeDropdownRow,ExternalPaymentGroupStatusCodeDropdownRow>
{
    public ExternalPaymentGroupStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalPaymentGroupStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}