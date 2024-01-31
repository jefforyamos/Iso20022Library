﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InterestType2Code.  ISO2002 ID# __215cNojEeC60axPepSq7g_96023160.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if the deal price is excluding or including the accrued interest.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InterestType2CodeDropdownSource"/>.
/// Implements <seealso cref="IInterestType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__215cNojEeC60axPepSq7g_96023160")]
public partial class InterestType2CodeDropdownRow : EnumMetadataItem<InterestType2Code>, IInterestType2CodeDropdownRow
{
    /// <summary>
    /// Indicates if the deal price is excluding or including the accrued interest.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InterestType2CodeDropdownRow(InterestType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
