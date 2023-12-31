﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxType17Code.  ISO2002 ID# _Y3eIUDiGEeaH-93K5JKmzw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxType17CodeDropdownSource"/>.
/// Implements <seealso cref="ITaxType17CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y3eIUDiGEeaH-93K5JKmzw")]
public partial class TaxType17CodeDropdownRow : EnumMetadataItem<TaxType17Code>, ITaxType17CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of tax.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxType17CodeDropdownRow(TaxType17Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
