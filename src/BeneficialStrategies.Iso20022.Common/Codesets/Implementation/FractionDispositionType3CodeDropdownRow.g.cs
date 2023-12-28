﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FractionDispositionType3Code.  ISO2002 ID# _arZwx9p-Ed-ak6NoX_4Aeg_1382196643.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FractionDispositionType3CodeDropdownSource"/>.
/// Implements <seealso cref="IFractionDispositionType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_arZwx9p-Ed-ak6NoX_4Aeg_1382196643")]
public partial class FractionDispositionType3CodeDropdownRow : EnumMetadataItem<FractionDispositionType3Code>, IFractionDispositionType3CodeDropdownRow
{
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FractionDispositionType3CodeDropdownRow(FractionDispositionType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}