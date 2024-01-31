﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for IssuerTaxability2Code.  ISO2002 ID# _0EPMQIlyEeavwKddCbm3hg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the corporate action proceeds are taxable at issuer level.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="IssuerTaxability2CodeDropdownSource"/>.
/// Implements <seealso cref="IIssuerTaxability2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0EPMQIlyEeavwKddCbm3hg")]
public partial class IssuerTaxability2CodeDropdownRow : EnumMetadataItem<IssuerTaxability2Code>, IIssuerTaxability2CodeDropdownRow
{
    /// <summary>
    /// Specifies whether the corporate action proceeds are taxable at issuer level.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public IssuerTaxability2CodeDropdownRow(IssuerTaxability2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
