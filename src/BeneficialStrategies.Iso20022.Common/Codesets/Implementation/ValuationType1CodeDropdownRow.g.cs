﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ValuationType1Code.  ISO2002 ID# _uSTAcPP4EeS_qLctCs2aRQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type used for the calculation of the valuation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ValuationType1CodeDropdownSource"/>.
/// Implements <seealso cref="IValuationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_uSTAcPP4EeS_qLctCs2aRQ")]
public partial class ValuationType1CodeDropdownRow : EnumMetadataItem<ValuationType1Code>, IValuationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type used for the calculation of the valuation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ValuationType1CodeDropdownRow(ValuationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
