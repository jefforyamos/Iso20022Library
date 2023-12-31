﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FundPaymentType1Code.  ISO2002 ID# _vDyvUF8xEeicg40_9gK9vQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of payment instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FundPaymentType1CodeDropdownSource"/>.
/// Implements <seealso cref="IFundPaymentType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vDyvUF8xEeicg40_9gK9vQ")]
public partial class FundPaymentType1CodeDropdownRow : EnumMetadataItem<FundPaymentType1Code>, IFundPaymentType1CodeDropdownRow
{
    /// <summary>
    /// Specifies a type of payment instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FundPaymentType1CodeDropdownRow(FundPaymentType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
