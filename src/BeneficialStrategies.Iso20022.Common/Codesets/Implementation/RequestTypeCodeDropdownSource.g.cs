﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RequestTypeCode.  ISO2002 ID# _ZUYTc9p-Ed-ak6NoX_4Aeg_-165761302.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the request used to further detail the type of information that will be queried.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRequestTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZUYTc9p-Ed-ak6NoX_4Aeg_-165761302")]
public partial class RequestTypeCodeDropdownSource : EnumMetadataManager<RequestTypeCode,IRequestTypeCodeDropdownRow,RequestTypeCodeDropdownRow>
{
    public RequestTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new RequestTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
