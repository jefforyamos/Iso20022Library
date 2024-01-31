﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FractionDispositionType2Code.  ISO2002 ID# _arZwwtp-Ed-ak6NoX_4Aeg_157489623.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FractionDispositionType2CodeDropdownSource"/>.
/// Implements <seealso cref="IFractionDispositionType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_arZwwtp-Ed-ak6NoX_4Aeg_157489623")]
public partial class FractionDispositionType2CodeDropdownRow : EnumMetadataItem<FractionDispositionType2Code>, IFractionDispositionType2CodeDropdownRow
{
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FractionDispositionType2CodeDropdownRow(FractionDispositionType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
