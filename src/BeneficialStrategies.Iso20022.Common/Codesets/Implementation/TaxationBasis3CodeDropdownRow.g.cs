﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxationBasis3Code.  ISO2002 ID# _Vg5awdp-Ed-ak6NoX_4Aeg_-372135531.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the tax basis.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxationBasis3CodeDropdownSource"/>.
/// Implements <seealso cref="ITaxationBasis3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vg5awdp-Ed-ak6NoX_4Aeg_-372135531")]
public partial class TaxationBasis3CodeDropdownRow : EnumMetadataItem<TaxationBasis3Code>, ITaxationBasis3CodeDropdownRow
{
    /// <summary>
    /// Specifies the tax basis.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxationBasis3CodeDropdownRow(TaxationBasis3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}