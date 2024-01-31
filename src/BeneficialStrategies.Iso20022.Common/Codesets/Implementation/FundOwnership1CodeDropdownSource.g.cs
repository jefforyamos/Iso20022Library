﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundOwnership1Code.  ISO2002 ID# _j9NfQCDXEeWCLu74WLgP4w.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if all the shares are owned exclusively by the fund company.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundOwnership1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_j9NfQCDXEeWCLu74WLgP4w")]
public partial class FundOwnership1CodeDropdownSource : EnumMetadataManager<FundOwnership1Code,IFundOwnership1CodeDropdownRow,FundOwnership1CodeDropdownRow>
{
    public FundOwnership1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundOwnership1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
