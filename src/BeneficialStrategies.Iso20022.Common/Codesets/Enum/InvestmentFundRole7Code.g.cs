﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundRole7Code.  ISO2002 ID# _EfM6UF92EeS7xuKaq75oiQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of the party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EfM6UF92EeS7xuKaq75oiQ")]
[Description(@"Specifies the role of the party.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum InvestmentFundRole7Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Concentrator".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KLQeMV92EeS7xuKaq75oiQ")]
    [Description(@"??")]
    Concentrator,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Distributor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KxfXwV92EeS7xuKaq75oiQ")]
    [Description(@"??")]
    Distributor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FundManagementCompany".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_La2d0V92EeS7xuKaq75oiQ")]
    [Description(@"??")]
    FundManagementCompany,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Intermediary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_MBiDUV92EeS7xuKaq75oiQ")]
    [Description(@"??")]
    Intermediary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PayingAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NkBJwV92EeS7xuKaq75oiQ")]
    [Description(@"??")]
    PayingAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TransferAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_OiXBUV92EeS7xuKaq75oiQ")]
    [Description(@"??")]
    TransferAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Custodian".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9R7KwZy_EeSfkt2rmMY-dQ")]
    [Description(@"??")]
    Custodian,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashCorrespondent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-GJdAZy_EeSfkt2rmMY-dQ")]
    [Description(@"??")]
    CashCorrespondent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FundAccountant".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-0HWQZy_EeSfkt2rmMY-dQ")]
    [Description(@"??")]
    FundAccountant,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvestmentManager".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__cb6gZy_EeSfkt2rmMY-dQ")]
    [Description(@"??")]
    InvestmentManager,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Investor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__7OvUZy_EeSfkt2rmMY-dQ")]
    [Description(@"??")]
    Investor,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentFundRole7CodeMetadataExtensions
{
    private static readonly InvestmentFundRole7CodeDropdownSource _dropdownSource = new InvestmentFundRole7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentFundRole7CodeDropdownRow GetMetadata(this InvestmentFundRole7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

