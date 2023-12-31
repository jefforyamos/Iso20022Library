﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FractionDispositionType7Code.  ISO2002 ID# _hhACgeHEEd-1Ktb5rVaajw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FractionDispositionType7CodeDropdownSource"/>.
/// Implements <seealso cref="IFractionDispositionType7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hhACgeHEEd-1Ktb5rVaajw")]
public partial class FractionDispositionType7CodeDropdownRow : EnumMetadataItem<FractionDispositionType7Code>, IFractionDispositionType7CodeDropdownRow
{
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FractionDispositionType7CodeDropdownRow(FractionDispositionType7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
