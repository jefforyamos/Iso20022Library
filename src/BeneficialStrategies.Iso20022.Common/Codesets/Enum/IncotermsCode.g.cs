﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for IncotermsCode.  ISO2002 ID# _aWPZGdp-Ed-ak6NoX_4Aeg_-1978994118.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A set of international standard trade terms (delivery terms) used to designate a point at which the costs and risks of transport are divided between the buyer and the seller.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aWPZGdp-Ed-ak6NoX_4Aeg_-1978994118")]
[Description(@"A set of international standard trade terms (delivery terms) used to designate a point at which the costs and risks of transport are divided between the buyer and the seller.")]
[Derivations(typeof(Incoterms1Code))]
public enum IncotermsCode
{
    /// <summary>
    /// Ex Works (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as "EXW".
    /// </summary>
    [EnumMember(Value = "EXW")]
    [IsoId("_aWZKENp-Ed-ak6NoX_4Aeg_-1978994117")]
    [Description(@"Ex Works (any mode of transport, including multimodal).")]
    ExWorks,
    
    /// <summary>
    /// Free Carrier (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as "FCA".
    /// </summary>
    [EnumMember(Value = "FCA")]
    [IsoId("_aWZKEdp-Ed-ak6NoX_4Aeg_-1978994116")]
    [Description(@"Free Carrier (any mode of transport, including multimodal).")]
    FreeCarrier,
    
    /// <summary>
    /// Free Alongside Ship (sea and inland waterway transport).
    /// Encoded/decoded by serializers as "FAS".
    /// </summary>
    [EnumMember(Value = "FAS")]
    [IsoId("_aWZKEtp-Ed-ak6NoX_4Aeg_-1978994115")]
    [Description(@"Free Alongside Ship (sea and inland waterway transport).")]
    FreeAlongsideShip,
    
    /// <summary>
    /// Free On Board (sea and inland waterway transport).
    /// Encoded/decoded by serializers as "FOB".
    /// </summary>
    [EnumMember(Value = "FOB")]
    [IsoId("_aWZKE9p-Ed-ak6NoX_4Aeg_-1978994114")]
    [Description(@"Free On Board (sea and inland waterway transport).")]
    FreeOnBoard,
    
    /// <summary>
    /// Cost and Freight (sea and inland waterway transport).
    /// Encoded/decoded by serializers as "CFR".
    /// </summary>
    [EnumMember(Value = "CFR")]
    [IsoId("_aWZKFNp-Ed-ak6NoX_4Aeg_-1978994113")]
    [Description(@"Cost and Freight (sea and inland waterway transport).")]
    CostAndFreight,
    
    /// <summary>
    /// Cost, Insurance and Freight (sea and inland waterway transport).
    /// Encoded/decoded by serializers as "CIF".
    /// </summary>
    [EnumMember(Value = "CIF")]
    [IsoId("_aWZKFdp-Ed-ak6NoX_4Aeg_-1978994112")]
    [Description(@"Cost, Insurance and Freight (sea and inland waterway transport).")]
    CostInsuranceAndFreight,
    
    /// <summary>
    /// Carriage Paid To (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as "CPT".
    /// </summary>
    [EnumMember(Value = "CPT")]
    [IsoId("_aWZKFtp-Ed-ak6NoX_4Aeg_-1978994111")]
    [Description(@"Carriage Paid To (any mode of transport, including multimodal).")]
    CarriagePaid,
    
    /// <summary>
    /// Carriage and Insurance Paid to (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as "CIP".
    /// </summary>
    [EnumMember(Value = "CIP")]
    [IsoId("_aWZKF9p-Ed-ak6NoX_4Aeg_-1978994110")]
    [Description(@"Carriage and Insurance Paid to (any mode of transport, including multimodal).")]
    CarriageAndInsurancePaid,
    
    /// <summary>
    /// Delivered At Frontier (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as "DAF".
    /// </summary>
    [EnumMember(Value = "DAF")]
    [IsoId("_aWZKGNp-Ed-ak6NoX_4Aeg_-1978994102")]
    [Description(@"Delivered At Frontier (any mode of transport, including multimodal).")]
    DeliveredAtFrontier,
    
    /// <summary>
    /// Delivered Ex Ship (sea and inland waterway transport).
    /// Encoded/decoded by serializers as "DES".
    /// </summary>
    [EnumMember(Value = "DES")]
    [IsoId("_aWZKGdp-Ed-ak6NoX_4Aeg_-1978994101")]
    [Description(@"Delivered Ex Ship (sea and inland waterway transport).")]
    DeliveredExShip,
    
    /// <summary>
    /// Delivered Ex Quay (sea and inland waterway transport).
    /// Encoded/decoded by serializers as "DEQ".
    /// </summary>
    [EnumMember(Value = "DEQ")]
    [IsoId("_aWiUANp-Ed-ak6NoX_4Aeg_-1978994100")]
    [Description(@"Delivered Ex Quay (sea and inland waterway transport).")]
    DeliveredExQuay,
    
    /// <summary>
    /// Delivered Duty Unpaid (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as "DDU".
    /// </summary>
    [EnumMember(Value = "DDU")]
    [IsoId("_aWiUAdp-Ed-ak6NoX_4Aeg_-1978994099")]
    [Description(@"Delivered Duty Unpaid (any mode of transport, including multimodal).")]
    DeliveredDutyUnpaid,
    
    /// <summary>
    /// Delivered Duty Paid (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as "DDP".
    /// </summary>
    [EnumMember(Value = "DDP")]
    [IsoId("_aWiUAtp-Ed-ak6NoX_4Aeg_-1978994098")]
    [Description(@"Delivered Duty Paid (any mode of transport, including multimodal).")]
    DeliveredDutyPaid,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class IncotermsCodeMetadataExtensions
{
    private static readonly IncotermsCodeDropdownSource _dropdownSource = new IncotermsCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IIncotermsCodeDropdownRow GetMetadata(this IncotermsCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


