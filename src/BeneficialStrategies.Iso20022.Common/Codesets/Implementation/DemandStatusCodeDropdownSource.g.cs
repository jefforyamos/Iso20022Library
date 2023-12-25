﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DemandStatusCode.  ISO2002 ID# _xyDjAHyYEeGWJuGCfvwOsQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the demand for payment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDemandStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xyDjAHyYEeGWJuGCfvwOsQ")]
public partial class DemandStatusCodeDropdownSource : EnumMetadataManager<DemandStatusCode,IDemandStatusCodeDropdownRow,DemandStatusCodeDropdownRow>
{
    public DemandStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DemandStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
