﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionReversalReasonV2Code.  ISO2002 ID# _DUt1SjQVEe2o-K1dwNg8Gg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// The reason why a reversal of payment is taking place in corporate action processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DUt1SjQVEe2o-K1dwNg8Gg")]
[Description(@"The reason why a reversal of payment is taking place in corporate action processing.")]
[Derivations(typeof(CorporateActionReversalReason2Code))]
// External derivations that should be provided by the proper interface are: 
public enum CorporateActionReversalReasonV2Code
{
    /// <summary>
    /// Difference in day count basis.
    /// Encoded/decoded by serializers as "DCBD".
    /// </summary>
    [EnumMember(Value = "DCBD")]
    [IsoId("_DUt1SzQVEe2o-K1dwNg8Gg")]
    [Description(@"Difference in day count basis.")]
    DayCountBasisDifference,
    
    /// <summary>
    /// Value date is incorrect.
    /// Encoded/decoded by serializers as "IVAD".
    /// </summary>
    [EnumMember(Value = "IVAD")]
    [IsoId("_DUt1UDQVEe2o-K1dwNg8Gg")]
    [Description(@"Value date is incorrect.")]
    IncorrectValueDate,
    
    /// <summary>
    /// Entitlement date is incorrect.
    /// Encoded/decoded by serializers as "IRED".
    /// </summary>
    [EnumMember(Value = "IRED")]
    [IsoId("_DUt1TDQVEe2o-K1dwNg8Gg")]
    [Description(@"Entitlement date is incorrect.")]
    IncorrectEntitlementDate,
    
    /// <summary>
    /// Price is incorrect.
    /// Encoded/decoded by serializers as "IPRI".
    /// </summary>
    [EnumMember(Value = "IPRI")]
    [IsoId("_DUt1TzQVEe2o-K1dwNg8Gg")]
    [Description(@"Price is incorrect.")]
    IncorrectPrice,
    
    /// <summary>
    /// Payment is not due.
    /// Encoded/decoded by serializers as "UPAY".
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_DUt1TTQVEe2o-K1dwNg8Gg")]
    [Description(@"Payment is not due.")]
    UnduePayment,
    
    /// <summary>
    /// Event level tax rate is incorrect.
    /// Encoded/decoded by serializers as "IETR".
    /// </summary>
    [EnumMember(Value = "IETR")]
    [IsoId("_DUt1UTQVEe2o-K1dwNg8Gg")]
    [Description(@"Event level tax rate is incorrect.")]
    IncorrectEventLevelTaxRate,
    
    /// <summary>
    /// Funds have not been received.
    /// Encoded/decoded by serializers as "FNRC".
    /// </summary>
    [EnumMember(Value = "FNRC")]
    [IsoId("_DUt1TjQVEe2o-K1dwNg8Gg")]
    [Description(@"Funds have not been received.")]
    FundsNotReceived,
    
    /// <summary>
    /// Payment will occur outside of clearing system.
    /// Encoded/decoded by serializers as "POCS".
    /// </summary>
    [EnumMember(Value = "POCS")]
    [IsoId("_DUt1UjQVEe2o-K1dwNg8Gg")]
    [Description(@"Payment will occur outside of clearing system.")]
    PaymentOutsideClearingSystem,
    
    /// <summary>
    /// Payment currency is incorrect.
    /// Encoded/decoded by serializers as "IPCU".
    /// </summary>
    [EnumMember(Value = "IPCU")]
    [IsoId("_DUt1UzQVEe2o-K1dwNg8Gg")]
    [Description(@"Payment currency is incorrect.")]
    IncorrectPaymentCurrency,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionReversalReasonV2CodeMetadataExtensions
{
    private static readonly CorporateActionReversalReasonV2CodeDropdownSource _dropdownSource = new CorporateActionReversalReasonV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionReversalReasonV2CodeDropdownRow GetMetadata(this CorporateActionReversalReasonV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


