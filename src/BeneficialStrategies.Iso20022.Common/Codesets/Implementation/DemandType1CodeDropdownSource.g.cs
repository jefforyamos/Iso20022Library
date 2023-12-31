﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DemandType1Code.  ISO2002 ID# __XQC0HyXEeGWJuGCfvwOsQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of demand for payment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDemandType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__XQC0HyXEeGWJuGCfvwOsQ")]
public partial class DemandType1CodeDropdownSource : EnumMetadataManager<DemandType1Code,IDemandType1CodeDropdownRow,DemandType1CodeDropdownRow>
{
    public DemandType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DemandType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
