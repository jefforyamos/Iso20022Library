﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RetailerResultDetail1Code.  ISO2002 ID# _KH5RwNxYEeioifFt1dhnJA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Result of the processing of the message
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRetailerResultDetail1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KH5RwNxYEeioifFt1dhnJA")]
public partial class RetailerResultDetail1CodeDropdownSource : EnumMetadataManager<RetailerResultDetail1Code,IRetailerResultDetail1CodeDropdownRow,RetailerResultDetail1CodeDropdownRow>
{
    public RetailerResultDetail1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RetailerResultDetail1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
