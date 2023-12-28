﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyType2Code.  ISO2002 ID# _ZyVax9p-Ed-ak6NoX_4Aeg_-1463923724.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of party involved in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZyVax9p-Ed-ak6NoX_4Aeg_-1463923724")]
[Description(@"Specifies the type of party involved in the transaction.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Investor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZyVayNp-Ed-ak6NoX_4Aeg_1425772570")]
    [Description(@"??")]
    Investor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExecutingFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZyeksNp-Ed-ak6NoX_4Aeg_1488571424")]
    [Description(@"??")]
    ExecutingFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BrokerOfCredit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Zyeksdp-Ed-ak6NoX_4Aeg_1488571597")]
    [Description(@"??")]
    BrokerOfCredit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorrespondentClearingFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Zyekstp-Ed-ak6NoX_4Aeg_1488571614")]
    [Description(@"??")]
    CorrespondentClearingFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ContraFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Zyeks9p-Ed-ak6NoX_4Aeg_1488572277")]
    [Description(@"??")]
    ContraFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ContraClearingFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZyektNp-Ed-ak6NoX_4Aeg_1488572337")]
    [Description(@"??")]
    ContraClearingFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnderlyingContraFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Zyektdp-Ed-ak6NoX_4Aeg_1488572527")]
    [Description(@"??")]
    UnderlyingContraFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GiveUpClearingFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Zyekttp-Ed-ak6NoX_4Aeg_1488572864")]
    [Description(@"??")]
    GiveUpClearingFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OrderOriginationFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Zyekt9p-Ed-ak6NoX_4Aeg_1488573423")]
    [Description(@"??")]
    OrderOriginationFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SponsoringFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZyekuNp-Ed-ak6NoX_4Aeg_1488574258")]
    [Description(@"??")]
    SponsoringFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Clearingfirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Zyekudp-Ed-ak6NoX_4Aeg_1488574430")]
    [Description(@"??")]
    Clearingfirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IntroducingFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Zyekutp-Ed-ak6NoX_4Aeg_1489494904")]
    [Description(@"??")]
    IntroducingFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EnteringFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZyoVsNp-Ed-ak6NoX_4Aeg_1489495041")]
    [Description(@"??")]
    EnteringFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Client".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZyoVsdp-Ed-ak6NoX_4Aeg_1489495378")]
    [Description(@"??")]
    Client,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StepInBroker".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZyoVstp-Ed-ak6NoX_4Aeg_1489495860")]
    [Description(@"??")]
    StepInBroker,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyType2CodeMetadataExtensions
{
    private static readonly PartyType2CodeDropdownSource _dropdownSource = new PartyType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyType2CodeDropdownRow GetMetadata(this PartyType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

