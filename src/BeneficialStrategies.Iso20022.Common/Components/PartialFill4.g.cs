﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartialFill4.  ISO2002 ID# _3k2WFQd4Ee2fOITqoTnSLQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intention to transfer an ownership of a financial instrument.
/// </summary>
[IsoId("_3k2WFQd4Ee2fOITqoTnSLQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Partial Fill")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartialFill4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartialFill4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartialFill4( Quantity6Choice_ reqConfirmationQuantity,Price14 reqDealPrice,QuantityOrAmount2Choice_ reqOriginalOrderedQuantity,QuantityOrAmount2Choice_ reqPreviouslyExecutedQuantity,QuantityOrAmount2Choice_ reqRemainingQuantity )
    {
        ConfirmationQuantity = reqConfirmationQuantity;
        DealPrice = reqDealPrice;
        OriginalOrderedQuantity = reqOriginalOrderedQuantity;
        PreviouslyExecutedQuantity = reqPreviouslyExecutedQuantity;
        RemainingQuantity = reqRemainingQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument to be ordered.
    /// </summary>
    [IsoId("_34ENBQd4Ee2fOITqoTnSLQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Confirmation Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity6Choice_ ConfirmationQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Quantity6Choice_ ConfirmationQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity6Choice_ ConfirmationQuantity { get; init; } 
    #else
    public Quantity6Choice_ ConfirmationQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_34ENDQd4Ee2fOITqoTnSLQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Deal Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Price14 DealPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Price14 DealPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14 DealPrice { get; init; } 
    #else
    public Price14 DealPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_34ENDwd4Ee2fOITqoTnSLQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDate7Choice_? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate7Choice_? TradeDate { get; init; } 
    #else
    public TradeDate7Choice_? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Market in which a trade transaction is to be or has been executed.
    /// </summary>
    [IsoId("_34ENFwd4Ee2fOITqoTnSLQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Place Of Trade")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification97? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification97? PlaceOfTrade { get; init; } 
    #else
    public MarketIdentification97? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument ordered.
    /// </summary>
    [IsoId("_34ENHwd4Ee2fOITqoTnSLQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Ordered Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QuantityOrAmount2Choice_ OriginalOrderedQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public QuantityOrAmount2Choice_ OriginalOrderedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrAmount2Choice_ OriginalOrderedQuantity { get; init; } 
    #else
    public QuantityOrAmount2Choice_ OriginalOrderedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument that has been previously executed.
    /// </summary>
    [IsoId("_34ENJwd4Ee2fOITqoTnSLQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Previously Executed Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QuantityOrAmount2Choice_ PreviouslyExecutedQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public QuantityOrAmount2Choice_ PreviouslyExecutedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrAmount2Choice_ PreviouslyExecutedQuantity { get; init; } 
    #else
    public QuantityOrAmount2Choice_ PreviouslyExecutedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument that is remaining in order.
    /// </summary>
    [IsoId("_34ENLwd4Ee2fOITqoTnSLQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Remaining Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QuantityOrAmount2Choice_ RemainingQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public QuantityOrAmount2Choice_ RemainingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrAmount2Choice_ RemainingQuantity { get; init; } 
    #else
    public QuantityOrAmount2Choice_ RemainingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity that applies to every execution. The order may still fill against smaller orders, but the cumulative quantity of the execution must be in multiples of the Match Increment.
    /// </summary>
    [IsoId("_34ENNwd4Ee2fOITqoTnSLQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Match Increment Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrAmount2Choice_? MatchIncrementQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrAmount2Choice_? MatchIncrementQuantity { get; init; } 
    #else
    public QuantityOrAmount2Choice_? MatchIncrementQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
