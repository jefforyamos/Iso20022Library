﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for IssuerTaxabilityV2Code.  ISO2002 ID# _gBpAoolyEeavwKddCbm3hg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the corporate action proceeds are taxable at issuer level.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="IssuerTaxabilityV2CodeDropdownSource"/>.
/// Implements <seealso cref="IIssuerTaxabilityV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_gBpAoolyEeavwKddCbm3hg")]
public partial class IssuerTaxabilityV2CodeDropdownRow : EnumMetadataItem<IssuerTaxabilityV2Code>, IIssuerTaxabilityV2CodeDropdownRow
{
    /// <summary>
    /// Specifies whether the corporate action proceeds are taxable at issuer level.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public IssuerTaxabilityV2CodeDropdownRow(IssuerTaxabilityV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
