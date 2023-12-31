﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundTypeCode.  ISO2002 ID# _sLXxUHaUEeaRItPFeGK_vQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// In the case where the reporting counterparty is a UCIT or AIF, an indication whether it is an ETF or a MMF.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_sLXxUHaUEeaRItPFeGK_vQ")]
public partial class FundTypeCodeDropdownSource : EnumMetadataManager<FundTypeCode,IFundTypeCodeDropdownRow,FundTypeCodeDropdownRow>
{
    public FundTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
