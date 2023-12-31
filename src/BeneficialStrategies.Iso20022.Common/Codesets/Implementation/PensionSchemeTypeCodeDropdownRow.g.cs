﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PensionSchemeTypeCode.  ISO2002 ID# _OIg3gE4OEeiQHa-q1Uephw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of pension scheme.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PensionSchemeTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IPensionSchemeTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OIg3gE4OEeiQHa-q1Uephw")]
public partial class PensionSchemeTypeCodeDropdownRow : EnumMetadataItem<PensionSchemeTypeCode>, IPensionSchemeTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies a type of pension scheme.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PensionSchemeTypeCodeDropdownRow(PensionSchemeTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
