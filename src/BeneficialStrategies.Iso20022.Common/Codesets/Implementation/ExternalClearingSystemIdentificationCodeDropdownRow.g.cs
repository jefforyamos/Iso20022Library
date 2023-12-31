﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalClearingSystemIdentificationCode.  ISO2002 ID# _mjIcEIKWEeeCI5iKR7LsYQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the clearing system identification code, as published in an external clearing system identification code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalClearingSystemIdentificationCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalClearingSystemIdentificationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_mjIcEIKWEeeCI5iKR7LsYQ")]
public partial class ExternalClearingSystemIdentificationCodeDropdownRow : EnumMetadataItem<ExternalClearingSystemIdentificationCode>, IExternalClearingSystemIdentificationCodeDropdownRow
{
    /// <summary>
    /// Specifies the clearing system identification code, as published in an external clearing system identification code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalClearingSystemIdentificationCodeDropdownRow(ExternalClearingSystemIdentificationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
