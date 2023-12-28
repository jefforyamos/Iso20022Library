﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxType13Code.  ISO2002 ID# _YkZoANp-Ed-ak6NoX_4Aeg_1588972374.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxType13CodeDropdownSource"/>.
/// Implements <seealso cref="ITaxType13CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YkZoANp-Ed-ak6NoX_4Aeg_1588972374")]
public partial class TaxType13CodeDropdownRow : EnumMetadataItem<TaxType13Code>, ITaxType13CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of tax.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxType13CodeDropdownRow(TaxType13Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
