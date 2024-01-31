﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RequestType1Code.  ISO2002 ID# _ZUOicNp-Ed-ak6NoX_4Aeg_979401735.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the request used to further detail the type of information that will be queried.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RequestType1CodeDropdownSource"/>.
/// Implements <seealso cref="IRequestType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZUOicNp-Ed-ak6NoX_4Aeg_979401735")]
public partial class RequestType1CodeDropdownRow : EnumMetadataItem<RequestType1Code>, IRequestType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the request used to further detail the type of information that will be queried.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RequestType1CodeDropdownRow(RequestType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
