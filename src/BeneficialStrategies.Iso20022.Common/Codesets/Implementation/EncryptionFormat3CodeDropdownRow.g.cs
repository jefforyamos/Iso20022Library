﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EncryptionFormat3Code.  ISO2002 ID# _ODabcNZ1EeeA4_YxLuyJaA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Format of data before encryption, if the format is not plaintext or implicit.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EncryptionFormat3CodeDropdownSource"/>.
/// Implements <seealso cref="IEncryptionFormat3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ODabcNZ1EeeA4_YxLuyJaA")]
public partial class EncryptionFormat3CodeDropdownRow : EnumMetadataItem<EncryptionFormat3Code>, IEncryptionFormat3CodeDropdownRow
{
    /// <summary>
    /// Format of data before encryption, if the format is not plaintext or implicit.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EncryptionFormat3CodeDropdownRow(EncryptionFormat3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
