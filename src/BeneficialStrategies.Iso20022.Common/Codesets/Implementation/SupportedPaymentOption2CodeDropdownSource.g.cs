﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SupportedPaymentOption2Code.  ISO2002 ID# _ZiQqIU7GEeyGi9JAv6wq7Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the options supported for a payment transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISupportedPaymentOption2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZiQqIU7GEeyGi9JAv6wq7Q")]
public partial class SupportedPaymentOption2CodeDropdownSource : EnumMetadataManager<SupportedPaymentOption2Code,ISupportedPaymentOption2CodeDropdownRow,SupportedPaymentOption2CodeDropdownRow>
{
    public SupportedPaymentOption2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SupportedPaymentOption2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}