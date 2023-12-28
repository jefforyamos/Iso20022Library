﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundLegalFormCode.  ISO2002 ID# _as4-htp-Ed-ak6NoX_4Aeg_-2143335309.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// The legal form of a Fund.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundLegalFormCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_as4-htp-Ed-ak6NoX_4Aeg_-2143335309")]
public partial class FundLegalFormCodeDropdownSource : EnumMetadataManager<FundLegalFormCode,IFundLegalFormCodeDropdownRow,FundLegalFormCodeDropdownRow>
{
    public FundLegalFormCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundLegalFormCodeDropdownRow(enumValue, memberInfo))
    {
    }
}