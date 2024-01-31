﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CryptographicKeyTypeCode.  ISO2002 ID# _KU0viX1DEeCF8NjrBemJWQ_1699573944.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of algorithm used by the cryptographic key.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CryptographicKeyTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICryptographicKeyTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KU0viX1DEeCF8NjrBemJWQ_1699573944")]
public partial class CryptographicKeyTypeCodeDropdownRow : EnumMetadataItem<CryptographicKeyTypeCode>, ICryptographicKeyTypeCodeDropdownRow
{
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CryptographicKeyTypeCodeDropdownRow(CryptographicKeyTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
