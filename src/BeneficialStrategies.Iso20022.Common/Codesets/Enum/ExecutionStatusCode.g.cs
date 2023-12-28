﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExecutionStatusCode.  ISO2002 ID# _kx_YcMX0EeiSF9q-coWegA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the status on a  transaction is pending initiation or has been initiated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kx_YcMX0EeiSF9q-coWegA")]
[Description(@"Specifies if the status on a  transaction is pending initiation or has been initiated.")]
[Derivations(typeof(ExecutionStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ExecutionStatusCode
{
    /// <summary>
    /// Transaction which has been initiated and has not yet closed.
    /// Encoded/decoded by serializers as "INTD".
    /// </summary>
    [EnumMember(Value = "INTD")]
    [IsoId("_9-YvcMX0EeiSF9q-coWegA")]
    [Description(@"Transaction which has been initiated and has not yet closed.")]
    Initiated,
    
    /// <summary>
    /// Pending Initiation.
    /// Encoded/decoded by serializers as "PINT".
    /// </summary>
    [EnumMember(Value = "PINT")]
    [IsoId("_CeKtcMX1EeiSF9q-coWegA")]
    [Description(@"Pending Initiation.")]
    PendingInitiation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExecutionStatusCodeMetadataExtensions
{
    private static readonly ExecutionStatusCodeDropdownSource _dropdownSource = new ExecutionStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExecutionStatusCodeDropdownRow GetMetadata(this ExecutionStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


