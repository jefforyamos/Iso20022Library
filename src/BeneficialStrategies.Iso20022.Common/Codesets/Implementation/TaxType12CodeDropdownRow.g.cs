﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxType12Code.  ISO2002 ID# _YkP3Atp-Ed-ak6NoX_4Aeg_-1091962237.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxType12CodeDropdownSource"/>.
/// Implements <seealso cref="ITaxType12CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YkP3Atp-Ed-ak6NoX_4Aeg_-1091962237")]
public partial class TaxType12CodeDropdownRow : EnumMetadataItem<TaxType12Code>, ITaxType12CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of tax.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxType12CodeDropdownRow(TaxType12Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}