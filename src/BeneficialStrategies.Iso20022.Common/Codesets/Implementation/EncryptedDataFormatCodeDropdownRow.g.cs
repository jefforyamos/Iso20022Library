﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EncryptedDataFormatCode.  ISO2002 ID# _lupawAHwEeiJObvChJn-OA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Format used to encrypt the data.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EncryptedDataFormatCodeDropdownSource"/>.
/// Implements <seealso cref="IEncryptedDataFormatCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_lupawAHwEeiJObvChJn-OA")]
public partial class EncryptedDataFormatCodeDropdownRow : EnumMetadataItem<EncryptedDataFormatCode>, IEncryptedDataFormatCodeDropdownRow
{
    /// <summary>
    /// Format used to encrypt the data.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EncryptedDataFormatCodeDropdownRow(EncryptedDataFormatCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}