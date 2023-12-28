﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalPaymentCompensationReason1Code.  ISO2002 ID# _CHK8YIjYEeeDW7_wB-eK_g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for compensation for the processing of a payment, as published in an external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalPaymentCompensationReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalPaymentCompensationReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CHK8YIjYEeeDW7_wB-eK_g")]
public partial class ExternalPaymentCompensationReason1CodeDropdownRow : EnumMetadataItem<ExternalPaymentCompensationReason1Code>, IExternalPaymentCompensationReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for compensation for the processing of a payment, as published in an external code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalPaymentCompensationReason1CodeDropdownRow(ExternalPaymentCompensationReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}