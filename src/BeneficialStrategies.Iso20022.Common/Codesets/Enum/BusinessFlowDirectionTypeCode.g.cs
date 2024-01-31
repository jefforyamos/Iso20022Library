﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BusinessFlowDirectionTypeCode.  ISO2002 ID# _6_ikE_skEeCIi9ZETLBv8g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the business flow, in order to determine the role of the parties in the business process. This indicator is very important when there are multiple intermediaries in the exchange of information process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6_ikE_skEeCIi9ZETLBv8g")]
[Description(@"Identifies the business flow, in order to determine the role of the parties in the business process. This indicator is very important when there are multiple intermediaries in the exchange of information process.")]
[Derivations(typeof(BusinessFlowDirectionType1Code))]
public enum BusinessFlowDirectionTypeCode
{
    /// <summary>
    /// Assets to be delivered.
    /// Encoded/decoded by serializers as "ADLV".
    /// </summary>
    [EnumMember(Value = "ADLV")]
    [IsoId("_8y4J9_skEeCIi9ZETLBv8g")]
    [Description(@"Assets to be delivered.")]
    AssetstoBeDelivered,
    
    /// <summary>
    /// Assets to be received.
    /// Encoded/decoded by serializers as "ARCV".
    /// </summary>
    [EnumMember(Value = "ARCV")]
    [IsoId("_CNy6h_slEeCIi9ZETLBv8g")]
    [Description(@"Assets to be received.")]
    AssetsToBeReceived,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BusinessFlowDirectionTypeCodeMetadataExtensions
{
    private static readonly BusinessFlowDirectionTypeCodeDropdownSource _dropdownSource = new BusinessFlowDirectionTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBusinessFlowDirectionTypeCodeDropdownRow GetMetadata(this BusinessFlowDirectionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


