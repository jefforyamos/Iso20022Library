﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestmentAccountCategory1Code.  ISO2002 ID# _FWTfYBRIEeOKWo1NF21OVw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the investment account category.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestmentAccountCategory1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_FWTfYBRIEeOKWo1NF21OVw")]
public partial class InvestmentAccountCategory1CodeDropdownSource : EnumMetadataManager<InvestmentAccountCategory1Code,IInvestmentAccountCategory1CodeDropdownRow,InvestmentAccountCategory1CodeDropdownRow>
{
    public InvestmentAccountCategory1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestmentAccountCategory1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
