﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BytePaddingCode.  ISO2002 ID# _NOnpUGi9EeS87LmvcA55sg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BytePaddingCodeDropdownSource"/>.
/// Implements <seealso cref="IBytePaddingCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NOnpUGi9EeS87LmvcA55sg")]
public partial class BytePaddingCodeDropdownRow : EnumMetadataItem<BytePaddingCode>, IBytePaddingCodeDropdownRow
{
    /// <summary>
    /// Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BytePaddingCodeDropdownRow(BytePaddingCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
