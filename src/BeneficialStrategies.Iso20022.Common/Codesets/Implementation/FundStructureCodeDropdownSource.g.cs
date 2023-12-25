﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundStructureCode.  ISO2002 ID# _atyWZNp-Ed-ak6NoX_4Aeg_-1618399361.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the structure of the fund.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundStructureCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_atyWZNp-Ed-ak6NoX_4Aeg_-1618399361")]
public partial class FundStructureCodeDropdownSource : EnumMetadataManager<FundStructureCode,IFundStructureCodeDropdownRow,FundStructureCodeDropdownRow>
{
    public FundStructureCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundStructureCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
