﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for IdentificationTypeCode.  ISO2002 ID# _2G4usEVPEeSGWeX3z5zSZQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of identification of the party.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="IdentificationTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IIdentificationTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2G4usEVPEeSGWeX3z5zSZQ")]
public partial class IdentificationTypeCodeDropdownRow : EnumMetadataItem<IdentificationTypeCode>, IIdentificationTypeCodeDropdownRow
{
    /// <summary>
    /// Indicates the type of identification of the party.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public IdentificationTypeCodeDropdownRow(IdentificationTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
