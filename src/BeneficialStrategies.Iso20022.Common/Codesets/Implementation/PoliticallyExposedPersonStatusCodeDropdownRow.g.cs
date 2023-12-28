﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PoliticallyExposedPersonStatusCode.  ISO2002 ID# _rmRbMJUiEemC09f0MxYkRg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Status of a politically exposed person.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PoliticallyExposedPersonStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IPoliticallyExposedPersonStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_rmRbMJUiEemC09f0MxYkRg")]
public partial class PoliticallyExposedPersonStatusCodeDropdownRow : EnumMetadataItem<PoliticallyExposedPersonStatusCode>, IPoliticallyExposedPersonStatusCodeDropdownRow
{
    /// <summary>
    /// Status of a politically exposed person.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PoliticallyExposedPersonStatusCodeDropdownRow(PoliticallyExposedPersonStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}