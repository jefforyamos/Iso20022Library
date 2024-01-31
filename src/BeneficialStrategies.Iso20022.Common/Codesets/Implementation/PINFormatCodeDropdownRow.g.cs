﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PINFormatCode.  ISO2002 ID# _TVCuCwEcEeCQm6a_G2yO_w_1593903666.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// PIN (Personal Identification Number) format used to encrypt the PIN block.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PINFormatCodeDropdownSource"/>.
/// Implements <seealso cref="IPINFormatCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVCuCwEcEeCQm6a_G2yO_w_1593903666")]
public partial class PINFormatCodeDropdownRow : EnumMetadataItem<PINFormatCode>, IPINFormatCodeDropdownRow
{
    /// <summary>
    /// PIN (Personal Identification Number) format used to encrypt the PIN block.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PINFormatCodeDropdownRow(PINFormatCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
