﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SupportedPaymentOptionCode.  ISO2002 ID# _UdiH4DANEeOqioR9srQH1g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the options supported for a payment transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISupportedPaymentOptionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_UdiH4DANEeOqioR9srQH1g")]
public partial class SupportedPaymentOptionCodeDropdownSource : EnumMetadataManager<SupportedPaymentOptionCode,ISupportedPaymentOptionCodeDropdownRow,SupportedPaymentOptionCodeDropdownRow>
{
    public SupportedPaymentOptionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SupportedPaymentOptionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
