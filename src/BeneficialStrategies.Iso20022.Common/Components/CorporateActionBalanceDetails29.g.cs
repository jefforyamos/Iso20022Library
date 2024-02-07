﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionBalanceDetails29.  ISO2002 ID# _LMSWcTq5EeWQ1Y7f8kds2A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Eligible and not eligible balance of securities for a corporate action event.
/// </summary>
public partial record CorporateActionBalanceDetails29
     : IIsoXmlSerilizable<CorporateActionBalanceDetails29>
{
    #nullable enable
    
    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    public TotalEligibleBalanceFormat8? TotalEligibleBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    public BalanceFormat5Choice_? BlockedBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    public BalanceFormat5Choice_? BorrowedBalance { get; init; } 
    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    public BalanceFormat5Choice_? CollateralInBalance { get; init; } 
    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    public BalanceFormat5Choice_? CollateralOutBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    public BalanceFormat5Choice_? OnLoanBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    public BalanceFormat6Choice_? PendingDeliveryBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    public BalanceFormat6Choice_? PendingReceiptBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    public BalanceFormat5Choice_? OutForRegistrationBalance { get; init; } 
    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    public BalanceFormat6Choice_? SettlementPositionBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    public BalanceFormat5Choice_? StreetPositionBalance { get; init; } 
    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    public BalanceFormat5Choice_? TradeDatePositionBalance { get; init; } 
    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    public BalanceFormat5Choice_? InTransshipmentBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    public BalanceFormat5Choice_? RegisteredBalance { get; init; } 
    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfil their obligation for the event to be complete, for example, return of securities for late announced drawing.
    /// </summary>
    public BalanceFormat5Choice_? ObligatedBalance { get; init; } 
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    public BalanceFormat5Choice_? UninstructedBalance { get; init; } 
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    public BalanceFormat5Choice_? InstructedBalance { get; init; } 
    /// <summary>
    /// Balance that has been affected by the process run through the event.
    /// </summary>
    public BalanceFormat5Choice_? AffectedBalance { get; init; } 
    /// <summary>
    /// Balance that has not been affected by the process run through the event.
    /// </summary>
    public BalanceFormat5Choice_? UnaffectedBalance { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (TotalEligibleBalance is TotalEligibleBalanceFormat8 TotalEligibleBalanceValue)
        {
            writer.WriteStartElement(null, "TtlElgblBal", xmlNamespace );
            TotalEligibleBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BlockedBalance is BalanceFormat5Choice_ BlockedBalanceValue)
        {
            writer.WriteStartElement(null, "BlckdBal", xmlNamespace );
            BlockedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BorrowedBalance is BalanceFormat5Choice_ BorrowedBalanceValue)
        {
            writer.WriteStartElement(null, "BrrwdBal", xmlNamespace );
            BorrowedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CollateralInBalance is BalanceFormat5Choice_ CollateralInBalanceValue)
        {
            writer.WriteStartElement(null, "CollInBal", xmlNamespace );
            CollateralInBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CollateralOutBalance is BalanceFormat5Choice_ CollateralOutBalanceValue)
        {
            writer.WriteStartElement(null, "CollOutBal", xmlNamespace );
            CollateralOutBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OnLoanBalance is BalanceFormat5Choice_ OnLoanBalanceValue)
        {
            writer.WriteStartElement(null, "OnLnBal", xmlNamespace );
            OnLoanBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PendingDeliveryBalance is BalanceFormat6Choice_ PendingDeliveryBalanceValue)
        {
            writer.WriteStartElement(null, "PdgDlvryBal", xmlNamespace );
            PendingDeliveryBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PendingReceiptBalance is BalanceFormat6Choice_ PendingReceiptBalanceValue)
        {
            writer.WriteStartElement(null, "PdgRctBal", xmlNamespace );
            PendingReceiptBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OutForRegistrationBalance is BalanceFormat5Choice_ OutForRegistrationBalanceValue)
        {
            writer.WriteStartElement(null, "OutForRegnBal", xmlNamespace );
            OutForRegistrationBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementPositionBalance is BalanceFormat6Choice_ SettlementPositionBalanceValue)
        {
            writer.WriteStartElement(null, "SttlmPosBal", xmlNamespace );
            SettlementPositionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StreetPositionBalance is BalanceFormat5Choice_ StreetPositionBalanceValue)
        {
            writer.WriteStartElement(null, "StrtPosBal", xmlNamespace );
            StreetPositionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeDatePositionBalance is BalanceFormat5Choice_ TradeDatePositionBalanceValue)
        {
            writer.WriteStartElement(null, "TradDtPosBal", xmlNamespace );
            TradeDatePositionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InTransshipmentBalance is BalanceFormat5Choice_ InTransshipmentBalanceValue)
        {
            writer.WriteStartElement(null, "InTrnsShipmntBal", xmlNamespace );
            InTransshipmentBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RegisteredBalance is BalanceFormat5Choice_ RegisteredBalanceValue)
        {
            writer.WriteStartElement(null, "RegdBal", xmlNamespace );
            RegisteredBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ObligatedBalance is BalanceFormat5Choice_ ObligatedBalanceValue)
        {
            writer.WriteStartElement(null, "OblgtdBal", xmlNamespace );
            ObligatedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UninstructedBalance is BalanceFormat5Choice_ UninstructedBalanceValue)
        {
            writer.WriteStartElement(null, "UinstdBal", xmlNamespace );
            UninstructedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructedBalance is BalanceFormat5Choice_ InstructedBalanceValue)
        {
            writer.WriteStartElement(null, "InstdBal", xmlNamespace );
            InstructedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AffectedBalance is BalanceFormat5Choice_ AffectedBalanceValue)
        {
            writer.WriteStartElement(null, "AfctdBal", xmlNamespace );
            AffectedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnaffectedBalance is BalanceFormat5Choice_ UnaffectedBalanceValue)
        {
            writer.WriteStartElement(null, "UafctdBal", xmlNamespace );
            UnaffectedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionBalanceDetails29 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
