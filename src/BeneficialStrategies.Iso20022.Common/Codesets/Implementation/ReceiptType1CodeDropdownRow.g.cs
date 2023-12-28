﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReceiptType1Code.  ISO2002 ID# _MQE3AErHEeenp6hmNprBHg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Way of transmitting receipt information to recipient.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReceiptType1CodeDropdownSource"/>.
/// Implements <seealso cref="IReceiptType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_MQE3AErHEeenp6hmNprBHg")]
public partial class ReceiptType1CodeDropdownRow : EnumMetadataItem<ReceiptType1Code>, IReceiptType1CodeDropdownRow
{
    /// <summary>
    /// Way of transmitting receipt information to recipient.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReceiptType1CodeDropdownRow(ReceiptType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}