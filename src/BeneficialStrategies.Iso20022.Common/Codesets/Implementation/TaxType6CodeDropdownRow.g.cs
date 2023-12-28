﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxType6Code.  ISO2002 ID# _VfGrA9p-Ed-ak6NoX_4Aeg_-1047538483.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxType6CodeDropdownSource"/>.
/// Implements <seealso cref="ITaxType6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VfGrA9p-Ed-ak6NoX_4Aeg_-1047538483")]
public partial class TaxType6CodeDropdownRow : EnumMetadataItem<TaxType6Code>, ITaxType6CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of tax.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxType6CodeDropdownRow(TaxType6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
