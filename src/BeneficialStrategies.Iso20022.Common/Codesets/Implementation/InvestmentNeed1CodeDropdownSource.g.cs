﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestmentNeed1Code.  ISO2002 ID# _7RZv0DcdEeidBoT_PugKiA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an investment need.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestmentNeed1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_7RZv0DcdEeidBoT_PugKiA")]
public partial class InvestmentNeed1CodeDropdownSource : EnumMetadataManager<InvestmentNeed1Code,IInvestmentNeed1CodeDropdownRow,InvestmentNeed1CodeDropdownRow>
{
    public InvestmentNeed1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestmentNeed1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
