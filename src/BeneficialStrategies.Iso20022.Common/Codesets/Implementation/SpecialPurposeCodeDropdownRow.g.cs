﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SpecialPurposeCode.  ISO2002 ID# _WjGtkBvUEeWeg9zOuV6DZQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies special purpose codes.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SpecialPurposeCodeDropdownSource"/>.
/// Implements <seealso cref="ISpecialPurposeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WjGtkBvUEeWeg9zOuV6DZQ")]
public partial class SpecialPurposeCodeDropdownRow : EnumMetadataItem<SpecialPurposeCode>, ISpecialPurposeCodeDropdownRow
{
    /// <summary>
    /// Specifies special purpose codes.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SpecialPurposeCodeDropdownRow(SpecialPurposeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
