﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PresentationParty1Code.  ISO2002 ID# _RvL0sHyeEeGWJuGCfvwOsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the party to receive the presentation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PresentationParty1CodeDropdownSource"/>.
/// Implements <seealso cref="IPresentationParty1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_RvL0sHyeEeGWJuGCfvwOsQ")]
public partial class PresentationParty1CodeDropdownRow : EnumMetadataItem<PresentationParty1Code>, IPresentationParty1CodeDropdownRow
{
    /// <summary>
    /// Specifies the party to receive the presentation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PresentationParty1CodeDropdownRow(PresentationParty1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
