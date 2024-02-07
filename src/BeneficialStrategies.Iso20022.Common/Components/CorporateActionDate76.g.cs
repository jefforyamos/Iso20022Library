﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate76.  ISO2002 ID# _cs43V_fSEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
public partial record CorporateActionDate76
     : IIsoXmlSerilizable<CorporateActionDate76>
{
    #nullable enable
    
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    public DateFormat49Choice_? EarlyResponseDeadline { get; init; } 
    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    public DateFormat49Choice_? CoverExpirationDate { get; init; } 
    /// <summary>
    /// Last date/time a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    public DateFormat49Choice_? ProtectDate { get; init; } 
    /// <summary>
    /// Issuer or issuer's agent deadline to respond with an instruction to an outstanding offer or privilege.
    /// </summary>
    public DateFormat49Choice_? MarketDeadline { get; init; } 
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    public DateFormat54Choice_? ResponseDeadline { get; init; } 
    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    public DateFormat49Choice_? ExpiryDate { get; init; } 
    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    public DateFormat49Choice_? SubscriptionCostDebitDate { get; init; } 
    /// <summary>
    /// Last day that a participant of the depository can deliver securities that it had elected on and/or previously protected.
    /// </summary>
    public DateFormat49Choice_? DepositoryCoverExpirationDate { get; init; } 
    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event, for which the underlying security is out on loan.
    /// </summary>
    public DateFormat49Choice_? StockLendingDeadline { get; init; } 
    /// <summary>
    /// Specifies the party borrowing stocks and the associated stock lending deadline assigned to the borrower.
    /// </summary>
    public BorrowerLendingDeadline6? BorrowerStockLendingDeadline { get; init; } 
    
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
        if (EarlyResponseDeadline is DateFormat49Choice_ EarlyResponseDeadlineValue)
        {
            writer.WriteStartElement(null, "EarlyRspnDdln", xmlNamespace );
            EarlyResponseDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CoverExpirationDate is DateFormat49Choice_ CoverExpirationDateValue)
        {
            writer.WriteStartElement(null, "CoverXprtnDt", xmlNamespace );
            CoverExpirationDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProtectDate is DateFormat49Choice_ ProtectDateValue)
        {
            writer.WriteStartElement(null, "PrtctDt", xmlNamespace );
            ProtectDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketDeadline is DateFormat49Choice_ MarketDeadlineValue)
        {
            writer.WriteStartElement(null, "MktDdln", xmlNamespace );
            MarketDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ResponseDeadline is DateFormat54Choice_ ResponseDeadlineValue)
        {
            writer.WriteStartElement(null, "RspnDdln", xmlNamespace );
            ResponseDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExpiryDate is DateFormat49Choice_ ExpiryDateValue)
        {
            writer.WriteStartElement(null, "XpryDt", xmlNamespace );
            ExpiryDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubscriptionCostDebitDate is DateFormat49Choice_ SubscriptionCostDebitDateValue)
        {
            writer.WriteStartElement(null, "SbcptCostDbtDt", xmlNamespace );
            SubscriptionCostDebitDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DepositoryCoverExpirationDate is DateFormat49Choice_ DepositoryCoverExpirationDateValue)
        {
            writer.WriteStartElement(null, "DpstryCoverXprtnDt", xmlNamespace );
            DepositoryCoverExpirationDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StockLendingDeadline is DateFormat49Choice_ StockLendingDeadlineValue)
        {
            writer.WriteStartElement(null, "StockLndgDdln", xmlNamespace );
            StockLendingDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BorrowerStockLendingDeadline is BorrowerLendingDeadline6 BorrowerStockLendingDeadlineValue)
        {
            writer.WriteStartElement(null, "BrrwrStockLndgDdln", xmlNamespace );
            BorrowerStockLendingDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionDate76 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
