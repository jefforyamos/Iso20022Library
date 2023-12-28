﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FutureAndOptionContractTypeCode.  ISO2002 ID# __2sIc9ojEeC60axPepSq7g_-1368478268.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Future And Option Contract Type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__2sIc9ojEeC60axPepSq7g_-1368478268")]
[Description(@"Future And Option Contract Type.")]
public enum FutureAndOptionContractTypeCode
{
    /// <summary>
    /// Ordinary future and option contract.
    /// Encoded/decoded by serializers as "ORDY".
    /// </summary>
    [EnumMember(Value = "ORDY")]
    [IsoId("__2sIdNojEeC60axPepSq7g_-1350560951")]
    [Description(@"Ordinary future and option contract.")]
    Ordinary,
    
    /// <summary>
    /// Future and option contract on an index as opposed to an underlying equity.
    /// Encoded/decoded by serializers as "INDX".
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("__2sIddojEeC60axPepSq7g_381029970")]
    [Description(@"Future and option contract on an index as opposed to an underlying equity.")]
    Index,
    
    /// <summary>
    /// Receipt of future contract when an option on a future is exercised.
    /// Encoded/decoded by serializers as "EXFU".
    /// </summary>
    [EnumMember(Value = "EXFU")]
    [IsoId("__2sIdtojEeC60axPepSq7g_257916990")]
    [Description(@"Receipt of future contract when an option on a future is exercised.")]
    ExercisedFuture,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FutureAndOptionContractTypeCodeMetadataExtensions
{
    private static readonly FutureAndOptionContractTypeCodeDropdownSource _dropdownSource = new FutureAndOptionContractTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFutureAndOptionContractTypeCodeDropdownRow GetMetadata(this FutureAndOptionContractTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


