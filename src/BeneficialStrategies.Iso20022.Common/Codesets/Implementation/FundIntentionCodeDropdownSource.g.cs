﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundIntentionCode.  ISO2002 ID# _xgI4wCDXEeWCLu74WLgP4w.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the fund is intended for qualified investors.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundIntentionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xgI4wCDXEeWCLu74WLgP4w")]
public partial class FundIntentionCodeDropdownSource : EnumMetadataManager<FundIntentionCode,IFundIntentionCodeDropdownRow,FundIntentionCodeDropdownRow>
{
    public FundIntentionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundIntentionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
