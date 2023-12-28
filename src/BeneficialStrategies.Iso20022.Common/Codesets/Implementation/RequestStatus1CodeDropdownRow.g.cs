﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RequestStatus1Code.  ISO2002 ID# _ZT7nidp-Ed-ak6NoX_4Aeg_783372839.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the coded status of invoice financing request.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RequestStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IRequestStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZT7nidp-Ed-ak6NoX_4Aeg_783372839")]
public partial class RequestStatus1CodeDropdownRow : EnumMetadataItem<RequestStatus1Code>, IRequestStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the coded status of invoice financing request.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RequestStatus1CodeDropdownRow(RequestStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}