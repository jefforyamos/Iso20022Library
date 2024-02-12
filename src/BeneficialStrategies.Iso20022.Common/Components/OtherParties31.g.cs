﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherParties31.  ISO2002 ID# _spFnoZjjEeWn2ur3BXxtdg.
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
/// Other parties information.
/// </summary>
[IsoId("_spFnoZjjEeWn2ur3BXxtdg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Other Parties")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherParties31
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_s4QsE5jjEeWn2ur3BXxtdg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification110? Investor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification110? Investor { get; init; } 
    #else
    public PartyIdentification110? Investor { get; set; } 
    #endif
    
    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_s4QsG5jjEeWn2ur3BXxtdg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Qualified Foreign Intermediary")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification111? QualifiedForeignIntermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification111? QualifiedForeignIntermediary { get; init; } 
    #else
    public PartyIdentification111? QualifiedForeignIntermediary { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_s4QsI5jjEeWn2ur3BXxtdg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Stock Exchange")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification111? StockExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification111? StockExchange { get; init; } 
    #else
    public PartyIdentification111? StockExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_s4QsK5jjEeWn2ur3BXxtdg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Regulator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification111? TradeRegulator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification111? TradeRegulator { get; init; } 
    #else
    public PartyIdentification111? TradeRegulator { get; set; } 
    #endif
    
    /// <summary>
    /// Party responsible for the administration of a tri-party collateral transaction including collateral allocation, marking to market and substitution of collateral.
    /// </summary>
    [IsoId("_s4QsM5jjEeWn2ur3BXxtdg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Triparty Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification111? TripartyAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification111? TripartyAgent { get; init; } 
    #else
    public PartyIdentification111? TripartyAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
