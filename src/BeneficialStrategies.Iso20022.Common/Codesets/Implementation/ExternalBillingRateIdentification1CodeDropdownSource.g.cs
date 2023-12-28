﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalBillingRateIdentification1Code.  ISO2002 ID# _6WzSlpqlEeGSON8vddiWzQ_1145255535.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of billing rate or factor, as published in an external billing rate identification code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalBillingRateIdentification1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6WzSlpqlEeGSON8vddiWzQ_1145255535")]
public partial class ExternalBillingRateIdentification1CodeDropdownSource : EnumMetadataManager<ExternalBillingRateIdentification1Code,IExternalBillingRateIdentification1CodeDropdownRow,ExternalBillingRateIdentification1CodeDropdownRow>
{
    public ExternalBillingRateIdentification1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalBillingRateIdentification1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
