﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CapitalTypeCode.  ISO2002 ID# _a11fIdp-Ed-ak6NoX_4Aeg_502156633.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of capital.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CapitalTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICapitalTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a11fIdp-Ed-ak6NoX_4Aeg_502156633")]
public partial class CapitalTypeCodeDropdownRow : EnumMetadataItem<CapitalTypeCode>, ICapitalTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of capital.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CapitalTypeCodeDropdownRow(CapitalTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}