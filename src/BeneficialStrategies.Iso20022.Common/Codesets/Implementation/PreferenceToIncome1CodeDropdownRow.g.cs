﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PreferenceToIncome1Code.  ISO2002 ID# _aIFoVdp-Ed-ak6NoX_4Aeg_-943074065.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the level of priority to claim on income and assets of |the company in case of the payment of dividends and in the event of a bankruptcy, eg, ordinary/common stocks, preferred stocks, subordinated debt, etc.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PreferenceToIncome1CodeDropdownSource"/>.
/// Implements <seealso cref="IPreferenceToIncome1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aIFoVdp-Ed-ak6NoX_4Aeg_-943074065")]
public partial class PreferenceToIncome1CodeDropdownRow : EnumMetadataItem<PreferenceToIncome1Code>, IPreferenceToIncome1CodeDropdownRow
{
    /// <summary>
    /// Indicates the level of priority to claim on income and assets of |the company in case of the payment of dividends and in the event of a bankruptcy, eg, ordinary/common stocks, preferred stocks, subordinated debt, etc.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PreferenceToIncome1CodeDropdownRow(PreferenceToIncome1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
