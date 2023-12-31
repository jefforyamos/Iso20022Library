﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TemporaryServicesCharge1Code.  ISO2002 ID# _3qdwkDEvEemzCpWiCwK4aQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Charge types for temporary services
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITemporaryServicesCharge1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3qdwkDEvEemzCpWiCwK4aQ")]
public partial class TemporaryServicesCharge1CodeDropdownSource : EnumMetadataManager<TemporaryServicesCharge1Code,ITemporaryServicesCharge1CodeDropdownRow,TemporaryServicesCharge1CodeDropdownRow>
{
    public TemporaryServicesCharge1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TemporaryServicesCharge1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
