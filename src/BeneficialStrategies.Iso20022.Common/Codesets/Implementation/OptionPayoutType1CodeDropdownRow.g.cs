﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OptionPayoutType1Code.  ISO2002 ID# _El9IgKbFEeSxuMLA5o46jQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of payout that will result from an in-the-money option.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OptionPayoutType1CodeDropdownSource"/>.
/// Implements <seealso cref="IOptionPayoutType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_El9IgKbFEeSxuMLA5o46jQ")]
public partial class OptionPayoutType1CodeDropdownRow : EnumMetadataItem<OptionPayoutType1Code>, IOptionPayoutType1CodeDropdownRow
{
    /// <summary>
    /// Indicates the type of payout that will result from an in-the-money option.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OptionPayoutType1CodeDropdownRow(OptionPayoutType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
