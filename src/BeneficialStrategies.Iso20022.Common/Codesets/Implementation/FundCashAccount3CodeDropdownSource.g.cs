﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundCashAccount3Code.  ISO2002 ID# _asmDldp-Ed-ak6NoX_4Aeg_-525778096.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cash account type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundCashAccount3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_asmDldp-Ed-ak6NoX_4Aeg_-525778096")]
public partial class FundCashAccount3CodeDropdownSource : EnumMetadataManager<FundCashAccount3Code,IFundCashAccount3CodeDropdownRow,FundCashAccount3CodeDropdownRow>
{
    public FundCashAccount3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundCashAccount3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
