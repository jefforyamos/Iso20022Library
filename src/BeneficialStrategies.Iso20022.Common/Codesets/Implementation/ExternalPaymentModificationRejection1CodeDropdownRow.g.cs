﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalPaymentModificationRejection1Code.  ISO2002 ID# _eDCG4IlzEeePr-EGJjGYzQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the rejection of a modification, as published in an external payment modification rejection code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalPaymentModificationRejection1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalPaymentModificationRejection1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_eDCG4IlzEeePr-EGJjGYzQ")]
public partial class ExternalPaymentModificationRejection1CodeDropdownRow : EnumMetadataItem<ExternalPaymentModificationRejection1Code>, IExternalPaymentModificationRejection1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for the rejection of a modification, as published in an external payment modification rejection code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalPaymentModificationRejection1CodeDropdownRow(ExternalPaymentModificationRejection1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}