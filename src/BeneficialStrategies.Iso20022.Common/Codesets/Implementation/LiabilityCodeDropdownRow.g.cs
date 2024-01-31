﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LiabilityCode.  ISO2002 ID# _uQbcgCDMEeWPMvNwVtiMsA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the party responsible for the liability.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LiabilityCodeDropdownSource"/>.
/// Implements <seealso cref="ILiabilityCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_uQbcgCDMEeWPMvNwVtiMsA")]
public partial class LiabilityCodeDropdownRow : EnumMetadataItem<LiabilityCode>, ILiabilityCodeDropdownRow
{
    /// <summary>
    /// Specifies the party responsible for the liability.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LiabilityCodeDropdownRow(LiabilityCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
