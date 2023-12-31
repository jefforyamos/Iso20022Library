﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalIncotermsCode.  ISO2002 ID# _9C-cIPeYEee0h5ZXun0VTA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the incoterms, as published in an external incoterms code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9C-cIPeYEee0h5ZXun0VTA")]
[Description(@"Specifies the incoterms, as published in an external incoterms code list. External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalIncoterms1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ExternalIncotermsCode
{
    /// <summary>
    /// Cost and Freight (sea and inland waterway transport) - Incoterms 2010
    /// Encoded/decoded by serializers as "CFR".
    /// </summary>
    [EnumMember(Value = "CFR")]
    [IsoId("_uH-6UPRYEeuLhpyIdtJzwg")]
    [Description(@"Cost and Freight (sea and inland waterway transport) - Incoterms 2010")]
    CostAndFreight,
    
    /// <summary>
    /// Cost, Insurance and Freight (sea and inland waterway transport) - Incoterms 2010
    /// Encoded/decoded by serializers as "CIF".
    /// </summary>
    [EnumMember(Value = "CIF")]
    [IsoId("_uH-6U_RYEeuLhpyIdtJzwg")]
    [Description(@"Cost, Insurance and Freight (sea and inland waterway transport) - Incoterms 2010")]
    CostInsuranceAndFreight,
    
    /// <summary>
    /// Carriage and Insurance Paid To (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as "CIP".
    /// </summary>
    [EnumMember(Value = "CIP")]
    [IsoId("_uIIrUPRYEeuLhpyIdtJzwg")]
    [Description(@"Carriage and Insurance Paid To (any mode of transport, including multimodal) - Incoterms 2010")]
    CarriageAndInsurancePaid,
    
    /// <summary>
    /// Carriage Paid To (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as "CPT".
    /// </summary>
    [EnumMember(Value = "CPT")]
    [IsoId("_uIIrU_RYEeuLhpyIdtJzwg")]
    [Description(@"Carriage Paid To (any mode of transport, including multimodal) - Incoterms 2010")]
    CarriagePaid,
    
    /// <summary>
    /// Delivered at Place (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as "DAP".
    /// </summary>
    [EnumMember(Value = "DAP")]
    [IsoId("_uIIrVvRYEeuLhpyIdtJzwg")]
    [Description(@"Delivered at Place (any mode of transport, including multimodal) - Incoterms 2010")]
    DeliveredAtPlace,
    
    /// <summary>
    /// Delivered at Terminal (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as "DAT".
    /// </summary>
    [EnumMember(Value = "DAT")]
    [IsoId("_uIIrWfRYEeuLhpyIdtJzwg")]
    [Description(@"Delivered at Terminal (any mode of transport, including multimodal) - Incoterms 2010")]
    DeliveredAtTerminal,
    
    /// <summary>
    /// Delivered Duty Paid (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as "DDP".
    /// </summary>
    [EnumMember(Value = "DDP")]
    [IsoId("_uIR1QPRYEeuLhpyIdtJzwg")]
    [Description(@"Delivered Duty Paid (any mode of transport, including multimodal) - Incoterms 2010")]
    DeliveredDutyPaid,
    
    /// <summary>
    /// Ex Works (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as "EXW".
    /// </summary>
    [EnumMember(Value = "EXW")]
    [IsoId("_uIR1Q_RYEeuLhpyIdtJzwg")]
    [Description(@"Ex Works (any mode of transport, including multimodal) - Incoterms 2010")]
    ExWorks,
    
    /// <summary>
    /// Free Alongside Ship (sea and inland waterway transport) - Incoterms 2010
    /// Encoded/decoded by serializers as "FAS".
    /// </summary>
    [EnumMember(Value = "FAS")]
    [IsoId("_uIR1RvRYEeuLhpyIdtJzwg")]
    [Description(@"Free Alongside Ship (sea and inland waterway transport) - Incoterms 2010")]
    FreeAlongsideShip,
    
    /// <summary>
    /// Free Carrier (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as "FCA".
    /// </summary>
    [EnumMember(Value = "FCA")]
    [IsoId("_uIR1SfRYEeuLhpyIdtJzwg")]
    [Description(@"Free Carrier (any mode of transport, including multimodal) - Incoterms 2010")]
    FreeCarrier,
    
    /// <summary>
    /// Free On Board (sea and inland waterway transport) - Incoterms 2010
    /// Encoded/decoded by serializers as "FOB".
    /// </summary>
    [EnumMember(Value = "FOB")]
    [IsoId("_uIR1TPRYEeuLhpyIdtJzwg")]
    [Description(@"Free On Board (sea and inland waterway transport) - Incoterms 2010")]
    FreeOnBoard,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalIncotermsCodeMetadataExtensions
{
    private static readonly ExternalIncotermsCodeDropdownSource _dropdownSource = new ExternalIncotermsCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalIncotermsCodeDropdownRow GetMetadata(this ExternalIncotermsCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


