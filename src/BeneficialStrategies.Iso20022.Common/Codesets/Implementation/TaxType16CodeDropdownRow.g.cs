﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxType16Code.  ISO2002 ID# _kiNHQBuGEeOqSdXzJ0oydA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxType16CodeDropdownSource"/>.
/// Implements <seealso cref="ITaxType16CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kiNHQBuGEeOqSdXzJ0oydA")]
public partial class TaxType16CodeDropdownRow : EnumMetadataItem<TaxType16Code>, ITaxType16CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of tax.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxType16CodeDropdownRow(TaxType16Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
