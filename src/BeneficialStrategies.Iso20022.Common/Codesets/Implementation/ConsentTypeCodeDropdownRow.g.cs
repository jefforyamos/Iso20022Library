﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ConsentTypeCode.  ISO2002 ID# _T9qiUCHmEeOQ7qT4JUI53A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of consent announced.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ConsentTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IConsentTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_T9qiUCHmEeOQ7qT4JUI53A")]
public partial class ConsentTypeCodeDropdownRow : EnumMetadataItem<ConsentTypeCode>, IConsentTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of consent announced.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ConsentTypeCodeDropdownRow(ConsentTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
