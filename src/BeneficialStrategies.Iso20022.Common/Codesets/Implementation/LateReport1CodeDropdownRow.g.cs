﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LateReport1Code.  ISO2002 ID# _adsE6Np-Ed-ak6NoX_4Aeg_-1914008169.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a transaction report is late.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LateReport1CodeDropdownSource"/>.
/// Implements <seealso cref="ILateReport1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_adsE6Np-Ed-ak6NoX_4Aeg_-1914008169")]
public partial class LateReport1CodeDropdownRow : EnumMetadataItem<LateReport1Code>, ILateReport1CodeDropdownRow
{
    /// <summary>
    /// Specifies whether a transaction report is late.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LateReport1CodeDropdownRow(LateReport1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
