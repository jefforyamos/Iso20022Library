﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalBillingRateIdentificationCode.  ISO2002 ID# _40EQcJF2EeeMPMycDdDCGw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of billing rate or factor, as published in an external billing rate identification code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalBillingRateIdentificationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_40EQcJF2EeeMPMycDdDCGw")]
public partial class ExternalBillingRateIdentificationCodeDropdownSource : EnumMetadataManager<ExternalBillingRateIdentificationCode,IExternalBillingRateIdentificationCodeDropdownRow,ExternalBillingRateIdentificationCodeDropdownRow>
{
    public ExternalBillingRateIdentificationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalBillingRateIdentificationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
