﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Appearance1Code.  ISO2002 ID# _be9Uotp-Ed-ak6NoX_4Aeg_965330840.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the deliverability of a security.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Appearance1CodeDropdownSource"/>.
/// Implements <seealso cref="IAppearance1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_be9Uotp-Ed-ak6NoX_4Aeg_965330840")]
public partial class Appearance1CodeDropdownRow : EnumMetadataItem<Appearance1Code>, IAppearance1CodeDropdownRow
{
    /// <summary>
    /// Specifies the deliverability of a security.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Appearance1CodeDropdownRow(Appearance1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}