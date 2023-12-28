﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for LegalFramework1Code.  ISO2002 ID# _ad1149p-Ed-ak6NoX_4Aeg_-712964613.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the legal framework of the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ILegalFramework1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ad1149p-Ed-ak6NoX_4Aeg_-712964613")]
public partial class LegalFramework1CodeDropdownSource : EnumMetadataManager<LegalFramework1Code,ILegalFramework1CodeDropdownRow,LegalFramework1CodeDropdownRow>
{
    public LegalFramework1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new LegalFramework1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}