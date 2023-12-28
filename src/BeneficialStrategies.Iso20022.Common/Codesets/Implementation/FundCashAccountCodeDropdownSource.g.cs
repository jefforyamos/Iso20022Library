﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundCashAccountCode.  ISO2002 ID# _asv0ktp-Ed-ak6NoX_4Aeg_1756152528.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cash account type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundCashAccountCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_asv0ktp-Ed-ak6NoX_4Aeg_1756152528")]
public partial class FundCashAccountCodeDropdownSource : EnumMetadataManager<FundCashAccountCode,IFundCashAccountCodeDropdownRow,FundCashAccountCodeDropdownRow>
{
    public FundCashAccountCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundCashAccountCodeDropdownRow(enumValue, memberInfo))
    {
    }
}