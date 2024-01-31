﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for LifeCycleSupport1Code.  ISO2002 ID# _Qs4p0FJ4EeeHVODnW-1ONQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the point in the transaction lifecycle at which the lifecycle identifier was assigned.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ILifeCycleSupport1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Qs4p0FJ4EeeHVODnW-1ONQ")]
public partial class LifeCycleSupport1CodeDropdownSource : EnumMetadataManager<LifeCycleSupport1Code,ILifeCycleSupport1CodeDropdownRow,LifeCycleSupport1CodeDropdownRow>
{
    public LifeCycleSupport1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new LifeCycleSupport1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
