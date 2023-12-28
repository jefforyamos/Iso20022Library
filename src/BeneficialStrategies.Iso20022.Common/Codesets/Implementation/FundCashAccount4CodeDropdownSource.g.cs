﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundCashAccount4Code.  ISO2002 ID# _nCKuwCC7EeWPMvNwVtiMsA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the account type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundCashAccount4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nCKuwCC7EeWPMvNwVtiMsA")]
public partial class FundCashAccount4CodeDropdownSource : EnumMetadataManager<FundCashAccount4Code,IFundCashAccount4CodeDropdownRow,FundCashAccount4CodeDropdownRow>
{
    public FundCashAccount4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundCashAccount4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
