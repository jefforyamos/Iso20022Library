﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FraudType1Code.  ISO2002 ID# _4htAMHa-Eeef9c2nwgY9Xw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of fraud in a card payment environment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FraudType1CodeDropdownSource"/>.
/// Implements <seealso cref="IFraudType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_4htAMHa-Eeef9c2nwgY9Xw")]
public partial class FraudType1CodeDropdownRow : EnumMetadataItem<FraudType1Code>, IFraudType1CodeDropdownRow
{
    /// <summary>
    /// Identifies the type of fraud in a card payment environment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FraudType1CodeDropdownRow(FraudType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}