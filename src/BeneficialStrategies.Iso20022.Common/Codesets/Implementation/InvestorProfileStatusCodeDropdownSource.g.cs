﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestorProfileStatusCode.  ISO2002 ID# _1CAzICDOEeWPMvNwVtiMsA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the investor profile.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestorProfileStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1CAzICDOEeWPMvNwVtiMsA")]
public partial class InvestorProfileStatusCodeDropdownSource : EnumMetadataManager<InvestorProfileStatusCode,IInvestorProfileStatusCodeDropdownRow,InvestorProfileStatusCodeDropdownRow>
{
    public InvestorProfileStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestorProfileStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
