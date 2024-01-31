﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CallType1Code.  ISO2002 ID# _ha1jvmliEeGaMcKyqKNRfQ_1930331494.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of execution of the call feature.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICallType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ha1jvmliEeGaMcKyqKNRfQ_1930331494")]
public partial class CallType1CodeDropdownSource : EnumMetadataManager<CallType1Code,ICallType1CodeDropdownRow,CallType1CodeDropdownRow>
{
    public CallType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CallType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
