﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for LodgingService1Code.  ISO2002 ID# _uwes0GMtEeexSYCBvAp_qA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of lodging service.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ILodgingService1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_uwes0GMtEeexSYCBvAp_qA")]
public partial class LodgingService1CodeDropdownSource : EnumMetadataManager<LodgingService1Code,ILodgingService1CodeDropdownRow,LodgingService1CodeDropdownRow>
{
    public LodgingService1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new LodgingService1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
