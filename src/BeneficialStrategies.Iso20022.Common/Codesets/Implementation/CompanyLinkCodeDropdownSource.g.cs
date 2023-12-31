﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CompanyLinkCode.  ISO2002 ID# _FFnMsCCaEeWJd9HF2tO7BA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of links to a company.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICompanyLinkCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_FFnMsCCaEeWJd9HF2tO7BA")]
public partial class CompanyLinkCodeDropdownSource : EnumMetadataManager<CompanyLinkCode,ICompanyLinkCodeDropdownRow,CompanyLinkCodeDropdownRow>
{
    public CompanyLinkCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CompanyLinkCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
