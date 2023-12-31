﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CorporateActionOptionCode.  ISO2002 ID# _bM7wg9p-Ed-ak6NoX_4Aeg_962956293.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of corporate action options offered to the account holder for a corporate action.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CorporateActionOptionCodeDropdownSource"/>.
/// Implements <seealso cref="ICorporateActionOptionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bM7wg9p-Ed-ak6NoX_4Aeg_962956293")]
public partial class CorporateActionOptionCodeDropdownRow : EnumMetadataItem<CorporateActionOptionCode>, ICorporateActionOptionCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of corporate action options offered to the account holder for a corporate action.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CorporateActionOptionCodeDropdownRow(CorporateActionOptionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
