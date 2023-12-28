﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InvestigatedParties1Code.  ISO2002 ID# _U1p9sGKEEeG1ab6Vf7EgPA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the investigated parties.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InvestigatedParties1CodeDropdownSource"/>.
/// Implements <seealso cref="IInvestigatedParties1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_U1p9sGKEEeG1ab6Vf7EgPA")]
public partial class InvestigatedParties1CodeDropdownRow : EnumMetadataItem<InvestigatedParties1Code>, IInvestigatedParties1CodeDropdownRow
{
    /// <summary>
    /// Specifies the investigated parties.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InvestigatedParties1CodeDropdownRow(InvestigatedParties1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
