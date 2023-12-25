﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LegalRestrictionsCode.  ISO2002 ID# _ad_m49p-Ed-ak6NoX_4Aeg_-636020179.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regulatory restrictions applicable to a security.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LegalRestrictionsCodeDropdownSource"/>.
/// Implements <seealso cref="ILegalRestrictionsCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ad_m49p-Ed-ak6NoX_4Aeg_-636020179")]
public partial class LegalRestrictionsCodeDropdownRow : EnumMetadataItem<LegalRestrictionsCode>, ILegalRestrictionsCodeDropdownRow
{
    /// <summary>
    /// Specifies the regulatory restrictions applicable to a security.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LegalRestrictionsCodeDropdownRow(LegalRestrictionsCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
