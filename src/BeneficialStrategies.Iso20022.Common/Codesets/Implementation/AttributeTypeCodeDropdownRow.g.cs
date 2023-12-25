﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AttributeTypeCode.  ISO2002 ID# _TVyU5gEcEeCQm6a_G2yO_w_-64929302.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of attribute of a distinguished name (DN).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AttributeTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IAttributeTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVyU5gEcEeCQm6a_G2yO_w_-64929302")]
public partial class AttributeTypeCodeDropdownRow : EnumMetadataItem<AttributeTypeCode>, IAttributeTypeCodeDropdownRow
{
    /// <summary>
    /// Type of attribute of a distinguished name (DN).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AttributeTypeCodeDropdownRow(AttributeTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
