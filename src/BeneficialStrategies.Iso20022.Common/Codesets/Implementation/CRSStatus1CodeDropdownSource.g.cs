﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CRSStatus1Code.  ISO2002 ID# _L4GYEENsEeaS-NnwLNvMPg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the Common Reporting Status (CRS) status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICRSStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_L4GYEENsEeaS-NnwLNvMPg")]
public partial class CRSStatus1CodeDropdownSource : EnumMetadataManager<CRSStatus1Code,ICRSStatus1CodeDropdownRow,CRSStatus1CodeDropdownRow>
{
    public CRSStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CRSStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
