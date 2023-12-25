﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AdditionalRightCode.  ISO2002 ID# _bmticdp-Ed-ak6NoX_4Aeg_-456866775.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Define specific rights that the shareholder has (for example, the right to ask questions, the right to add items to the agenda or table draft resolutions).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AdditionalRightCodeDropdownSource"/>.
/// Implements <seealso cref="IAdditionalRightCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bmticdp-Ed-ak6NoX_4Aeg_-456866775")]
public partial class AdditionalRightCodeDropdownRow : EnumMetadataItem<AdditionalRightCode>, IAdditionalRightCodeDropdownRow
{
    /// <summary>
    /// Define specific rights that the shareholder has (for example, the right to ask questions, the right to add items to the agenda or table draft resolutions).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AdditionalRightCodeDropdownRow(AdditionalRightCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
