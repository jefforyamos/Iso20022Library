﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EncryptionFormat1Code.  ISO2002 ID# _IJtXQGi4EeS87LmvcA55sg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Format of data before encryption, if the format is not plaintext or implicit.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EncryptionFormat1CodeDropdownSource"/>.
/// Implements <seealso cref="IEncryptionFormat1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_IJtXQGi4EeS87LmvcA55sg")]
public partial class EncryptionFormat1CodeDropdownRow : EnumMetadataItem<EncryptionFormat1Code>, IEncryptionFormat1CodeDropdownRow
{
    /// <summary>
    /// Format of data before encryption, if the format is not plaintext or implicit.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EncryptionFormat1CodeDropdownRow(EncryptionFormat1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
