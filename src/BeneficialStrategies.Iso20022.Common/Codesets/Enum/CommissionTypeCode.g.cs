﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CommissionTypeCode.  ISO2002 ID# _VqbxSNp-Ed-ak6NoX_4Aeg_384306495.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of service for which the commission is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VqbxSNp-Ed-ak6NoX_4Aeg_384306495")]
[Description(@"Type of service for which the commission is asked or paid.")]
[Derivations(typeof(CommissionType5Code))]
// External derivations that should be provided by the proper interface are: 
public enum CommissionTypeCode
{
    /// <summary>
    /// Commission is as per client agreement.
    /// Encoded/decoded by serializers as "CLDI".
    /// </summary>
    [EnumMember(Value = "CLDI")]
    [IsoId("_Vqk7MNp-Ed-ak6NoX_4Aeg_384306530")]
    [Description(@"Commission is as per client agreement.")]
    ClientDirected,
    
    /// <summary>
    /// Commission for a step-out trade, charged by the step-out broker.
    /// Encoded/decoded by serializers as "STEP".
    /// </summary>
    [EnumMember(Value = "STEP")]
    [IsoId("_Vqk7Mdp-Ed-ak6NoX_4Aeg_384306572")]
    [Description(@"Commission for a step-out trade, charged by the step-out broker.")]
    StepOut,
    
    /// <summary>
    /// Type of service for which the commission is asked or paid.
    /// Encoded/decoded by serializers as "FEND".
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_Vqk7Mtp-Ed-ak6NoX_4Aeg_384306633")]
    [Description(@"Type of service for which the commission is asked or paid.")]
    FrontEnd,
    
    /// <summary>
    /// Commission paid at the time of first subscription.
    /// Encoded/decoded by serializers as "INIT".
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_Vqk7M9p-Ed-ak6NoX_4Aeg_384306686")]
    [Description(@"Commission paid at the time of first subscription.")]
    Initial,
    
    /// <summary>
    /// Commission for redeeming an investment, when an investor redeems an investment fund within a certain period of time.
    /// Encoded/decoded by serializers as "BEND".
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_Vqk7NNp-Ed-ak6NoX_4Aeg_384306728")]
    [Description(@"Commission for redeeming an investment, when an investor redeems an investment fund within a certain period of time.")]
    BackEnd,
    
    /// <summary>
    /// Commission that is calculated on the position of an account.
    /// Encoded/decoded by serializers as "TRAI".
    /// </summary>
    [EnumMember(Value = "TRAI")]
    [IsoId("_Vqk7Ndp-Ed-ak6NoX_4Aeg_384306988")]
    [Description(@"Commission that is calculated on the position of an account.")]
    Trailer,
    
    /// <summary>
    /// Commission that is regular.
    /// Encoded/decoded by serializers as "REGU".
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_Vqk7Ntp-Ed-ak6NoX_4Aeg_384307040")]
    [Description(@"Commission that is regular.")]
    Regular,
    
    /// <summary>
    /// Commission for a step-in trade.
    /// Encoded/decoded by serializers as "STEI".
    /// </summary>
    [EnumMember(Value = "STEI")]
    [IsoId("_Vqk7N9p-Ed-ak6NoX_4Aeg_384307083")]
    [Description(@"Commission for a step-in trade.")]
    StepIn,
    
    /// <summary>
    /// Soft dollar commission.
    /// Encoded/decoded by serializers as "SOFT".
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_Vqk7ONp-Ed-ak6NoX_4Aeg_384307118")]
    [Description(@"Soft dollar commission.")]
    SoftDollar,
    
    /// <summary>
    /// Commission for a step-in trade, charged by the step-in broker.
    /// Encoded/decoded by serializers as "SOIN".
    /// </summary>
    [EnumMember(Value = "SOIN")]
    [IsoId("_Vqk7Odp-Ed-ak6NoX_4Aeg_384307426")]
    [Description(@"Commission for a step-in trade, charged by the step-in broker.")]
    SoftDollarStepIn,
    
    /// <summary>
    /// Commission that combines soft dollar and step-out commission characteristics.
    /// Encoded/decoded by serializers as "SOUT".
    /// </summary>
    [EnumMember(Value = "SOUT")]
    [IsoId("_VqusMNp-Ed-ak6NoX_4Aeg_384307461")]
    [Description(@"Commission that combines soft dollar and step-out commission characteristics.")]
    SoftDollarStepOut,
    
    /// <summary>
    /// Commission for a plan sponsor's services.
    /// Encoded/decoded by serializers as "PLAN".
    /// </summary>
    [EnumMember(Value = "PLAN")]
    [IsoId("_VqusMdp-Ed-ak6NoX_4Aeg_384307521")]
    [Description(@"Commission for a plan sponsor's services.")]
    PlanSponsor,
    
    /// <summary>
    /// Commission is a percentage of principal.
    /// Encoded/decoded by serializers as "PERN".
    /// </summary>
    [EnumMember(Value = "PERN")]
    [IsoId("_VqusMtp-Ed-ak6NoX_4Aeg_384307563")]
    [Description(@"Commission is a percentage of principal.")]
    PercentageOfPrincipal,
    
    /// <summary>
    /// Amount or percentage that is added to an offer price when an investor buys from a broker or market maker. In this case, the price is adjusted to reflect changing market conditions.
    /// Encoded/decoded by serializers as "MARK".
    /// </summary>
    [EnumMember(Value = "MARK")]
    [IsoId("_VqusM9p-Ed-ak6NoX_4Aeg_384307598")]
    [Description(@"Amount or percentage that is added to an offer price when an investor buys from a broker or market maker. In this case, the price is adjusted to reflect changing market conditions.")]
    Markup,
    
    /// <summary>
    /// Amount of cash due to an intermediary for selling a product, or services, to a third party.
    /// Encoded/decoded by serializers as "CDPL".
    /// </summary>
    [EnumMember(Value = "CDPL")]
    [IsoId("_VqusNNp-Ed-ak6NoX_4Aeg_384307658")]
    [Description(@"Amount of cash due to an intermediary for selling a product, or services, to a third party.")]
    CommissionDePlacement,
    
    /// <summary>
    /// Amount financed to cover the back-end load.
    /// Encoded/decoded by serializers as "BCRD".
    /// </summary>
    [EnumMember(Value = "BCRD")]
    [IsoId("_VqusNdp-Ed-ak6NoX_4Aeg_384307718")]
    [Description(@"Amount financed to cover the back-end load.")]
    BrokerCredit,
    
    /// <summary>
    /// Commission is another type of transaction.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VqusNtp-Ed-ak6NoX_4Aeg_384307970")]
    [Description(@"Commission is another type of transaction.")]
    Other,
    
    /// <summary>
    /// Annual fund based renewal commission, expressed as a percentage of the deal.
    /// Encoded/decoded by serializers as "RNEW".
    /// </summary>
    [EnumMember(Value = "RNEW")]
    [IsoId("_VqusN9p-Ed-ak6NoX_4Aeg_384308013")]
    [Description(@"Annual fund based renewal commission, expressed as a percentage of the deal.")]
    FundBasedRenewal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CommissionTypeCodeMetadataExtensions
{
    private static readonly CommissionTypeCodeDropdownSource _dropdownSource = new CommissionTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICommissionTypeCodeDropdownRow GetMetadata(this CommissionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


