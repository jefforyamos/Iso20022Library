﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DebitTypeCode.  ISO2002 ID# _JtKwwMmKEeWAGphE2LvqeA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of debit to be applied to the payment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DebitTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDebitTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JtKwwMmKEeWAGphE2LvqeA")]
public partial class DebitTypeCodeDropdownRow : EnumMetadataItem<DebitTypeCode>, IDebitTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of debit to be applied to the payment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DebitTypeCodeDropdownRow(DebitTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
