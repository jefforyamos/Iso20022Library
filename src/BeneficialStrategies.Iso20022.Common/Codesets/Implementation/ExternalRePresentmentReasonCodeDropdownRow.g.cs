﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalRePresentmentReasonCode.  ISO2002 ID# _BypvwLf9Eee9KIDjEHK7ZQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external representment reason code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalRePresentmentReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalRePresentmentReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BypvwLf9Eee9KIDjEHK7ZQ")]
public partial class ExternalRePresentmentReasonCodeDropdownRow : EnumMetadataItem<ExternalRePresentmentReasonCode>, IExternalRePresentmentReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the external representment reason code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalRePresentmentReasonCodeDropdownRow(ExternalRePresentmentReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}