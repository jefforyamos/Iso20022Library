﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ValuationTimingCode.  ISO2002 ID# _Y8_HINp-Ed-ak6NoX_4Aeg_1401456451.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the price valuation timing is done based on the timeline defined in the prospectus.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ValuationTimingCodeDropdownSource"/>.
/// Implements <seealso cref="IValuationTimingCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y8_HINp-Ed-ak6NoX_4Aeg_1401456451")]
public partial class ValuationTimingCodeDropdownRow : EnumMetadataItem<ValuationTimingCode>, IValuationTimingCodeDropdownRow
{
    /// <summary>
    /// Specifies how the price valuation timing is done based on the timeline defined in the prospectus.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ValuationTimingCodeDropdownRow(ValuationTimingCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
