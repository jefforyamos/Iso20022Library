﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMServiceType1Code.  ISO2002 ID# _yhZnkIogEeSirOZJBRz_nA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the type of withdrawal selected by the customer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMServiceType1CodeDropdownSource"/>.
/// Implements <seealso cref="IATMServiceType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_yhZnkIogEeSirOZJBRz_nA")]
public partial class ATMServiceType1CodeDropdownRow : EnumMetadataItem<ATMServiceType1Code>, IATMServiceType1CodeDropdownRow
{
    /// <summary>
    /// Describes the type of withdrawal selected by the customer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMServiceType1CodeDropdownRow(ATMServiceType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
