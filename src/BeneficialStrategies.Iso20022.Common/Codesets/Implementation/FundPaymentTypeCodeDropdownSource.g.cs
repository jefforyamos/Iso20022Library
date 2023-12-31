﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundPaymentTypeCode.  ISO2002 ID# _WR9p4F8wEeicg40_9gK9vQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of payment instrument.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundPaymentTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WR9p4F8wEeicg40_9gK9vQ")]
public partial class FundPaymentTypeCodeDropdownSource : EnumMetadataManager<FundPaymentTypeCode,IFundPaymentTypeCodeDropdownRow,FundPaymentTypeCodeDropdownRow>
{
    public FundPaymentTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundPaymentTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
