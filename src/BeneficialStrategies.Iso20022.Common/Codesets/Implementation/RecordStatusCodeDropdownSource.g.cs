﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RecordStatusCode.  ISO2002 ID# _P8v9YNHDEeaokquJJ-K6uA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the processing of an individual record within a message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRecordStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_P8v9YNHDEeaokquJJ-K6uA")]
public partial class RecordStatusCodeDropdownSource : EnumMetadataManager<RecordStatusCode,IRecordStatusCodeDropdownRow,RecordStatusCodeDropdownRow>
{
    public RecordStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new RecordStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
