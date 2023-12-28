﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalPaymentGroupStatus1Code.  ISO2002 ID# _v9bSwWXiEeap-P22vGV91g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of payment instructions, as published in an external payment group status code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalPaymentGroupStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalPaymentGroupStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_v9bSwWXiEeap-P22vGV91g")]
public partial class ExternalPaymentGroupStatus1CodeDropdownRow : EnumMetadataItem<ExternalPaymentGroupStatus1Code>, IExternalPaymentGroupStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a group of payment instructions, as published in an external payment group status code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalPaymentGroupStatus1CodeDropdownRow(ExternalPaymentGroupStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
