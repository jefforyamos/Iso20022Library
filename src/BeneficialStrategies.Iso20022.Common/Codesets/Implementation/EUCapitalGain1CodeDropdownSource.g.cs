﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EUCapitalGain1Code.  ISO2002 ID# _VkUiMdp-Ed-ak6NoX_4Aeg_-990874327.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June) for an income realised upon sale, a refund or redemption of shares and units etc.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEUCapitalGain1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VkUiMdp-Ed-ak6NoX_4Aeg_-990874327")]
public partial class EUCapitalGain1CodeDropdownSource : EnumMetadataManager<EUCapitalGain1Code,IEUCapitalGain1CodeDropdownRow,EUCapitalGain1CodeDropdownRow>
{
    public EUCapitalGain1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EUCapitalGain1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
