﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Response9Code.  ISO2002 ID# _7CBR4Q1PEeqjM-rxn3HuXQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Result of the performed service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7CBR4Q1PEeqjM-rxn3HuXQ")]
[Description(@"Result of the performed service.")]
[DerivedFrom(typeof(ResponseCode))]
public enum Response9Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Approved".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7ORlMQ1PEeqjM-rxn3HuXQ")]
    [Description(@"??")]
    Approved,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Declined".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7ORlMw1PEeqjM-rxn3HuXQ")]
    [Description(@"??")]
    Declined,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartialApproved".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7ORlNQ1PEeqjM-rxn3HuXQ")]
    [Description(@"??")]
    PartialApproved,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Suspended".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9uQ1sQ1PEeqjM-rxn3HuXQ")]
    [Description(@"??")]
    Suspended,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TechnicalError".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_92_68Q1PEeqjM-rxn3HuXQ")]
    [Description(@"??")]
    TechnicalError,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Response9CodeMetadataExtensions
{
    private static readonly Response9CodeDropdownSource _dropdownSource = new Response9CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResponse9CodeDropdownRow GetMetadata(this Response9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

