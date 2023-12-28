﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EndpointCode.  ISO2002 ID# _znpagINmEeuHqfO1LgkE9Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of endpoint.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEndpointCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_znpagINmEeuHqfO1LgkE9Q")]
public partial class EndpointCodeDropdownSource : EnumMetadataManager<EndpointCode,IEndpointCodeDropdownRow,EndpointCodeDropdownRow>
{
    public EndpointCodeDropdownSource()
        : base( (enumValue, memberInfo) => new EndpointCodeDropdownRow(enumValue, memberInfo))
    {
    }
}