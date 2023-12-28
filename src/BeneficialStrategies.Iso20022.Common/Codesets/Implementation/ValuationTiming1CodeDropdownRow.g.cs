﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ValuationTiming1Code.  ISO2002 ID# _Y81WJtp-Ed-ak6NoX_4Aeg_1401456437.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the price valuation timing is done based on the timeline defined in the prospectus.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ValuationTiming1CodeDropdownSource"/>.
/// Implements <seealso cref="IValuationTiming1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y81WJtp-Ed-ak6NoX_4Aeg_1401456437")]
public partial class ValuationTiming1CodeDropdownRow : EnumMetadataItem<ValuationTiming1Code>, IValuationTiming1CodeDropdownRow
{
    /// <summary>
    /// Specifies how the price valuation timing is done based on the timeline defined in the prospectus.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ValuationTiming1CodeDropdownRow(ValuationTiming1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}