﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalPaymentRole1Code.  ISO2002 ID# _ONNMYnhiEeidzqjNEfehPg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role associated with a specific party in a payment instruction, as published in an external payment role code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalPaymentRole1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalPaymentRole1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ONNMYnhiEeidzqjNEfehPg")]
public partial class ExternalPaymentRole1CodeDropdownRow : EnumMetadataItem<ExternalPaymentRole1Code>, IExternalPaymentRole1CodeDropdownRow
{
    /// <summary>
    /// Specifies the role associated with a specific party in a payment instruction, as published in an external payment role code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalPaymentRole1CodeDropdownRow(ExternalPaymentRole1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
