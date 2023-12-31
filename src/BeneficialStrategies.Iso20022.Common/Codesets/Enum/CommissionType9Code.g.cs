﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CommissionType9Code.  ISO2002 ID# __1f1pNojEeC60axPepSq7g_1349927182.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of service for which the commission is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__1f1pNojEeC60axPepSq7g_1349927182")]
[Description(@"Type of service for which the commission is asked or paid.")]
[DerivedFrom(typeof(CommissionTypeV2Code))]
public enum CommissionType9Code
{
    /// <summary>
    /// Commission is as per client agreement.
    /// Encoded/decoded by serializers as "ClientDirected".
    /// </summary>
    [EnumMember(Value = "CLDI")]
    [IsoId("__1f1pdojEeC60axPepSq7g_1512056713")]
    [Description(@"Commission is as per client agreement.")]
    ClientDirected,
    
    /// <summary>
    /// Commission for a step-out trade, charged by the step-out broker.
    /// Encoded/decoded by serializers as "StepOut".
    /// </summary>
    [EnumMember(Value = "STEP")]
    [IsoId("__1f1ptojEeC60axPepSq7g_-1258842287")]
    [Description(@"Commission for a step-out trade, charged by the step-out broker.")]
    StepOut,
    
    /// <summary>
    /// Commission designated by the broker for third party services. The soft dollar arrangement refers to an arrangement wherean investment manager directs transactions to a brokerand, in exchange, the broker provides brokerage and research services to the investment manager. Soft dollar arrangements include proprietary and third party research arrangements, but do not include client-directed brokerage arrangements. The U.S. Securities Exchange Act of 1934, Section 238(e), created a "safe harbor" to protect investment managers from claims that they had breached their fiduciary duties by using their client commissions to pay a higher commission than they might have paid for execution services to acquire investment research. The SEC defines soft dollars as: The Commission has defined soft dollar practices as arrangements under which products or services, other than execution of securities transactions, are obtained through an adviser or a broker-dealer in exchange for the direction by the adviser of client brokerage transactions to the broker-dealer. An individual or firm must exercise "investment discretion" over an account, as defined in Section 3(a)(35) of the Exchange Act, in order to use client commissions to obtain research under Section 28(e) of the Exchange Act ("Section 28(e)").
    /// Encoded/decoded by serializers as "SoftDollar".
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("__1pmoNojEeC60axPepSq7g_1775834527")]
    [Description(@"Commission designated by the broker for third party services. The soft dollar arrangement refers to an arrangement wherean investment manager directs transactions to a brokerand, in exchange, the broker provides brokerage and research services to the investment manager. Soft dollar arrangements include proprietary and third party research arrangements, but do not include client-directed brokerage arrangements. The U.S. Securities Exchange Act of 1934, Section 238(e), created a ""safe harbor"" to protect investment managers from claims that they had breached their fiduciary duties by using their client commissions to pay a higher commission than they might have paid for execution services to acquire investment research. The SEC defines soft dollars as: The Commission has defined soft dollar practices as arrangements under which products or services, other than execution of securities transactions, are obtained through an adviser or a broker-dealer in exchange for the direction by the adviser of client brokerage transactions to the broker-dealer. An individual or firm must exercise ""investment discretion"" over an account, as defined in Section 3(a)(35) of the Exchange Act, in order to use client commissions to obtain research under Section 28(e) of the Exchange Act (""Section 28(e)"").")]
    SoftDollar,
    
    /// <summary>
    /// Commission is a percentage of principal.
    /// Encoded/decoded by serializers as "PercentageOfPrincipal".
    /// </summary>
    [EnumMember(Value = "PERN")]
    [IsoId("__1pmodojEeC60axPepSq7g_873266936")]
    [Description(@"Commission is a percentage of principal.")]
    PercentageOfPrincipal,
    
    /// <summary>
    /// Commission is a flat fee.
    /// Encoded/decoded by serializers as "FlatFee".
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("__1pmotojEeC60axPepSq7g_1287212868")]
    [Description(@"Commission is a flat fee.")]
    FlatFee,
    
    /// <summary>
    /// Commission is per unit of financial instrument.
    /// Encoded/decoded by serializers as "PerUnit".
    /// </summary>
    [EnumMember(Value = "PERU")]
    [IsoId("__1pmo9ojEeC60axPepSq7g_1438210713")]
    [Description(@"Commission is per unit of financial instrument.")]
    PerUnit,
    
    /// <summary>
    /// Commission is a percentage commission waived as cash discount.
    /// Encoded/decoded by serializers as "PercentageCommissionWaivedAsCashDiscount".
    /// </summary>
    [EnumMember(Value = "PWCD")]
    [IsoId("__1pmpNojEeC60axPepSq7g_-1332688287")]
    [Description(@"Commission is a percentage commission waived as cash discount.")]
    PercentageCommissionWaivedAsCashDiscount,
    
    /// <summary>
    /// Commission is a percentage commission waived as additional units.
    /// Encoded/decoded by serializers as "PercentageCommissionWaivedAsAdditionalUnits".
    /// </summary>
    [EnumMember(Value = "PWEU")]
    [IsoId("__1pmpdojEeC60axPepSq7g_366205654")]
    [Description(@"Commission is a percentage commission waived as additional units.")]
    PercentageCommissionWaivedAsAdditionalUnits,
    
    /// <summary>
    /// Brokerage commission.
    /// Encoded/decoded by serializers as "BrokerageRate".
    /// </summary>
    [EnumMember(Value = "BRKR")]
    [IsoId("__1pmptojEeC60axPepSq7g_970428610")]
    [Description(@"Brokerage commission.")]
    BrokerageRate,
    
    /// <summary>
    /// Differential or deferred payment commission rate.  .
    /// Encoded/decoded by serializers as "DifferentialOrDeferredPayment".
    /// </summary>
    [EnumMember(Value = "DFDP")]
    [IsoId("__1ywkNojEeC60axPepSq7g_1148547282")]
    [Description(@"Differential or deferred payment commission rate.  .")]
    DifferentialOrDeferredPayment,
    
    /// <summary>
    /// Commission is based on points per bond or contract.
    /// Encoded/decoded by serializers as "PointsPerBondOrContract".
    /// </summary>
    [EnumMember(Value = "PBOC")]
    [IsoId("__1ywkdojEeC60axPepSq7g_278267935")]
    [Description(@"Commission is based on points per bond or contract.")]
    PointsPerBondOrContract,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CommissionType9CodeMetadataExtensions
{
    private static readonly CommissionType9CodeDropdownSource _dropdownSource = new CommissionType9CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICommissionType9CodeDropdownRow GetMetadata(this CommissionType9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


