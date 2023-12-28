﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for IssuerCode.  ISO2002 ID# _VsEwBdp-Ed-ak6NoX_4Aeg_335333174.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the institution issuing a proprietary code.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="IssuerCodeDropdownSource"/>.
/// Implements <seealso cref="IIssuerCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VsEwBdp-Ed-ak6NoX_4Aeg_335333174")]
public partial class IssuerCodeDropdownRow : EnumMetadataItem<IssuerCode>, IIssuerCodeDropdownRow
{
    /// <summary>
    /// Identifies the institution issuing a proprietary code.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public IssuerCodeDropdownRow(IssuerCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}