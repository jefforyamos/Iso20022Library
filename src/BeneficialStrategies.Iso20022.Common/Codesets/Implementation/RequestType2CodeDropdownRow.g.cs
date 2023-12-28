﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RequestType2Code.  ISO2002 ID# _ZUOidtp-Ed-ak6NoX_4Aeg_-957935555.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the request used to further detail the type of information that will be queried.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RequestType2CodeDropdownSource"/>.
/// Implements <seealso cref="IRequestType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZUOidtp-Ed-ak6NoX_4Aeg_-957935555")]
public partial class RequestType2CodeDropdownRow : EnumMetadataItem<RequestType2Code>, IRequestType2CodeDropdownRow
{
    /// <summary>
    /// Specifies the request used to further detail the type of information that will be queried.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RequestType2CodeDropdownRow(RequestType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}